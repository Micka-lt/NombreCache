using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice9
{
    class Program
    {
        static void Main(string[] args)
        {
            int note;

            do
            {
                Console.Write("Saisie note entre 0 et 20 = ");
                note = int.Parse(Console.ReadLine());
            } while (!(note > 0 && note < 20));

            Console.WriteLine("note saisie : " + note);
            Console.ReadLine();
        }
    }
}
