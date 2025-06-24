using System;

class Program
{
    static void Main()
    {
        Library library = new();

        while (true)
        {
            Console.WriteLine("\n📘 Library System Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Search Book");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter title: ");
                    var title = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    var isbn = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    library.AddBook(new Book { Title = title, ISBN = isbn, Quantity = qty });
                    break;

                case "2":
                    library.DisplayBooks();
                    break;

                case "3":
                    Console.Write("Enter Book ID to borrow: ");
                    int borrowId = int.Parse(Console.ReadLine());
                    library.BorrowBook(borrowId);
                    break;

                case "4":
                    Console.Write("Enter Book ID to return: ");
                    int returnId = int.Parse(Console.ReadLine());
                    library.ReturnBook(returnId);
                    break;

                case "5":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    library.SearchBooks(keyword);
                    break;

                case "0":
                    Console.WriteLine("Exiting Library System. Goodbye!");
                    return;

                default:
                    Console.WriteLine("❌ Invalid choice. Try again.");
                    break;
            }
        }
    }
}