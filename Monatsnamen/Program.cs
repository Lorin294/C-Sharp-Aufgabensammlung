namespace Monatsnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl des Monats eingeben:");
            bool sucess = false;
            while (!sucess)
            {
                string inputMnth = Console.ReadLine();
                int numMnth = 0;
                if (int.TryParse(inputMnth, out numMnth) == true && numMnth > 0 && numMnth <= 12)
                {
                    switch (numMnth)
                    {
                        case 1:
                            Console.WriteLine("Monat: Januar");
                            break;
                        case 2:
                            Console.WriteLine("Monat: Februar");
                            break;
                        case 3:
                            Console.WriteLine("Monat: März");
                            break;
                        case 4:
                            Console.WriteLine("Monat: April");
                            break;
                        case 5:
                            Console.WriteLine("Monat: Mai");
                            break;
                        case 6:
                            Console.WriteLine("Monat: Juni");
                            break;
                        case 7:
                            Console.WriteLine("Monat: Juli");
                            break;
                        case 8:
                            Console.WriteLine("Monat: August");
                            break;
                        case 9:
                            Console.WriteLine("Monat: September");
                            break;
                        case 10:
                            Console.WriteLine("Monat: Oktober");
                            break;
                        case 11:
                            Console.WriteLine("Monat: November");
                            break;
                        case 12:
                            Console.WriteLine("Monat: Dezember");
                            break;
                    }
                    sucess = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Zahl zwischen 1-12 Eingeben.");
                }
            }
        }
    }
}
