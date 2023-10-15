using System;

namespace AliSalmeh_ProjectWeek8_LibraryCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of books with different types
            Book[] libraryCatalog = new Book[]
            {
                new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
                new FictionBook("Dune", "Frank Herbert", 412, "Science Fiction"),
                new NonFictionBook("Sapiens", "Yuval Noah Harari", 512, "History"),
                new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help"),
            };

            // Display information about all the books in the library
            Library.DisplayBooks(libraryCatalog);
        }
    }
}
