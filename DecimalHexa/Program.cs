using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere 4 número inteiros:");
            string user_1 = Console.ReadLine();
            string user_2 = Console.ReadLine();
            string user_3 = Console.ReadLine();
            string user_4 = Console.ReadLine();

            string hex_1 = $"{user_1:x}";
            Console.WriteLine(hex_1);


        }
    }
}
