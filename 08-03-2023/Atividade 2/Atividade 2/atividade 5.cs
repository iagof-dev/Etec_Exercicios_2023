using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class atividade_5
    {
        static void Main(string[] args)
        {
            double combustivel_value, km_percorrido_value, resultado;
            Console.Title = "Calculadora de valor gasto combustivel por km rodado";

            Console.WriteLine("Digite o valor do combustivel");
            combustivel_value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o KM percorrido");
            km_percorrido_value = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            resultado = (km_percorrido_value / combustivel_value);
            Console.WriteLine($"Ele faz  {resultado} km/l");

            Console.ReadKey();
        }
    }
}
