using internetBankingProject.Data;
using internetBankingProject.Models;
using InternetBankingProject.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.Repository
{
    public class UnitOfWork : IUnitOfWork

    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<AccountRight> _accountrights;

        private IGenericRepository<DeliveryMode> _deliverymodes;

        private IGenericRepository<RetailAccount> _retailaccounts;
        private IGenericRepository<RetailUser> _retailusers;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<AccountRight> AccountRights => _accountrights ??= new GenericRepository<AccountRight>(_context);

        public IGenericRepository<DeliveryMode> DeliveryModes => _deliverymodes ??= new GenericRepository<DeliveryMode>(_context);

        public IGenericRepository<RetailAccount> RetailAccounts => _retailaccounts ??= new GenericRepository<RetailAccount>(_context);

        public IGenericRepository<RetailUser> RetailUsers => _retailusers ??= new GenericRepository<RetailUser>(_context);
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

       

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
