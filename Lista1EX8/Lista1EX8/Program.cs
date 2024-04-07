using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c;
            double f;

            Console.Write("Digite uma temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());

            f = (c * 1.8) + 32;

            Console.Write("A temperatura dada em Celsius será ");
            Console.Write(f);
            Console.WriteLine(" Fahrenheit");
        }   
    }
}
