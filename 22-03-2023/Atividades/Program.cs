using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Program
    {

        void atividade1()
        {
            double salario;
            double inss, pensao;

            Console.Write("Informe o salário de funcionário:");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o % de INSS:");
            inss = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o % de pensão:");
            pensao = Convert.ToDouble(Console.ReadLine());

            salario -= salario * (inss / 100);

            salario -= salario * (pensao / 100);



            Console.WriteLine($"Salário final: {salario.ToString("C")}");

            Console.ReadKey();
        }

        void atividade2()
        {
            int n1, n2;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine($"O primeiro número é o maior: {n1}");
            if (n1 < n2)
                Console.WriteLine($"O segundo número é o maior: {n2}");
            if (n1 == n2)
                Console.WriteLine($"Ambos os número são iguais: {n1} e {n2}");
        }

        static void atividade3()
        {
            double qtd_comprada, valor_unit, desc, total;
            Console.Write("Informe a quantidade comprada: ");
            qtd_comprada = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor unitário: ");
            valor_unit = Convert.ToDouble(Console.ReadLine());

            total = (qtd_comprada * valor_unit);

            if (qtd_comprada > 100)
            {
                Console.Write("Informe o % de desconto: ");
                desc = Convert.ToDouble(Console.ReadLine());
                total -= (desc / 100) * total;
            }

            Console.WriteLine($"O valor total da compra é: {total.ToString("C")}");
        }

        static void atividade4()
        {
            string sexo;
            Console.Write("Informe o sexo do usúario: ");
            sexo = Console.ReadLine().ToUpper();

            while (sexo != "M" && sexo == "F")
            {
                Console.Write("Informe o sexo do usúario: ");
                sexo = Console.ReadLine().ToUpper();
            }

            switch (sexo)
            {
                case "M": Console.WriteLine("O usuário é do sexo Masculino"); break;

                case "F": Console.WriteLine("O usuário é do sexo Feminino"); break;

                default:
                    Console.Write("Informe o sexo do usúario");
                    sexo = Console.ReadLine().ToUpper();
                    break;
            }
            Console.ReadKey();
        }

        static void atividade5()
        {
            double n1, n2, resultado = 0;
            string operacao = string.Empty;

            Console.WriteLine("Digite o primeiro numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a operação que desejas (+|-|*|/): ");
            operacao = Console.ReadLine();
            while (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
            {
                Console.WriteLine("Digite a operação que desejas (+|-|*|/): ");
                operacao = Console.ReadLine();
            }




            Console.WriteLine("Digite o segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());



            switch (operacao)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    resultado = n1 / n2;
                    break;
            }

            Console.WriteLine($"Resultado {resultado}");

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            atividade5();
        }
    }
}
