namespace Addierer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erste Zahl?");
            int firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zweite Zahl?");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("Das Ergebnis von " + firstNumber + " + " + secondNumber + " ist: "+result );
        }
    }
}
