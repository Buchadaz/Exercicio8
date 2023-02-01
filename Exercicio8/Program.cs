using Exercicio8;
using System;
using System.Globalization;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidato aluno = new Candidato();
            Console.WriteLine("Digite as informações do aluno: ");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.x2= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Nota final do aluno é: "+ aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            if (aluno.Aprovado())
            {
                Console.WriteLine("Aluno Aprovado! Que cara bom :)");
            }
            else
            {
                Console.WriteLine("Aluno reprovado :((");
                Console.WriteLine("Faltaram: " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)+" pontos");
            }
        }
    }
}