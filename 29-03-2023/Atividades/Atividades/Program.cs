using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Program
    {





        static void atividade01()
        {
            //Registro de respostas
            Console.WriteLine("É afrodescendente? (S/N)"); string afro = Console.ReadLine().ToLower();Console.WriteLine("Qual sua renda familiar?"); double renda = Convert.ToDouble(Console.ReadLine());Console.WriteLine("Estudou em Escola Publica?"); string escola = Console.ReadLine().ToLower();

            Console.Clear();
            if (afro == "s" || afro == "sim" || renda <=2424 || escola == "s" || escola == "sim") { Console.WriteLine("Você possui direito a pontuação extra"); } else { Console.WriteLine("Você não tem direito a pontuação extra"); }
        }

        static void atividade02()
        {
            string situacao = string.Empty;Console.WriteLine("Informe a média do aluno:");double media_aluno = Convert.ToDouble(Console.ReadLine());Console.WriteLine("Informe a % de presença do aluno:");int p_aluno = Convert.ToInt32(Console.ReadLine());if (media_aluno >= 7 && p_aluno >= 75) { situacao = "Aprovado"; }else if ((media_aluno <= 7 || media_aluno >= 4 && p_aluno >= 75) || (media_aluno >= 7 && p_aluno < 75)) { situacao = "Recuperação"; }else if ((media_aluno < 7 && media_aluno >= 4 && p_aluno < 75) || (media_aluno < 4)){ situacao = "Retido"; }Console.Clear();Console.WriteLine($"Media do aluno: {media_aluno}\nPorcentagem de presença: {p_aluno}\nSituação: {situacao}");
        }


        static void Main(string[] args)
        {
            atividade02();
            Console.ReadKey();

        }
    }
}
