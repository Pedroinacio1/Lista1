using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double r;

            Console.Write("Escreva o primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Escreva o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            r = Math.Sqrt(a * b);
            Console.Write("O resultado da média geométrica é: ");
            Console.WriteLine(r);
        }
    }
}
