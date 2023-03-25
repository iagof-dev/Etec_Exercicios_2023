using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descontamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, desconto;

            Console.Write("Informe o seu salário:");
            salario = Convert.ToDouble( Console.ReadLine());

            Console.Write("Informe o % de desconto:");
            desconto = Convert.ToDouble(Console.ReadLine());

            double total = ((desconto/100)* salario);
            double liquido = (salario - total);
            Console.WriteLine($"Salário atualizado: {liquido.ToString("C")}");

            Console.ReadKey();


        }
    }
}
