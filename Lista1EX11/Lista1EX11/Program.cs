using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.Write("Digite o valor de uma base: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de um expoente: ");
            b = double.Parse(Console.ReadLine());

            c = Math.Pow(a, b);

            Console.Write("O valor desta potência é: ");
            Console.WriteLine(c);

        }
    }
}
