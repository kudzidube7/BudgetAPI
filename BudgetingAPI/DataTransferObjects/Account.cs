using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetingAPI.Enums;

namespace BudgetingAPI.DataTransferObjects

{
    public class AccountDto
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public AccountType AccountType { get; set; }
        public int AccountBalance { get; set; }


    }
}
