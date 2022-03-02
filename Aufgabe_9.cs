using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    internal class Aufgabe_9
    {
        public static void Start()
        {
            //Bittet um die Eingabe eines Wortes.
            Console.WriteLine("Bitte geben Sie einen String ein: ");
            string tmp = Console.ReadLine();

            //Gibt die Anzahl der Zeichen zurück
            int get = tmp.Length;
            string str2 = "Länge:  " ;

            //Gibt den ersten Buchstaben aus 
            string str3 = tmp.Substring(0, 1);
            string str4 = "Erster Buchstabe:  ";

            //Gibt den letzten Buchstaben aus
            string str5 = tmp.Substring(tmp.Length -1);
            string str6 = "Letzter Buchstabe:  ";


                      
            Console.WriteLine(str2 + get);
            Console.WriteLine(str4 + str3);
            Console.WriteLine(str6 + str5);    

        }
    }
}
