namespace Quersumme_Teibarkeit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool input = false;
            int numb, numb2 = 0;
            do
            {
                Console.Write("Zahl 1: ");
                if (int.TryParse(Console.ReadLine(), out numb) && numb>0)
                {
                    input = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("Bitte positive Ganzzahl eingeben!");
                }
            } while (!input);
            input = false;
            do
            {
                Console.Write("Zahl 2: ");
                if (int.TryParse(Console.ReadLine(), out numb2) && numb2>0)
                {
                    input = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("Bitte positive Ganzzahl eingeben!");
                }
            } while (!input);
            if (numb < numb2)
            {
                while (numb <= numb2)
                {
                    int results = GetCheckSum(numb);
                    {
                        if (numb % results == 0)
                        {
                            Console.WriteLine(numb + "\t" + results + "\t" + numb / results);
                        }
                    }
                    numb++;
                }
            }
            else
            {
                int a = numb2;
                numb2 = numb;
                numb = a;
                while (numb <= numb2)
                {
                    int results = GetCheckSum(numb);
                    if (numb % results == 0)
                    {
                        Console.WriteLine(numb + "\t" + results + "\t" + numb / results);
                    }
                    numb++;
                }
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
