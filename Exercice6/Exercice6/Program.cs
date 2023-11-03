using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration
            float moyenne;

            // Saisie de la moyenne
            Console.Write("Entrez la moyenne = ");
            moyenne = float.Parse(Console.ReadLine());

            // Test sur la moyenne
            if (moyenne >= 16)
            { 
                Console.WriteLine("Très bien");
            }
            else
            {
                if (moyenne >= 14)
                { 
                    Console.WriteLine("Bien");
                }
                else
                {
                    if (moyenne >= 12)
                    {
                        Console.WriteLine("Assez bien");
                    }
                    else
                    {
                        Console.WriteLine("Passable");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
