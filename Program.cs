using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nome2;
            int valor;

            Console.WriteLine("Bem vindo, a loja de cafee");
            Console.WriteLine("Seu qual nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Qualquer escolher coisa?: ");
            nome2 = Console.ReadLine();

            Console.WriteLine("Tem que valor: $15,00" );
            valor = Int32.Parse(Console.ReadLine());

            if (valor == 15) ;
            {
                Console.WriteLine("valor inválido");
                Console.WriteLine("Não dar comprar, qualquer cartão ou nubank?");
                return;
            }
            
            Console.WriteLine("Deu comprar, pode vai sentar, mas pouco esperar");
            Console.WriteLine($"Obriado, {nome} ");
            Console.ReadKey();

        }
    }
}
