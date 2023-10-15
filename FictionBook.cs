using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek8_LibraryCatalog
{
    public class FictionBook : Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }

        public FictionBook(string title, string author, int pages, string genre)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Genre = genre;
        }

        public override string ToString()
        {
            return "----------\n" +
                $"Title: {Title}\nAuthor: {Author}\nPages: {Pages}\nGenre: {Genre}\n" +
                "----------";
        }
    }
}