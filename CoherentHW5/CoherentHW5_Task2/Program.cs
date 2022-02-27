using CoherentHW5_Task2.Entities;

namespace CoherentHW5_Task2;

class Program
{
    static void Main()
    {
        var firstBook = new Book("The Wonderful Wizard of Oz", new DateTime(1970, 5, 1), new HashSet<string>() { "LL. Frank Baum" });
        var secondBook = new Book("The Adventures of Tom Sawyer", new DateTime(1876,1,1), new HashSet<string>() { "Mark Twain" });
        var thirdBook = new Book("War and Peaces", new DateTime(1869, 1, 1), new HashSet<string>() { "Leo Tolstoy" });
        
        var catalogOne = new Catalog("Top readable");

        catalogOne.AddNewBook("978-1-62-692394-2", firstBook);
        catalogOne.AddNewBook("978-0-48-629156-7", secondBook);
        catalogOne.AddNewBook("978-0-14-044063-8", thirdBook);

        Console.WriteLine(catalogOne);

        var fourthBook = catalogOne.GetBookByIsbn("9780140440638");
        var fifthBook = catalogOne.GetBookByIsbn("978-0-14-044063-8");
        Console.WriteLine(fourthBook);
        Console.WriteLine(fifthBook);
    }
}