﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer
{
    public class CostumerAccount
    {
        public int CostumerAccountId { get; set; }
        public string CostumerAccountNumber { get; set; }
        public string CostumerAccountCurrency { get; set; }
        public decimal CostumerAccountBalance { get; set; }
        public string BankBranch { get; set; }
        

    }
}
