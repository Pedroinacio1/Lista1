using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            int a;


            Console.Write("Escreva o valor da diagonal do quadrado: ");
            d = int.Parse(Console.ReadLine());

            a = (d * d) / 2;

            Console.Write("A área do quadrado é: ");

            Console.WriteLine(a);
        }
    }
}
