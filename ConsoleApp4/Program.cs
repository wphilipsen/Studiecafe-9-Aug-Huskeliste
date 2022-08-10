using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Things = new List<string>();

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Indtast ting du skal huske nummer " + i);
                Things.Add(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Du skal huske følgende:");
            Console.WriteLine();
            Console.WriteLine(String.Join(", ", Things));
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("Hvad har du pakket?");
                Things.Remove(Console.ReadLine());
                Console.WriteLine("Du mangler stadig følgende:");
                Console.WriteLine(String.Join(", ", Things));

            }
            Console.WriteLine("Du har pakket færdig!");

            Console.ReadKey();
        }
    }
}
