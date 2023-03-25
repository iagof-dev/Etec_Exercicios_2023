using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Atividade_3
    {
        static void Main(string[] args)
        {
                double valorGasto;
                double distanciaPercorrida;
                double consumo;
                double resultado;

                Console.WriteLine("Digite o valor por litro do combustível:");
                valorGasto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a distância percorrida em km:");
                distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o consumo em litros por km:");
                consumo = Convert.ToDouble(Console.ReadLine());

                resultado = (distanciaPercorrida / consumo) * valorGasto;


                Console.WriteLine($"O veículo gasta em média R${resultado}.");
                Console.ReadKey();
        }
    }
}
