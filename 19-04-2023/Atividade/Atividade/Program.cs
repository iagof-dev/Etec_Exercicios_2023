using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {

        static void atividade1()
        {
            string resp = "S";
            double valor, total = 0;

            while (resp == "S")
            {
                Console.WriteLine("Informe o valor do produto");
                valor = double.Parse(Console.ReadLine());

                total += valor;

                Console.WriteLine("Deseja inserir um novo produto?");
                resp = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("O Valor final da venda é: " + total.ToString("C"));
            Console.ReadKey();

        }

        static void atividade2()
        {
            int operacao; double saldo; bool ativo = true;

            Console.WriteLine("Informe seu saldo:"); Console.Write(">");
            saldo = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            while (ativo == true)
            {
                Console.Clear();
                Console.WriteLine($"Saldo atual: {saldo}\nEscolha uma opção\n[1] Verificar Saldo\n[2] Sacar\n[3] Depósito\n[0] Sair");
                Console.Write(">");
                operacao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (operacao)
                {
                    case 1:
                        Console.WriteLine($"Seu saldo é: {saldo.ToString("C")}");
                        break;

                    case 2:
                        Console.WriteLine("Quanto deseja sacar?");
                        double sacar = Convert.ToDouble(Console.ReadLine());

                        if (sacar <= saldo) { saldo -= sacar; Console.WriteLine($"Sucesso! Você retirou {sacar.ToString("C")}"); }
                        else { Console.WriteLine("Você não possui saldo suficiente para sacar!"); }

                        Console.WriteLine("Deseja fazer outra operação? (S/N)");
                        Console.Write(">");
                        string resp = Console.ReadLine().ToUpper();
                        if (resp != "S") { ativo = false; }
                        break;

                    case 3:
                        Console.WriteLine("Digite a quantia que deseja depositar: ");
                        Console.Write(">");
                        double depositar = Convert.ToDouble(Console.ReadLine());
                        saldo += depositar;
                        Console.WriteLine($"Você depositou {depositar.ToString("C")} Com Sucesso!");
                        Console.WriteLine("Deseja fazer outra operação? (S/N)");
                        string resp2 = Console.ReadLine().ToUpper();
                        if (resp2 != "S") { ativo = false; }
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

        static void atividade3()
        {
            //                             adm | ds | nutrição
            int[] matriculados = new int[] { 35, 35, 35 };
            //                    adm | ds | nutrição
            int[] vagas = new int[] { 5, 5, 5 };
            while (true)
            {


                Console.WriteLine($"Qual curso deseja matricular?\n[D]esenvolvimento de Sistemas (Vagas: {vagas[1]})\n[A]dminstração (Vagas: {vagas[0]})\n[N]utricao (Vagas: {vagas[2]})");
                Console.Write(">");
                string opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "A":


                        if (vagas[0] > 0){
                            Console.WriteLine("Digite o nome do aluno");
                            Console.ReadLine();
                            matriculados[0]++;
                            vagas[0]--;
                        }else{Console.WriteLine("Sem vagas para este curso");Console.ReadKey();}


                        break;
                    case "D":

                        if (vagas[1] > 0){
                            Console.WriteLine("Digite o nome do aluno");
                            Console.ReadLine();

                            matriculados[1]++;
                            vagas[1]--;
                        }else{Console.WriteLine("Sem vagas para este curso");Console.ReadKey();}
                        
                        break;
                    case "N":

                        if (vagas[2] > 0)
                        {
                            Console.WriteLine("Digite o nome do aluno");
                            Console.ReadLine();

                            matriculados[2]++;
                            vagas[2]--;
                        }else{Console.WriteLine("Sem vagas para este curso");Console.ReadKey(); }

                        break;
                    default:
                        Console.WriteLine("Opção/Curso inválido");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                Console.WriteLine($"Matriculados: DS={matriculados[1]} | ADM={matriculados[0]} | Nutricao:{matriculados[2]}");
                Console.WriteLine($"Vagas: D.S={vagas[1]} | ADM={vagas[0]} | Nutricao:{vagas[2]}");
                Console.ReadKey();
            }
        }

        static void atividade4()
        {

            double saldo=0,qnt=0,valor;
            int operacao = -1;
            do
            {
                Console.WriteLine("Digite a quantidade");
                Console.Write(">");
                qnt = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor unitario");
                Console.Write(">");
                valor = Convert.ToDouble(Console.ReadLine());

            }
            while (operacao != -1);
            {
                Console.WriteLine("Digite a operação:\n[1] Venda\n[2] Devolução\n[0] Sair");
                Console.Write(">");
                operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        saldo += (valor * qnt);
                        break;
                    case 2:
                        saldo -= (valor * qnt);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }

            }
        }
        static void Main(string[] args)
        {
            atividade4();

            Console.WriteLine("\nPrograma finalizado!");
            Console.ReadKey();
        }
    }
}
