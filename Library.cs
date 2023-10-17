using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek8_LibraryCatalog
{
    public class Library
    {
        public static void DisplayBooks(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine("----------");
                book.DisplayBasicInfo();
                book.DisplayAdditionalInfo();
                Console.WriteLine("----------");
            }
        }
    }
}