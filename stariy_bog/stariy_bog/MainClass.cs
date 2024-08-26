using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stariy_bog
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            System.Console.WriteLine("stariy_bog");
            string nickname = "stariy_bog";
            Console.WriteLine("hello, {0}", nickname);
            Funktsioonid.Tere("litvin");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int vastus = Funktsioonid.Liitmine(a, b);
            Console.WriteLine(vastus);
            double arv = 5.122;
            vastus = Funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine(vastus);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);

            } else
            {
                Console.WriteLine(vastus);
            }
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            char tehe = char.Parse(Console.ReadLine());
            Funktsioonid.Arvuti(tehe, a, b);
        }

    }
}
