using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Relations.Aggregation
{
    public class Library
    {
        public List<Book> Books { get; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }

}
