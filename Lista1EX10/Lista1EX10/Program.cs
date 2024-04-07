using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dol;
            double r;

            Console.Write("Digite a quantidade de dólar desejada: ");
            dol = double.Parse(Console.ReadLine());

            r = dol * 5.07;

            Console.Write("O valor de ");
            Console.Write(dol);
            Console.Write(" US$ equivale ");
            Console.Write(r);
            Console.WriteLine(" R$");
        }
    }
}
