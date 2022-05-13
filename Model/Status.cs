using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Status
    {
        private int borrowYesterday;
        private int borrowBeforeYesterday;
        private int totalBorrow;
        private int visitYesterday;
        private int visitBeforeYesterday;
        private int totalVisit;
        private int overdueYesterday;
        private int overdueBeforeYesterday;
        private int totalOverdue;

        public int BorrowYesterday
        {
            get => borrowYesterday;
            set => borrowYesterday = value;
        }

        public int BorrowBeforeYesterday
        {
            get => borrowBeforeYesterday;
            set => borrowBeforeYesterday = value;
        }

        public int TotalBorrow
        {
            get => totalBorrow;
            set => totalBorrow = value;
        }

        public int VisitYesterday
        {
            get => visitYesterday;
            set => visitYesterday = value;
        }

        public int VisitBeforeYesterday
        {
            get => visitBeforeYesterday;
            set => visitBeforeYesterday = value;
        }

        public int TotalVisit
        {
            get => totalVisit;
            set => totalVisit = value;
        }

        public int TotalOverdue
        {
            get => totalOverdue;
            set => totalOverdue = value;
        }

        public int OverdueYesterday
        {
            get => overdueYesterday;
            set => overdueYesterday = value;
        }

        public int OverdueBeforeYesterday
        {
            get => overdueBeforeYesterday;
            set => overdueBeforeYesterday = value;
        }
    }
}