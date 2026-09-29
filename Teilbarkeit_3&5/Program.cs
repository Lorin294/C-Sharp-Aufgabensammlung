using System.ComponentModel.Design;

namespace Teilbarkeit_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(double Numb=1; Numb<=30; Numb++)
            {
                if (Numb % 3 == 0 || Numb % 5 == 0) 
                {
                    Console.Write(Numb);
                    if (Numb < 30)
                    {
                        Console.Write(", ");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
