using Library_Management_System;
using System;
namespace Library_Management_System;
public class Book : LibraryItem , ISearchable
{
    public required string Author { get; set; }
    public int Year { get; set; }
    public required string Genre { get; set; }
    public bool IsAvailable { get; set; } = true;



    public override string GetInfo()
    {
        return $"Id: {Id}\n" +
               $"Title: {Title}\n" +
               $"Author: {Author}\n" +
               $"Year: {Year}\n" +
               $"Genre: {Genre}\n" +
               $"Available: {(IsAvailable ? "Yes" : "No")}";
    }
    public bool MatchesQuery(string query)
    {
        return Title.Contains(query, StringComparison.OrdinalIgnoreCase)
            || Author.Contains(query, StringComparison.OrdinalIgnoreCase)
            || Genre.Contains(query, StringComparison.OrdinalIgnoreCase);
    }
}


