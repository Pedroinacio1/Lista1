using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;
            double r;

            Console.Write("Digite o valor da milha máritima: ");
            m = double.Parse(Console.ReadLine());

            r = (m * 1852)/1000;

            Console.Write("O valor da milha máritima em quilômetros é: ");
            Console.WriteLine (r);

            
        }
    }
}
