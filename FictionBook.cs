using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek8_LibraryCatalog
{
    public class FictionBook : Book
    {
        public string Genre { get; set; }

        public FictionBook(string title, string author, int pages, string genre) : base(title, author, pages)
        {
            Genre = genre;
        }

        public override void DisplayAdditionalInfo()
        {
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}