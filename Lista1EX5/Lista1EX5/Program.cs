using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int r;


            Console.Write("Escreva o primeiro valor : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Escreva o segundo valor : ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Escreva o terceiro valor : ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Escreva o quarto valor : ");
            d = int.Parse(Console.ReadLine());

            r = (a + b + c + d) / 4;

            Console.Write("O valor da média aritmética é: ");
            Console.WriteLine(r);
        }
    }
}
