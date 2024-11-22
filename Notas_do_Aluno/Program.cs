using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_do_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Solicitar o número de faltas ou 'S' para sair
            Console.Write("Digite o número de faltas ou 'S' para sair: ");
            string inputFalta = Console.ReadLine();

            if (inputFalta.ToUpper() == "S")
            {
                Console.WriteLine("Programa encerrado.");
            }

            // Solicita a média para o úsuario
            Console.Write($"Digite sua média ou 'S' para sair: ");

           

            Console.ReadKey();
        }
    }
}
