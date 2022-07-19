using E_LEARNING.APPLICATION.Base.Exceptions;
using E_LEARNING.APPLICATION.Base.Extensions;
using E_LEARNING.APPLICATION.Base.Interfaces;
using E_LEARNING.CORE.Base;
using E_LEARNING.CORE.BaseEnumeration;
using E_LEARNING.CORE.BusinessDomain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E_LEARNING.APPLICATION.Business.AccountFunctions.Commands.CreateCommand
{
    public class CreateAccountCmd : IRequest<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public int? StudentId { get; set; }
        public int? AdminId { get; set; }
        public int? TeacherId { get; set; }
    }
    public class CreateAccountCmdHandler : IRequestHandler<CreateAccountCmd, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IPasswordService _passwordService;

        public CreateAccountCmdHandler(IApplicationDbContext context, IPasswordService passwordService)
        {
            _context = context;
            _passwordService = passwordService;
        }

        public async Task<int> Handle(CreateAccountCmd request, CancellationToken cancellationToken)
        {
            try
            {
                await _context.BeginTransactionAsync();
                var students = await _context.Students.Where(e => e.DeleteFlag == DeleteFlag.Available.Value).ToListAsync();
                var admins = await _context.Admins.Where(e => e.DeleteFlag == DeleteFlag.Available.Value).ToListAsync();
                var teachers = await _context.Teachers.Where(e => e.DeleteFlag == DeleteFlag.Available.Value).ToListAsync();
                var accounts = await _context.Accounts.Where(e => e.DeleteFlag == DeleteFlag.Available.Value).ToListAsync();

                // validator
                if (request.AdminId.HasValue && admins.FirstOrDefault(e => e.Id == request.AdminId.Value) == null)
                {
                    throw new ValidationException(string.Format(ApplicationMessage.ERR_MSG_NOT_EXIST, ApplicationObjects.ADMIN));
                }

                if (request.StudentId.HasValue && students.FirstOrDefault(e => e.Id == request.StudentId.Value) == null)
                {
                    throw new ValidationException(string.Format(ApplicationMessage.ERR_MSG_NOT_EXIST, ApplicationObjects.STUDENT));
                }

                if (request.TeacherId.HasValue && teachers.FirstOrDefault(e => e.Id == request.TeacherId.Value) == null)
                {
                    throw new ValidationException(string.Format(ApplicationMessage.ERR_MSG_NOT_EXIST, ApplicationObjects.TEACHER));
                }

                if (!string.IsNullOrEmpty(request.Username) && accounts.Any(s => !string.IsNullOrEmpty(s.Username) && s.Username.ToLower().Trim().Equals(request.Username.ToLower().Trim())))
                {
                    throw new NotFoundException(string.Format(ApplicationMessage.ERR_MSG_UNIQUE, ApplicationObjects.USER_NAME));
                }
                var entity = new Account
                {
                    Username = request.Username.TrimWhenNotNull(),
                    Password = _passwordService.HashPassword(request.Password),
                    Email = request.Email.TrimWhenNotNull(),
                    Phone = request.Phone.TrimWhenNotNull(),
                    Type = request.Type.TrimWhenNotNull(),
                };
                await _context.Accounts.AddAsync(entity);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
               await _context.RollbackTransaction();
                throw;
            }
           

        }
    }
}
