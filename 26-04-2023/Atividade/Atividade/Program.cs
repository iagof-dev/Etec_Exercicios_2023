using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {

        static void Exercicio1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Aula de lógica de programação - " + i);
            }
        }

        static void Exercicio2()
        {
            int estudantes = 0;
            int integral = 0;
            double total_vendido = 0;
            double lote1_preco = 100, lote2_preco = 150, lote3_preco = 200;

            Console.WriteLine("====================================================\nDeseja começar a venda do lote 1? (S/N)");
            string lote1_resp = Console.ReadLine().ToLower();

            if (lote1_resp == "s")
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.Title = "Total vendidos: " + (estudantes + integral);
                    Console.WriteLine("Meia entrada? (S/N)");
                    string resp1 = Console.ReadLine().ToLower();

                    if (resp1 == "s")
                    {
                        estudantes++;
                        total_vendido += (lote1_preco / 2);
                    }
                    else
                    {
                        integral++;
                        total_vendido += (lote1_preco);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Total de Vendas: {total_vendido.ToString("C")}");
                Console.WriteLine($"Estudantes: {estudantes}");
                Console.WriteLine($"Integrais: {integral}");
            }

            Console.ReadKey();
            Console.WriteLine("====================================================\nDeseja começar a venda do lote 2? (S/N)");
            string lote2_resp = Console.ReadLine().ToLower();

            if (lote2_resp == "s")
            {
                for (int b = 11; b <= 20; b++)
                {
                    Console.Title = "Total vendidos: " + (estudantes+integral);
                    Console.WriteLine("Meia entrada? (S/N)");
                    string resp2 = Console.ReadLine().ToLower();

                    if (resp2 == "s")
                    {
                        estudantes++;
                        total_vendido += (lote2_preco / 2);
                    }
                    else
                    {
                        integral++;
                        total_vendido += (lote2_preco);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Total de Vendas: {total_vendido.ToString("C")}");
                Console.WriteLine($"Estudantes: {estudantes}");
                Console.WriteLine($"Integrais: {integral}");
            }

            Console.ReadKey();
            Console.WriteLine("====================================================\nDeseja começar a venda do lote 3? (S/N)");
            string lote3_resp = Console.ReadLine().ToLower();

            if (lote3_resp == "s")
            {

                for (int c = 21; c <= 30; c++)
                {
                    Console.Title = "Total vendidos: " + (estudantes + integral);
                    Console.WriteLine("Meia entrada? (S/N)");
                    string resp3 = Console.ReadLine().ToLower();

                    if (resp3 == "s")
                    {
                        estudantes++;
                        total_vendido += (lote3_preco / 2);
                    }
                    else
                    {
                        integral++;
                        total_vendido += (lote3_preco);
                    }
                }

            }

            Console.WriteLine($"Total de Vendas: {total_vendido.ToString("C")}");
            Console.WriteLine($"Estudantes: {estudantes}");
            Console.WriteLine($"Integrais: {integral}");


        }

        static void Main(string[] args)
        {
            Exercicio2();
            Console.ReadKey();
        }
    }
}
