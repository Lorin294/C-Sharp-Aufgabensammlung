namespace Flussdiagramm_inplementieren__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double laps = 0;
            int lapsRunned = 1;
            Console.WriteLine("Wie viele Kilometer möchtest du Rennen?");
            double userkm = Convert.ToDouble(Console.ReadLine());
            if (userkm > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
            }
            else
            {
                laps = userkm * 1000 / 400;
                Convert.ToInt32(laps);
                Console.WriteLine(laps);

                Console.WriteLine("Bereit für den Lauf?(J/N)");
                string ready = Console.ReadLine();
                if (ready == "J" || ready == "j")
                {
                    while (laps >= lapsRunned)
                    {
                        Console.WriteLine("Du läufst Runde: " + lapsRunned);
                        lapsRunned++;
                    }
                    Console.WriteLine("Du hast es Geschafft!");
                }
                else if (ready == "N" || ready == "n")
                {

                }

            }
        }
    }
}
