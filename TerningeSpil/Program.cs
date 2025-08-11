namespace Terninge_Spil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of dice to roll: ");
            if (!int.TryParse(Console.ReadLine(), out int antalTerninger) || antalTerninger <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }

            Terning[] terninger = new Terning[antalTerninger];
            for (int i = 0; i < antalTerninger; i++)
            {
                terninger[i] = new Terning();
            }

            int antalKast = 0;
            bool alleSeksere = false;

            while (!alleSeksere)
            {
                antalKast++;
                alleSeksere = true;

                for (int i = 0; i < antalTerninger; i++)
                {
                    terninger[i].Kast();
                    if (terninger[i].Værdi != 6)
                    {
                        alleSeksere = false;
                    }
                }
            }

            Console.WriteLine($"It took {antalKast} roll(s) to get all sixes with {antalTerninger} dice.");
        }
    }
}
