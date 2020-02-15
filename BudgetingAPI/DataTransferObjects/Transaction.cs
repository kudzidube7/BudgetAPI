using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetingAPI.Enums;
namespace BudgetingAPI.DataTransferObjects
{
    public class TransactionDto
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionDescription { get; set; }
        public Category TransactionCategory { get; set; }
    }
}
