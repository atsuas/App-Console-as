using System;
using System.Text;
using System.Linq;

namespace App_Console_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = Library.Books
                               .OrderBy(b => b.CategoryId)
                               .ThenBtDescendung(b => b.PublishedYear);

        }
    }
}
