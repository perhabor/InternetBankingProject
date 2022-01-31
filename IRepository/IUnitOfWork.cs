using internetBankingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.IRepository
{
   public interface IUnitOfWork : IDisposable
    {
       IGenericRepository<AccountRight> AccountRights { get; }
        IGenericRepository<DeliveryMode> DeliveryModes { get; }

        IGenericRepository<RetailAccount> RetailAccounts { get; }

        IGenericRepository<RetailUser> RetailUsers { get; }

        Task Save();



    }
}
