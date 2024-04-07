using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c; 
            double d;
            double e;
            double valor;
            double total;
            double troco;

            Console.Write("Digite o valor do primeiro produto: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Segundo produto: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro produto: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quarto produto: ");
            d = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quinto produto: ");
            e = double.Parse(Console.ReadLine());

            total = a + b + c + d + e;

            Console.Write("valor total: ");
            Console.WriteLine(total);
            Console.Write("Digite o valor que irar ser pago: ");
            valor = double.Parse(Console.ReadLine());
            troco = valor - total;
            Console.Write("Valor do troco: ");
            Console.WriteLine(troco);

        }
    }
}
