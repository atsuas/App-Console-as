using System;
using System.Text;

namespace App_Console_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            foreach (var word in GetWords())
            {
                sb.Append(word);
            }
            var text = sb.ToString();
            Console.WriteLine(text);
        }
    }
}
