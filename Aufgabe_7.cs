using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    internal class Aufgabe_7
    {
        public static void Start()
        {
            string str1 = "wie";
            string str2 = "dir?";
            string str3 = "es";
            string str4 = "Danke,";
            string str5 = "Hallo,";
            string str6 = "geht";
            string str7 = "gut?";
            string str8 = "mir";
            
            string s1 = string.Format("{4} {0} {5} {2} {1}" , str1, str2, str3, str4, str5, str6, str7, str8);
            string s2 = string.Format("{3} {7} {5} {2} {6}" , str1, str2, str3, str4, str5, str6, str7, str8);





            Console.WriteLine(s1);
            Console.WriteLine(s2);
            
            
            

        }
    }
}
