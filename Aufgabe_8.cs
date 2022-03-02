using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    internal class Aufgabe_8
    {
        public static void Start()
        {
           
            string inputString = "werPolizeidjsue";

            //Gibt die Anzahl der Zeichen zurück
            int Anzahl   = inputString.Length;
            string str1 = "Anzahl:";

            //Gibt einen gewissen Abschnitt des Strings zurück
            //Zuerst der Startindex, dann die Anzahl der Zeichen
            string str2 = inputString.Substring(3, 7);

            //Gibt den Text in Großbuchstaben aus
            string str3 = str2.ToUpper();

            Console.WriteLine(inputString);
            Console.WriteLine(str1 + Anzahl);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            
           


        }
    }
}
