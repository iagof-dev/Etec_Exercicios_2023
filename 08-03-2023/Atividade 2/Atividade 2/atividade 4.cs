using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2
{
    internal class atividade_4
    {
        
        static void Main(string[] args)
        {
            Double idade, bpm, bpm_hora, bpm_mes, bpm_dia, bpm_ano, bpm_total;


            Console.WriteLine("Informe sua idade em anos");
            idade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o seu BPM (Batidas do coração Por Minuto");
            bpm = Convert.ToDouble(Console.ReadLine());

            bpm_hora = (bpm * 60);
            bpm_dia = (bpm * 60) * 24;
            bpm_mes = (((bpm * 60) * 24) * 30);
            bpm_ano = ((((bpm * 60) * 24) * 30) * 12);
            bpm_total = ((((bpm * 60) * 24) * 30) * 12) * idade;


            Console.WriteLine($"Batidas Por Hora: {bpm_hora}");

            
            Console.WriteLine($"Batidas Por Dia: {bpm_dia}");

            Console.WriteLine($"Batidas Por Mês: {bpm_mes}");
            

            Console.WriteLine($"Batidas Por Ano: {bpm_ano}");

            Console.WriteLine($"Total de Batidas na sua vida inteira: {bpm_total}");



            Console.ReadKey();
        }

    }
}
