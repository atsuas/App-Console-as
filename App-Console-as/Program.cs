using System;
using System.Text;
using System.Linq;

namespace App_Console_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = Library.Books
                               .Select(b => b.PublishedYear)
                               .Distinct()
                               .OrderBy(y => y);
            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }
    }
}
