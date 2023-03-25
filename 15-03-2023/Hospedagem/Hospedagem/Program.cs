using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor_diaria;
            int qnt_adultos, qnt_crianca, dias_hospedagem, parcelas;


            Console.Write("Informe o valor da diária do hotel:");
            valor_diaria = Convert.ToDouble(Console.ReadLine());


            Console.Write("Informe a quantidade de adultos:");
            qnt_adultos = Convert.ToInt32(Console.ReadLine());


            Console.Write("Informe o valor da diária do hotel:");
            qnt_crianca = Convert.ToInt32(Console.ReadLine());

            double familia_crianca = ((valor_diaria / 2) * qnt_crianca);
            double familia_adulto = (valor_diaria * qnt_adultos);

            double familia_total = (familia_adulto + familia_crianca);


            Console.WriteLine($"O Valor por dia da familia será: {familia_total}");


            Console.Write("Informe o número de dias de hospedagem:");
            dias_hospedagem = Convert.ToInt32(Console.ReadLine());

            double resultado_dias = (dias_hospedagem * familia_total);

            Console.WriteLine($"O valor total da hospedagem é: {resultado_dias}");

            Console.Write("Informe o número de parcelas:");
            parcelas = Convert.ToInt32(Console.ReadLine());

            double resultado_parcelas = (resultado_dias / parcelas);

            Console.WriteLine($"O valor de cada parcela é: {resultado_parcelas}");


            Console.ReadKey();

        }
    }
}
