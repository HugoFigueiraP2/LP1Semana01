using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicione um número inteiro: ");
            string User_1 = Console.ReadLine();

            int numero_1 = int.Parse(User_1);

            Console.WriteLine("Adicione um número real: ");
            string User_2 = Console.ReadLine();

            float numero_2 = float.Parse(User_2);

            float soma = numero_1 + numero_2;
            Console.WriteLine($"Resultado da soma: {soma}");

        }
    }
}
