using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetingAPI.Models;
using AutoMapper;
using BudgetingAPI.DataTransferObjects;

namespace BudgetingAPI.Automapper
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, TransactionDto>();
        }
    }
}
