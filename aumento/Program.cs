using System;

namespace aumento
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Insira o seu salário atual: ");
           double salario_atual = int.Parse(Console.ReadLine());
           if (salario_atual < 500)
           {
               double salario_reajustado = salario_atual + (salario_atual * 0.3);


                Console.WriteLine("Seu salário foi reajustado para " + salario_reajustado);
           }else
           {
               Console.WriteLine("Você não tem direito ao aumento!");
           }

        }
    }
}
