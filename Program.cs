using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataValida
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            Console.Write("Digite o dia: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano: ");
            ano = Convert.ToInt32(Console.ReadLine());

            ObterDataValida(dia, mes, ano);

            Console.Read();

        }
        public static void ObterDataValida(int dia, int mes, int ano)
        {
            if ((dia < 1 || dia > 31) && (mes < 1 || mes > 12) && (ano < 1 || ano > 9999))
            {
                Console.Write("Data invalida");
            }
            else
            {
                Console.Write("Data valida");
            }
        }
    }
}
