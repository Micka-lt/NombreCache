using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration et initialisations
            string nom = "LETOURNEUR";
            string prenom = "Mickaël";
            int age = 25;

            // affichage personnalisé
            Console.Write("Bonjour " + prenom +" "+ nom + ", vous avez " + age + " ans.");
            Console.ReadLine();

        }
    }
}
