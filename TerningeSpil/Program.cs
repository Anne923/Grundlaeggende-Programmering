namespace Terninge_Spil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose program:");
            Console.WriteLine("1 - Dice Game");
            Console.WriteLine("2 - Mozart Waltz Generator");
            string choice = Console.ReadLine();

            if (choice == "1")
                RunDiceGame();
            else if (choice == "2")
                RunMozartWaltz();
            else
                Console.WriteLine("Invalid choice.");
        }

        static void RunDiceGame()
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

        static void RunMozartWaltz()
        {
            Random rng = new Random();

            Console.WriteLine("Choose instrument: piano, mbira, clarinet, flute-harp");
            string instrument = Console.ReadLine()?.Trim().ToLower();

            string basePath = GetPath("mozart");
            string instrumentPath = Path.Combine(basePath, instrument);

            if (!Directory.Exists(instrumentPath))
            {
                Console.WriteLine("Instrument folder not found.");
                return;
            }

            Console.WriteLine("Playing Menuet...");
            for (int i = 0; i < 16; i++)
            {
                int diceSum = RollDice(rng, 2);
                string fileName = $"minuet{i}-{diceSum}.wav";
                PlayWav(Path.Combine(instrumentPath, fileName));
            }

            Console.WriteLine("Playing Trio...");
            for (int i = 0; i < 16; i++)
            {
                int diceSum = RollDice(rng, 1);
                string fileName = $"trio{i}-{diceSum}.wav";
                PlayWav(Path.Combine(instrumentPath, fileName));
            }

            Console.WriteLine("Finished playing the waltz!");
        }

        static int RollDice(Random rng, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += rng.Next(1, 7);
            }
            return sum;
        }

        static void PlayWav(string filePath)
        {
            if (File.Exists(filePath))
            {
                using( System.Media.SoundPlayer player = new System.Media.SoundPlayer(filePath))
                {
                    player.PlaySync();
                }
;
            }
            else
            {
                Console.WriteLine($"Missing file: {filePath}");
            }
        }


        static string GetPath(string dirName)
        {
            string currentDir = Directory.GetCurrentDirectory();
            return Path.Combine(currentDir, dirName);
        }


    }
}
