using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Do_Dia
{
    internal class Program
    {

        static void exercicio_1()
        {
            int teste;

            Console.WriteLine("Digite 1 ou 2");
            teste = Convert.ToInt32(Console.ReadLine());

            switch (teste)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

        }

        static void exercicio_2()
        {

            double calculo = 0;
            string forma, escolha;

            Console.WriteLine("Escolha UMA Forma Geométrica:\n-Quadrado\n-Retângulo\n-Trapézio\n-Losango");
            Console.Write(">");
            forma = Console.ReadLine().ToLower();
            Console.Clear();

            switch (forma)
            {
                case "quadrado":
                    Console.WriteLine("digite o lado do quadrado");
                    double lados = Convert.ToDouble(Console.ReadLine());
                    calculo = (lados * 4);
                    break;

                case "retangulo":
                    Console.WriteLine("digite o altura do retangulo");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o largura do retangulo");
                    double larg = Convert.ToDouble(Console.ReadLine());
                    calculo = (altura * larg);
                    break;

                case "trapezio":
                    Console.WriteLine("digite o valor de B do trapezio");
                    double bm = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o valor de Base menor do trapezio");
                    double bmn = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o valor de H do trapezio");
                    double h = Convert.ToDouble(Console.ReadLine());
                    calculo = ((bm+bmn)*h)/2;
                    break;

                case "losango":
                    Console.WriteLine("digite o valor de D do losango");
                    double d = Convert.ToDouble(Console.ReadLine());
                    calculo = (d*d)/2;
                    break;
                default:
                    calculo = 0;
                    break;
            }

            if (calculo != 0){Console.WriteLine("Resultado é: " + calculo.ToString("F3"));}else{Console.WriteLine("Figura Inválida!");}
        }

        static void exercicio_3()
        {
            int operacao;
            double saldo;

            Console.WriteLine("Informe seu saldo:");
            Console.Write(">");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Saldo atual: {saldo}\nEscolha uma opção\n[1] Verificar Saldo\n[2] Sacar\n[3] Depósito\n[0] Sair");
                Console.Write(">");
                operacao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(operacao)
                {
                    case 1:
                        Console.WriteLine($"Seu saldo é: {saldo.ToString("C")}");
                        break;
                    case 2:
                        Console.WriteLine("Quanto deseja sacar?");
                        double sacar = Convert.ToDouble(Console.ReadLine());

                        if (sacar <= saldo) { saldo -= sacar; Console.WriteLine($"Sucesso! Você retirou {sacar.ToString("C")}"); }
                        else
                        {
                            Console.WriteLine("Você não possui saldo suficiente para sacar!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Quanto deseja depositar?");
                        double depositar = Convert.ToDouble(Console.ReadLine());
                        saldo += depositar;
                        Console.WriteLine($"Você depositou {depositar.ToString("C")} Com Sucesso!");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;

                }
                Console.ReadKey();
            }


        }

        static void Main(string[] args)
        {
            exercicio_3();

            Console.ReadKey();
        }
    }
}
