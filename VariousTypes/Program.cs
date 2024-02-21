using System;

namespace VariousTypes
{
    class Program 
    {
        static void Main(string[] args)
        {

            byte numero = 23;
            ushort numero_2 = 500;
            uint numero_3 = 23506;
            short numero_4 = -2;
            Console.WriteLine($"{numero} {numero_2} {numero_3} {numero_4}"); 

            char sinal_certo = '\u2713';
            char estrela = '\u2605';
            char euro = '\u20AC';

            Console.WriteLine($"{sinal_certo} {estrela} {euro}");

            float health = 100f;

            double distance = 54.6;

            decimal damage = 5.234m;

            Console.WriteLine($"{health} {distance} {damage}");
        }
    }
}
