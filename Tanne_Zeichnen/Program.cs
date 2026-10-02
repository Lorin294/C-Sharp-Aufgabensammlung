namespace Tanne_Zeichnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            int heighttop =8;
            int heighttrunk = 8;
            int widthtrunk = 8;
            bool input = false;
            do
            {
                Console.Write("Breite des Stammes: ");
                if (int.TryParse(Console.ReadLine(), out widthtrunk) && widthtrunk > 0)
                {
                    input = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("Bitte positive Ganzzahl eingeben!");
                    Console.WriteLine("--------------------------------------------------------");
                }
            } while (!input);
            input = false;
            do
            {
                Console.Write("Höhe des Stammes: ");
                if (int.TryParse(Console.ReadLine(), out heighttrunk) && heighttrunk > 0)
                {
                    input = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("Bitte positive Ganzzahl eingeben!");
                    Console.WriteLine("--------------------------------------------------------");
                }
            } while (!input);
            input = false;
            do
            {
                Console.Write("Höhe der Krone: ");
                if (int.TryParse(Console.ReadLine(), out heighttop) && heighttop > 0)
                {
                    input = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("Bitte positive Ganzzahl eingeben!");
                    Console.WriteLine("--------------------------------------------------------");
                }
            } while (!input);

            ZeichneKrone(heighttop);
            ZeichneStamm(heighttop, widthtrunk, heighttrunk);
        }


        static void ZeichneStamm(int heighttop, int widthtrunk, int heighttrunk)
        {

            for (int i = 0; i < heighttrunk; i++)
            {
                int space = heighttop - 1 - widthtrunk / 2;
                int stars = widthtrunk;

                ZeichneZeileStamm(space, stars);
            }
        }

        static void ZeichneKrone(int height)
        {
            int space = height - 1;
            int stars = 1;

            for (int i = 0; i < height; i++)
            {
                ZeichneZeileKrone(space, stars);
                space -= 1;
                stars += 2;
            }
        }


        static void ZeichneZeileStamm(int numspace, int numstars)
        {
            for (int i = 0; i < numspace; i++)
                Console.Write("™️");

            for (int i = 0; i < numstars; i++)
                Console.Write("🪵");

            Console.WriteLine();
        }

        static void ZeichneZeileKrone(int numspace, int numstars)
        {
            for (int i = 0; i < numspace; i++)
                Console.Write("™️");

            for (int i = 0; i < numstars; i++)
                Console.Write("" +
                    "🟩");

            Console.WriteLine();
        }
    }
}
