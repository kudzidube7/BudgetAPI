﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetingAPI.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int TotalAmount { get; set; }
        public int TotalExpenses { get; set; }
        public int TotalIncome { get; set; }
        public int TotalNumberOfAccounts { get; set; }
    }
}
