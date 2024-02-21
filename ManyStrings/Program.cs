using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string exemplo_1 = "Isto representa uma das estrelas da constelação Vulpecula: \u2605 \n";
            //Console.WriteLine(exemplo_1);

            //string exemplo_2 = "Depois desta frase, vai ter uma nova linha.\nEu avisei!";
            //Console.WriteLine(exemplo_2);

            int x = 25;
            string juntar_1 = "Adicionar strings com inteiros, tipo esta frase + " + 2 + ",nunca ia dar certo em Python!";
            string juntar_2 = $"Imagina ter {x} gatos em casa... É o meu sonho!";
            Console.WriteLine(juntar_1);
            Console.WriteLine(juntar_2);

        }
    }
}
