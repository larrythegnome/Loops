using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            forEachLoop();
            Console.ReadLine();
        }

        static void ForLoop()
        {
            int numberOfTacos = 10;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < numberOfTacos; numberOfTacos--)
            {
                Console.WriteLine($"I eat a taco and now I have {numberOfTacos} Tacos!");
                System.Threading.Thread.Sleep(10);
                Console.WriteLine("NOM NOM NOM NOM NOM");
            }

            Console.WriteLine("Now I have no tacos :(");
        }

        static void forEachLoop()
        {
            string[] shrimp = { "Pineapple Shrimp", "Pizza Shrimp", "Ice Cream Shrimp", "Mint Shrimp", "Jelly Shrimp", "Frozen Shrimp", };

            foreach (var item in shrimp) 
            {
                Console.WriteLine($"I like {item}");
            }
        }
    }
}
