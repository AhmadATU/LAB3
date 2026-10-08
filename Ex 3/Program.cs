using Ex_2;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           song song1 = new song("Galway  Girl", "Ed Sheeran", 170, false);
           song song2 = new song("Shape of You", "Ed Sheeran", 240, false);
           song song3 = new song("Perfect", 70);

            Console.WriteLine($"{song1.Title} - {song1.Artist}({song1.GetFormattedDuration()})");
            Console.WriteLine($"{song2.Title} - {song2.Artist}({song2.GetFormattedDuration()})");
            Console.WriteLine($"{song3.Title} - {song3.Artist}({song3.GetFormattedDuration()})");


            try
            {
                song bad = new song("Bad", 0);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
