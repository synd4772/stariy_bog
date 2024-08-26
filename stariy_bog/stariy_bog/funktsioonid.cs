using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stariy_bog
{
    class Funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere, " + nimi);
        }
        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        
        public  static void Arvuti(char tehe, int arv1, int arv2)
        {
            if (tehe == '+')
            {
                Console.WriteLine(arv1 + arv2);
            }
            else if (tehe == '-')
            {
                Console.WriteLine(arv1 - arv2);
            }
            else if (tehe == '*')
            {
                Console.WriteLine(arv1 * arv2);
            }
            else if (tehe == '/')
            {
                Console.WriteLine(arv1 / arv2);
            }
           
        }
        public static void Vanus
    }
}