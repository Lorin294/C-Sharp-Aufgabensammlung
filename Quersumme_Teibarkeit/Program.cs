namespace Quersumme_Teibarkeit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool input = false;
            int numb1, numb2 = 0;
            do
            {
                Console.Write("Zahl 1: ");
                if (int.TryParse(Console.ReadLine(), out numb1) && numb1>0)
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
            if (numb1 < numb2)
            {
                while (numb1 <= numb2)
                {
                    int results = GetCheckSum1(numb1, numb2);
                    if (numb1 % results == 0)
                    {
                        Console.WriteLine(numb1 + "\t" + results + "\t" + numb1 / results);
                    }
                    numb1++;
                }
            }
            else
            {
                while (numb2 <= numb1)
                {
                    int results = GetCheckSum2(numb1, numb2);
                    if (numb2 % results == 0)
                    {
                        Console.WriteLine(numb2 + "\t" + results + "\t" + numb2 / results);
                    }
                    numb2++;
                }
            }
        }
        static int GetCheckSum1(int numb1,int numb2)
        {
                int sum = 0;
            while (numb1 != 0)
            {

                sum = sum + (numb1 % 10);
                numb1 = numb1 / 10;
            }
            return sum;
        }

        static int GetCheckSum2(int numb1, int numb2)
        {
            int sum = 0;
            while (numb2 != 0)
            {

                sum = sum + (numb2 % 10);
                numb2 = numb2 / 10;
            }
            return sum;
        }
    }
}
