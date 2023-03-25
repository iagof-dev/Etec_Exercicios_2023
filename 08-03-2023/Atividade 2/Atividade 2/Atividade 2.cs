using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de Gasto Mensal";
            double total_value, transporte_value, cantina_value, apm_value, xerox_value;

            Console.WriteLine("====================================");

            Console.WriteLine("Digite o valor do transporte:");
            transporte_value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do Cantiona:");
            cantina_value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do APM:");
            apm_value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do Xerox:");
            xerox_value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("====================================");

            total_value = (transporte_value + cantina_value + apm_value + xerox_value);
            Console.WriteLine($"Valor total gasto foi: R${total_value}");


            Console.ReadKey();




        }
    }
}
