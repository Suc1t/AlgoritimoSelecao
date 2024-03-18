using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Construa um algoritimo que receba o preço de um produto.
             se o preço for maior que R$100 aplicar desconto de 5%.
            */

            double valor;
            double desconto;
            double taxa = 5;

            Console.Write("Insira o valor do produto: ");
            valor = double.Parse(Console.ReadLine());

            desconto = (valor * taxa) / 100;

            if (valor > 100)
            {
                Console.WriteLine($"Você recebeu {desconto}% de desconto. ");
                Console.WriteLine($"Valor final do seu produto: R${valor - desconto}");
            }
            else
            {
                Console.WriteLine("Você não possui desconto.");
                Console.WriteLine($"O valor do seu produto é de: R${valor}.");
            }
            Console.ReadKey();
        }
    }
}
