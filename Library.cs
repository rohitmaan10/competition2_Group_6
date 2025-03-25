using System;
using System.Collections.Generic;

class Library {
    private List<Book> books = new List<Book>();
    private List<Person> patrons = new List<Person>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void AddPatron(Person patron)
    {
        patrons.Add(patron);
    }
    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
        }
    }
    public void DisplayPatrons()
    {
        Console.WriteLine("\nPatrons in Library:");
        foreach (var patron in patrons)
        {
            Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
        }
    }
    public void BorrowBook(string patronName, string bookTitle) {
        Book book = books.Find(b => b.Title == bookTitle);
        if (book != null && book.BorrowBook()) {
            Console.WriteLine($"{patronName} borrowed '{bookTitle}'");
        }
        else {
            Console.WriteLine($"{bookTitle} is not available for borrowing.");
        }
    }
}

class Program {
    static void Main() {
        Library library = new Library();

        // Creating books
        Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
        Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
        Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
        
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        
        // Creating students and staff
        Student student1 = new Student("Rohit", "rohit@usf.edu", "S001", "Business Analytics", 2026);
        Student student2 = new Student("Damineni", "damineni@usf.edu", "S002", "Information Systems", 2025);
        Staff staff1 = new Staff("Srisatya", "sri@usf.edu", "ST001", "Librarian", "Library Services");
        
        library.AddPatron(student1);
        library.AddPatron(student2);
        library.AddPatron(staff1);
        
        // Display initial data
        library.DisplayBooks();
        library.DisplayPatrons();
        
        // Borrowing books
        Console.WriteLine("\nBorrowing Books...");
        library.BorrowBook("Rohit", "Business Insights with AI");
        library.BorrowBook("Damineni", "Analytics in Action");
        
        // Display updated books data
        Console.WriteLine("\nBooks after borrowing:");
        library.DisplayBooks();
    }
}
