using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E_LEARNING.APPLICATION.Base.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Class> Classes { get; set; }
        DbSet<ClassDetail> ClassDetails { get; set; }
        DbSet<ClassTeacherReference> ClassTeacherReferences { get; set; }
        DbSet<ScoreLearning> ScoreLearnings { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Test> Tests { get; set; }


        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransaction();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
