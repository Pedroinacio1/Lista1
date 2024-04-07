using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int r;

            Console.Write("Escreva o valor da altura do triângulo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Escreva o valor da base do triângulo: ");
            b = int.Parse(Console.ReadLine());

            r = (a * b) / 2;

            Console.Write("O valor da área do triângulo é:");
            Console.WriteLine(r);


        }
    }
}
