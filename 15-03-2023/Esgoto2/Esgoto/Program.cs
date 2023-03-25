using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esgoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxa_esgoto, total_conta;
            Console.WriteLine("Informe o valor da taxa de esgoto");
            taxa_esgoto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total da conta");
            total_conta = Convert.ToDouble(Console.ReadLine());

            double resultado = (taxa_esgoto / total_conta);

            Console.WriteLine("O percentual da taxa é: " + resultado.ToString("P"));

            Console.ReadKey();


        }
    }
}
