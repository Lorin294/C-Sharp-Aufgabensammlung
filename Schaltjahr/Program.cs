namespace Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool quit = false;
            string inputyear = "";
            do
            {
                Console.Write("Eingabe Jahr (q to quit): ");
                inputyear = Console.ReadLine();

                if ( inputyear == "q")
                {
                    quit = true;
                }
                else if (int.TryParse(inputyear, out year))
                {
                    if (year % 4 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{year} ist ein Schaltjahr.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{year} ist kein Schaltjahr.");
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe.");
                    Console.WriteLine("Bitte gültige Jahreszahl eingeben!");
                    Console.WriteLine("--------------------------------------------------------");
                }
            } while (!quit);
        }
    }
}
