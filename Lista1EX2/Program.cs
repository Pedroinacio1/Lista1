using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Escreva o valor da base do quadrado: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Escreva o valor da altura do quadrado: ");
            b = int.Parse(Console.ReadLine());

            c = a * b;

            Console.Write("O valor da área do quadrado é: ");
            Console.WriteLine(c);

        }
    }
}
