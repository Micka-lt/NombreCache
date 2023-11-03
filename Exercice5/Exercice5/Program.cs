using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Quel est votre âge ? ");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
                Console.WriteLine("Vous serez majeur dans " + (18 - age) + " an(s)");

            }
            Console.ReadLine();
        }
    }
}
