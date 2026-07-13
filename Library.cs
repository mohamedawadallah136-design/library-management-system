using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System;

    public class Library
    {
   public   Book[] books = new Book[100];

   private int bookCount = 0;

   public  Member[] Members = new Member[100];

   private int MenbersCount = 0;

    public BorrowRecord[] BorrowRecords = new BorrowRecord[100];
    private int BorrowRecordsCount = 0;


    // Add boks
    public bool AddBook(Book book)
    {
        book.Id = bookCount + 1;

        books[bookCount] = book;

        bookCount++;
        return true;
    }

    public int ManyBooks => bookCount;

    // add MemberId
    public bool AddMember(Member member)
    {
        Members[MenbersCount] = member;
        MenbersCount++;
        return true;
    }

    public int NumberMembers => MenbersCount;

    //Borrow books
    public bool BorrowBooks(Member member, Book book)
    {
        if ((member.ListBooks.Count >= member.MaxBorrowLimit) && book.IsAvailable == true)
            return false;

        member.ListBooks.Add(book);

        book.IsAvailable = false;

        BorrowRecord BR = new BorrowRecord
        {
            ID = BorrowRecordsCount+1,
            MemberId = member,
            BookId = book,
            BorrowDays = member.LoanDays,
            BorrowedDate = DateTime.Now
            

        };
        BorrowRecords[BorrowRecordsCount]=BR;
        BorrowRecordsCount++;

        return true;
    }

    public int NumberBorrowBooks => BorrowRecordsCount;

    // Return Book
    public bool ReturnBook(Member member, Book book)
    {
        book.IsAvailable=true;

        member.ListBooks.Remove(book);

        BorrowRecord? Br = HaveBorrowRecord(member,book);
        Br?.ReturnDate = DateTime.Now;

        return true;
    }

    public BorrowRecord? HaveBorrowRecord(Member member, Book book)
    {
        foreach(BorrowRecord A in BorrowRecords)
        {
            if (A.BookId.Id == book.Id && member.Id == A.MemberId.Id)
                return A;
        }
        return null;
    }

    // matches query book

    public string MatchBook(string query)
    {
        foreach(Book book in books)
        {
            if (book.MatchesQuery(query))
                return book.GetInfo();
        }
        return "Book Not Found";
    }
    // matches query member

    public string MatchMember(string query)
    {
        foreach (Member member in Members)
        {
            if (member.MatchesQuery(query))
                return member.GetInfo();
        }
        return "Member Not Found";
    }

    // all Book

    public void AllBook()
    {
        foreach (Book book in books)
        {
            if (book is null)
                return;

               Console.WriteLine(book.GetInfo());
        }
        
    }
    // all member

    public void AllMemer()
    {
        foreach (Member member in Members)
        {
            if (member is null)
                return;

                 Console.WriteLine(member.GetInfo());
        }
    }
    // all Borrowed Book
    public void AllBorrowdBook()
    {
        foreach (Book book in books)
        {if (book == null)
                return;

            if(!book.IsAvailable)
            Console.WriteLine(book.GetInfo());
        }
    }

    // all aavielabel Book
    public void AllAvilabelBook()
    {
        foreach (Book book in books)
        {
            if (book == null)
                return;   if (book.IsAvailable)
                Console.WriteLine(book.GetInfo());
        }
    }

    //Member Borrowing History
    public void MemberBorrowingHistory(string name)
    {
        foreach(BorrowRecord b in BorrowRecords)
        {
            if (b == null)
                return;  
            if(b.MemberId.Name.ToLower() == name.ToLower())
              Console.WriteLine(  b.GetInfo());
        }
    }



}




