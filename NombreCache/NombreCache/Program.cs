/**
 * Jeu du nombre caché
 * author : Mickaël
 * date : 13/10/2023
 */
using System;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            int valeur = 0, essai = 0, nbre = 1;
            bool correct = false;
            // saisie du nombre à chercher
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            Console.Clear();
            // saisie du premier essai
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            // boucle sur les essais
            while (essai != valeur)
            {
                // test de l'essai par raport à la valeur chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }
                else
                {
                    Console.WriteLine(" --> trop petit !");
                }
                // saisie d'un nouvel essai 
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Entrez un essai = ");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                    }
                }
                // compteur d'essais
                nbre++;
            }
            //valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();
        }
    }
}
