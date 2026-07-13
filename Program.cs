using Library_Management_System;

Console.WriteLine($"Welcom To Our Library ");



Library L1 =new Library();

// add BookId
Console.WriteLine("Add Book 1 programming\n");

Book B1 = new Book
{

    Author = "Mohamed Awadallah",
    Year = 2026,
    Genre = "Programming",
    
    Title = "Book Of Progamming"
};

L1.AddBook(B1);

// 2 BookId
Console.WriteLine("Add Book 2 programming ...\n");

Book B2 = new Book
{

    Author = "Medo Awadallah",
    Year = 2025,
    Genre = "OOP",
    Title = "Book Of OOP"
};
L1.AddBook(B2);


// add members
Console.WriteLine("Add Mmeber 1 Omina ...\n");

Member M1 = new Member
            {
                Id = 1,
                Name = "Omina Mahmoud",
                Email = "Omina@gmail.com"
            
            };

  L1.AddMember(M1);

Console.WriteLine("Add  Mmeber 1 Aya ...\n");

PremiumMember PM1 = new PremiumMember
{
    Id = 1,
    Name = "Aya",
    Email = "Aya@gmail.com"

};
L1.AddMember(PM1);

// borrow BookId MemberId
Console.WriteLine("Borrow  Mmeber 1 BookId programming ...");

L1.BorrowBooks(PM1, B2);
L1.ReturnBook(PM1, B2);

Console.WriteLine("Boorow  Mmeber 2 BookId OOP/n/n");

L1.BorrowBooks(M1, B1);
L1.ReturnBook(M1, B1);


L1.BorrowBooks(PM1, B1);
L1.BorrowBooks(M1, B2);
//match book
//Console.WriteLine(L1.MatchBook("OOP"));

//match member
//Console.WriteLine(L1.MatchMember("Aya"));

// all Book
//L1.AllBook();
Console.WriteLine("\n\n");
// all member
//L1.AllMemer();

// all Borrowed Book
//L1.AllBorrowdBook();

// all aavielabel Book
//L1.ReturnBook(M1,B2);
//L1.AllAvilabelBook();


//Member Borrowing History
//L1.MemberBorrowingHistory("Omina Mahmoud");
