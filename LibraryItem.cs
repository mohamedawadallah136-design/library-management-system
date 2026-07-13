using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public abstract class LibraryItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime AdeddDate { get; set; }= DateTime.Now;

        public abstract string GetInfo();


    }
}
