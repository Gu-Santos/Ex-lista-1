using System;

namespace exmesesdiashoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            Console.WriteLine("Sua idade em meses: " + meses);

            int dias = meses * 30;
            Console.WriteLine("Sua idade em dias: " + dias);

            int horas = dias * 24;
            Console.WriteLine("Sua idade em horas: " + horas);

            int minutos = horas * 60;
            Console.WriteLine("Sua idade em minutos: " + minutos);
        }
    }
}
