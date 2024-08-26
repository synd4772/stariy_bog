using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukku
{
    internal class Funktsioonid
    {
        public static void VanusKontroll(int vanus)
        {
            if (vanus <= 6 && vanus != 0)
            {
                Console.WriteLine("Tasuta");
            }
            else if (vanus <= 14)
            {
                Console.WriteLine("Lastepilet");
            }
            else if (vanus <= 100)
            {
                Console.WriteLine("Sooduspilet");
            }
            else
            {
                Console.WriteLine("Viga!");
            }
        }
    }
}
