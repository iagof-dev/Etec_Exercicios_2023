using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Program
    {

        static void atividade_01()
        {
            int cont = 1;

            while(cont <= 10)
            {
                Console.WriteLine(cont);
                cont++;
            }
        }

        static void atividade_02()
        {
            int cont = 1;

            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont++;
            }
        }

        static void atividade_03()
        {
            int cont = 100;

            while (cont >= 1)
            {
                Console.WriteLine(cont);
                cont--;
            }
        }
        
        static void atividade_04()
        {
            int cont = 1;
            while (cont <= 100)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);

                }
                cont++;

            }
        }

        static void atividade_05()
        {
            Console.Write("Informe qual número você quer os multiplos: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int cont = 0;
            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont+= number;
            }

        }

        static void atividade_06()
        {
            Console.Write("Escolha PAR ou IMPAR: ");
            string resp = Console.ReadLine().ToLower();

            int cont = 1; 

            while (cont <= 20)
            {
                if (resp == "par"){
                    if (cont % 2 == 0){
                        Console.WriteLine(cont);
                    }
                }
                if (resp == "impar"){
                    if (cont % 2 != 0){
                        Console.WriteLine(cont);
                    }
                }
                cont++;
            }

        }

        static void atividade_07()
        {
            Console.Write("Digite a tabuada: ");
            int tab = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o numero de vezes: ");
            int vezes = Convert.ToInt32(Console.ReadLine());

            int cont = 1;
            while (cont <= vezes){
                Console.WriteLine($"{tab}x{vezes}={(tab * cont)}");
                cont++;
            }
        }

        static void Main(string[] args)
        {
            atividade_07();
            Console.ReadKey();
        }
    }
}
