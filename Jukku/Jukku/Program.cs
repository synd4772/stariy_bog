namespace Jukku
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla!");
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }
            Console.Write(eesnimi + ", kui vana sa oled?");
            int vanus = int.Parse(Console.ReadLine());
            Funktsioonid.VanusKontroll(vanus);
        }
    }
}

