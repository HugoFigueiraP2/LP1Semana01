using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string exemplo_1 = "Isto representa uma das estrelas da constelação Vulpecula: \u2605 \n";
            Console.WriteLine(exemplo_1);

            string exemplo_2 = "Depois desta frase, vai ter uma nova linha.\nEu avisei!";
            Console.WriteLine(exemplo_2);

        }
    }
}
