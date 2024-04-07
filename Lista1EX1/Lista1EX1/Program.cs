using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            
            Console.WriteLine("Escreva o valor da base do retângulo: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor da altura do retângulo: ");
            b = int.Parse(Console.ReadLine());

            c = a*b ;

            Console.Write("A área deste retângulo é: ");
            Console.WriteLine(c);
            


        }
    }
}
