using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E_LEARNING.APPLICATION.Base.Interfaces
{
    public interface IApplicationDbContext
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransaction();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
