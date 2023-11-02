using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите букву: ");
            char b = Console.ReadKey().KeyChar;
            int c = a.Count(f => (f == b));
            Console.WriteLine();
            Console.WriteLine("Кол-во использования символа: " + c);

        }
    }
}
