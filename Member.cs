using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Data;
namespace Library_Management_System
{
    public class Member : ISearchable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public DateTime JoinDate { get; set; } = DateTime.Now;

        public virtual int MaxBorrowLimit { get; set; } = 5;
        public virtual int LoanDays { get; set; } = 15;



        public List<Book> ListBooks { get; set; } = new List<Book>();

        public virtual string GetInfo()
        {
            return $"ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Email: {Email}\n" +
                   $"Join Date: {JoinDate:d}";
        }
        public bool MatchesQuery(string query)
        {
            return Name.Contains(query, StringComparison.OrdinalIgnoreCase);

        }
    }
}
