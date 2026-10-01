namespace Ganzzahl_zu_Binär
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin = "";
            int n;
            int wert;
            int rest;
            if (int.TryParse(Console.ReadLine(), out n))
            {              do
                {
                    rest = n % 2 ;
                    bin = Convert.ToString(rest) + bin;
                    wert = n / 2;
                    n = wert;
                } while (!(n == 0));
                Console.WriteLine(bin);
            }
            else
            {
              
            }
        }
    }
}
