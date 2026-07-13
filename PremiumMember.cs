using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public class PremiumMember : Member
    {

        public override int MaxBorrowLimit { get; set; } = 10;
        public override int LoanDays { get; set; } = 30;

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $"\nMember Type: Premium" +
                   $"\nMax Borrow Limit: {MaxBorrowLimit}" +
                   $"\nLoan Days: {LoanDays}";
        }

    }
}
