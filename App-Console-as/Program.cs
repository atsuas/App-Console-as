using System;
using System.Text;
using System.Linq;

namespace App_Console_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = new int[] { 2013, 2016 };
            var books = Library.Books
                               .Where(b => years.Contains(b.PublishedYear));
        }
    }
}
