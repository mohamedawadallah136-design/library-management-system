using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public  class BorrowRecord
    {
        public int ID { set; get; }
        public required Member MemberId { set; get; }
        public required Book BookId { set; get; }
        public DateTime BorrowedDate { set; get; } = DateTime.Now;
        public int BorrowDays { set; get; }
        public DateTime? ReturnDate { set; get; }

        public bool IsLate => ReturnDate.HasValue && (ReturnDate.Value - BorrowedDate).Days > BorrowDays;
        public int DaysLate()
        {
            if (!ReturnDate.HasValue)
                return 0;

            return (ReturnDate.Value - BorrowedDate).Days;
        }

        public  string GetInfo()
        {
            return $" {MemberId.Name}  {BookId.Genre} ({IsLate}) ";
        }


    }
}
