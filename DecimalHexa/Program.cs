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

            int dec_1 = int.Parse(user_1);
            int dec_2 = int.Parse(user_2);
            int dec_3 = int.Parse(user_3);
            int dec_4 = int.Parse(user_4);


            string hex_1 = $"{dec_1:x}";
            string hex_2 = $"{dec_2:x}";
            string hex_3 = $"{dec_3:x}";
            string hex_4 = $"{dec_4:x}";
            Console.WriteLine($"{user_1,6}  {hex_1,6}");
            Console.WriteLine($"{user_2,6}  {hex_2,6}");
            Console.WriteLine($"{user_3,6}  {hex_3,6}");
            Console.WriteLine($"{user_4,6}  {hex_4,6}");


        }
    }
}
