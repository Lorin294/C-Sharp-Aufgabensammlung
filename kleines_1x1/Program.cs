namespace kleines_1x1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int zeile = 1; zeile <= 10; zeile++)
            {
                for (int spalte = 1; spalte <= 10; spalte++)
                {
                    Console.Write(zeile * spalte + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}