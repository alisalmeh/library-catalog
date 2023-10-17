using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek8_LibraryCatalog
{
    public class NonFictionBook : Book
    {
        public string Topic { get; set; }

        public NonFictionBook(string title, string author, int pages, string topic) : base(title, author, pages)
        {
            Topic = topic;
        }

        public override string ToString()
        {
            return "----------\n" +
                $"Title: {Title}\nAuthor: {Author}\nPages: {Pages}\nTopic: {Topic}\n" +
                "----------";
        }
    }
}