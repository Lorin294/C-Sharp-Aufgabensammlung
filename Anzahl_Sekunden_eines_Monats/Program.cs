namespace Anzahl_Sekunden_eines_Monats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängikeit seiner Anzhal Tage");
            int numDays = 0;
            bool sucess=false;
            while (!sucess)
            {
                Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
                string inputDays = Console.ReadLine();
                if (int.TryParse(inputDays, out numDays) == true && numDays >= 28 && numDays <= 31)
                {
                    Console.WriteLine("Ein Monat mit " + inputDays + " Tagen hat: " + numDays * 24 * 60 * 60 + " Sekunden");
                    sucess = true;
                }
                else
                {
                    Console.WriteLine("Eingabe Fehlerhaft bitte. Bitte Zahl zwischen 28-31 Eingeben");
                }
            }
        }
    }
}
