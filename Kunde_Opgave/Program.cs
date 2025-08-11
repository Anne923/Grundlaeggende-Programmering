namespace Kunde_Opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = GetPath("Data");
            string file = Path.Combine(path, "Names.txt");

            using (StreamReader sr = new StreamReader(file))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();

                }
            }

        }

        private static string GetPath(string dirName)
        {
            var currentdirectory = Directory.GetCurrentDirectory();
            string path = Path.Combine(currentdirectory, dirName);
            return path;
        }
    }
}
