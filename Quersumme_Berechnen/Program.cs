namespace Quersumme_Berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl Eingeben:");
            if (int.TryParse(Console.ReadLine(), out int numb))
            {
                int n = GetCheckSum(numb);
                Console.WriteLine("Die Quersumme von "+numb+" ist "+n);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte Ganzzahl eingeben.");
            }

        }

        static int GetCheckSum(int numb)
        {
            int sum = 0;
            while (numb != 0)
            {
                sum = sum + (numb % 10);
                numb = numb / 10;
            }
            return sum;
        }
    }
}
