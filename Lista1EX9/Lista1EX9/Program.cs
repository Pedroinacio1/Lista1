using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double r;

            Console.Write("Digite o diâmetro de um circulo: ");
            d = double.Parse(Console.ReadLine());

            r = (d / 2 * d / 2) * 3.1415;

            Console.Write("O valor da área do circulo é:");
            Console.WriteLine(r);

        }
    }
}
