using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pecas, venda, compra;
            double despesas_fix;

            Console.Write("Informe o número de peças:");
            pecas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor de vendas:");
            venda = Convert.ToInt32(Console.ReadLine());

            int faturamento = (venda * pecas);
            Console.Write($"O faturamento da empresa é: {faturamento.ToString("C")}");

            Console.Write("\nInforme o valor de compra:");
            compra = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe as despesas fixas:");
            despesas_fix = Convert.ToDouble(Console.ReadLine());

            double total_company = (pecas * compra + despesas_fix);
            Console.WriteLine($"O custo total da empresa é: {total_company.ToString("C")}");

            double fim = (faturamento - total_company);
            Console.WriteLine($"O Lucro da empresa é: {fim.ToString("C")}");

            Console.ReadKey();

        }
    }
}
