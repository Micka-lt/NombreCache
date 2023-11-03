using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le nom de la ville : ");
            string ville = Console.ReadLine();
            Console.Write("Entrez le nombre d'habitant : ");
            int habitants = int.Parse(Console.ReadLine());

            Console.WriteLine(ville + " possède " + habitants + " habitants.");
            Console.ReadLine();

        }

    }
}
