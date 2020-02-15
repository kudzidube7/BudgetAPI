using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetingAPI.Models;
using BudgetingAPI.DataTransferObjects;
using BudgetingAPI.Database;
using AutoMapper;

namespace BudgetingAPI.Repositories.Implementations
{
    public class AccountRepository : IAccountRepository, IDisposable
    {
        private BudgetDbContext context;
        private readonly IMapper _mapper;

        public AccountRepository(BudgetDbContext context, IMapper mapper)
        {
            this.context = context;
            this._mapper = mapper;
        }
        public void AddAccount(Account account)
        {
            try
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
     public  IEnumerable<AccountDto> GetAllAccounts()
      {
            try
            {
                IEnumerable<AccountDto> accounts;
                accounts = _mapper.Map<List<AccountDto>>(context.Accounts.ToList());

                return accounts;
            }
            catch (Exception)
            {

                throw;
            }
    
      }
        public AccountDto GetAccountById(int id)
        {
            try
            {
                AccountDto account = _mapper.Map<AccountDto>(context.Accounts.Find(id));
                return account;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateAccount(Account account)
        {
            context.Accounts.Update(account);
            context.SaveChanges();
        
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
