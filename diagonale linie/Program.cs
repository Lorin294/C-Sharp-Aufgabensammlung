namespace diagonale_linie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxheight;
            bool sucsess = false;
            while (!sucsess)
            {
                Console.WriteLine("Wie lange sollte die diagonale Linie werden?");
                if (int.TryParse(Console.ReadLine(), out maxheight)&& maxheight>0)
                {
                    int currentheight = 0;
                    int before = 0;
                    int checkbefore = 0;
                    int checkafter = 0;
                    int after = maxheight - 1;
                    while (!(currentheight == maxheight))
                    {
                        checkbefore = 0;
                        while (checkbefore < before)
                        {
                            Console.Write("*");
                            checkbefore++;
                        }
                        before++;
                        Console.Write("  ");
                        checkafter = 0;
                        while (checkafter < after)
                        {
                            Console.Write("*");
                            checkafter++;
                        }
                        after--;
                        currentheight++;
                        Console.WriteLine();
                    }
                    sucsess = true;
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe.");
                    Console.WriteLine("Bitte Positive Ganzzahl eingeben!");
                    Console.WriteLine("--------------------------------------------------------");
                }
            }
        }
    }
}
