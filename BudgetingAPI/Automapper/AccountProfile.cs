using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetingAPI.Models;
using BudgetingAPI.DataTransferObjects;
using AutoMapper;

namespace BudgetingAPI.Automapper
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Account, AccountDto>();
        }
    }
}
