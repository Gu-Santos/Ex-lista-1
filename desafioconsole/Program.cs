using System;

namespace desafioconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            switch (idade)
            {
                case 5:
                case 6:
                case 7:
                Console.WriteLine("Você é um nadador Infantil A");
                    break;

                case 8:
                case 9:
                case 10:

                Console.WriteLine("Você é um nadador Infantil B");
                    break;

                case 11:
                case 12:
                case 13:

                Console.WriteLine("Você é um nadador Juvenil A");
                    break;

                case 14:
                case 15:
                case 16:
                case 17:

                Console.WriteLine("Você é um nadador Juvenil B");
                    break;

                default:
                Console.WriteLine("Você é um nadador Sênior");
                    break;
            }

        }
    }
}
