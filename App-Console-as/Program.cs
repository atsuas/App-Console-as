using System;

namespace App_Console_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "The quick";
            var words = text.Split(new[] { ' ', '.' },
                            StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
