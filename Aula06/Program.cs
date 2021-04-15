using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento -  Aula06 , Calcule a area de trapezio, tipo double
            //Jonas valereo - Técnico em Informática

            //Declarando as variavies tipo, double

            double b, B, h, area;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a base menor: ");
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a base maior: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura: ");
            h = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a variavel area

            area = (b + B) / 2 * h;


            //imprimir saida de dados no console,método WhriteLine, concatenação


            Console.WriteLine("O Valor da area: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Parabéns, tente de novo!!!");


            // saida da aplicação console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
