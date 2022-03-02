using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    internal class Aufgabe_10
    {
        public static void Start(string[] args)
        {
            int zahl;
            string eingabe;

            //Bittet um eine Zahl.
            Console.Write("Bitte geben sie eine Zahl ein:  ");
            eingabe = Console.ReadLine();

            zahl = Convert.ToInt32(eingabe);
            
            int eingegeben = zahl;
            int doppeltes = (zahl * 2);
            int halbes = (zahl /2);
            int restlich = (zahl % 7);

            Console.WriteLine("Das ist das Doppelte: {0}", doppeltes);
            Console.WriteLine(halbes);
            Console.WriteLine(restlich);
        }
    }
}
