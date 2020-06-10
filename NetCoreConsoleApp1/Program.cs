using System;

namespace MyFirstNetCoreApp
{
    // Input class
    public static class Variable
    {
        public static byte smallNumber = 1;
        public static int count = 10;
        public static float total = 20.95f;
        public static char character = 'A';
        public static string name = "MittNamn";
        public static string bigNumber = "1234";
        public static bool isWorking = true;
    }
    // Output class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Variabler som används är: " +
                $"Siffra: {Variable.smallNumber}, Heltal: {Variable.count}, Decimal: {Variable.total}, " +
                $"Tecken: {Variable.character}, Text: {Variable.name}, Bool: {Variable.isWorking}");

            Console.WriteLine($"Bara en uppdelning (/) mellan {Variable.count} och {Variable.total} med resultat av: {(float)Variable.count / Variable.total}");
            Console.WriteLine("En byte kan ha Min välor {0} och Max välor {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine($"Bara logik. Är {Variable.smallNumber} inte mindre än {Variable.count} ? Min räknemaskin säger: {Variable.smallNumber! < Variable.count} :)");

            Console.WriteLine("Nedan är ett avsedd konverteringsundantag: ");
            IntendeException();
        }

        // Avsedd undantag
        private static void IntendeException()
        {
            try
            {
                bool conversion = Convert.ToBoolean(Variable.bigNumber);
                Console.WriteLine($"Omvandling från Text till heltal: {conversion}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ursäkta ! Numret kunde inte konverteras!"); ;
            }
        }
    }
}
