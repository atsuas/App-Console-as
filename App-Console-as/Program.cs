using System;
using System.Text;
using System.Linq;

namespace App_Console_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = Library.Books
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(g => g.Key);
        }
    }
}
