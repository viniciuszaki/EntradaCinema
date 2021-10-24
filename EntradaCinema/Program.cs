using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo = "";
            int idade;

            Console.WriteLine("Você é mulher ou homem? ");
            sexo = Console.ReadLine();
            Console.WriteLine("Quantos anos você tem? ");
            idade = int.Parse(Console.ReadLine());

            if (sexo == "mulher" && idade >= 25)
            {
                Console.WriteLine("entrada é gratuita");
            }
            else
            {
                Console.WriteLine("vai ter que pagar meu filho...");
            }

            Console.ReadLine();
        }
    }
}
