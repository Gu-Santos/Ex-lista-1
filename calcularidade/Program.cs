using System;

namespace calcularidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de seu nascimento: ");
            int ano_nascimento =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            int ano_atual =int.Parse(Console.ReadLine());

                int idade = ano_atual - ano_nascimento;
            int semanas = idade * 12 * 4;
             
             Console.WriteLine("Sua idade é " + idade + " anos e " + semanas + " em semanas");
        }
    }
}
