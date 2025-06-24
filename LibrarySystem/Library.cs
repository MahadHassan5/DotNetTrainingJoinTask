using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    public List<Book> Books = new();
    public List<User> Users = new();

    public void AddBook(Book book)
    {
        book.Id = Books.Count + 1;
        Books.Add(book);
        Console.WriteLine($"✅ Book added: {book.Title}");
    }

    public void DisplayBooks()
    {
        Console.WriteLine("\n📚 Library Books:");
        foreach (var book in Books)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, ISBN: {book.ISBN}, Qty: {book.Quantity}, Status: {book.Status}");
        }
    }

    public void BorrowBook(int bookId)
    {
        var book = Books.FirstOrDefault(b => b.Id == bookId);
        if (book != null && book.Quantity > 0)
        {
            book.Quantity--;
            Console.WriteLine($"📖 Borrowed: {book.Title}");
        }
        else
        {
            Console.WriteLine("❌ Book not available.");
        }
    }

    public void ReturnBook(int bookId)
    {
        var book = Books.FirstOrDefault(b => b.Id == bookId);
        if (book != null)
        {
            book.Quantity++;
            Console.WriteLine($"✅ Returned: {book.Title}");
        }
        else
        {
            Console.WriteLine("❌ Book ID not found.");
        }
    }

    public void SearchBooks(string keyword)
    {
        var results = Books.Where(b => b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine($"\n🔍 Search Results for '{keyword}':");
        if (results.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        foreach (var book in results)
        {
            Console.WriteLine($"- {book.Title} (Qty: {book.Quantity}, Status: {book.Status})");
        }
    }
}
