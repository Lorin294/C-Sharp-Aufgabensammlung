using System.Text.Json;

namespace Aufsummieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] basi;
            bool valid = false;
            do
            {
                string eingabe = Console.ReadLine();
                string[] eingabeArray = eingabe.Split(',');
                basi = new int[eingabeArray.Length];
                valid = false;
                for (int i = 0; i < eingabeArray.Length; i++)
                {
                    if (!(int.TryParse(eingabeArray[i], out basi[i])))
                    {
                        Console.WriteLine("Fehlerhafte Eingabe.");
                        Console.WriteLine("Ganzzahl benötigt.");
                        valid = true;
                    }
                }
            } while (valid);
            Printarray(SumUp(basi));

        }
        static int[] SumUp(int[] arr)
        {
            int sum = 0;
            int[] result = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
               sum += arr[i];
               result[i] = sum;
            }

            return result;
        }
        static void Printarray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1)
                {
                    Console.Write($"[{i}] -> {arr[i]}");
                }
                else
                {
                    Console.Write($"[{i}] -> {arr[i]}, ");
                }
            }
        }
    }
}
