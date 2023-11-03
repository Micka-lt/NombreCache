using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondes;
            string heure;

            do
            {
                Console.Write("Entrez le nombre de secondes (entre 0 et 86400) = ");
                secondes = int.Parse(Console.ReadLine());
            } while (secondes < 0 || secondes > 86400);

            int h = secondes / 3600;
            int m = (secondes - (h*3600)) / 60;
            int s = secondes - (h * 3600) - (m * 60);

            heure = "";
            if (h<10)
            {
                heure += "0";
            }
            heure += h + ":";
            if (m<10)
            {
                heure += "0";
            }
            heure += m + ":";
            if (s<10)
            {
                heure += "0";
            }
            heure += s;

            Console.WriteLine(heure);
            Console.ReadLine();
        }
    }
}
