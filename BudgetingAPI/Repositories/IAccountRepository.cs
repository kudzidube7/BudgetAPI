using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetingAPI.Models;
using BudgetingAPI.DataTransferObjects;

namespace BudgetingAPI.Repositories
{
   public interface IAccountRepository
    {
        void AddAccount(Account account);
        IEnumerable<AccountDto> GetAllAccounts();
        AccountDto GetAccountById(int id);

        void UpdateAccount(Account account);
    }
}
