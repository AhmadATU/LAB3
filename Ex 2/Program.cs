namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            song song = new song();

            song.Title = "Shape of You";
            Console.WriteLine($"Artist stored as: {(song.Title)}");

            song.Artist = "       ";
            Console.WriteLine($"Artist stored as: {(song.Artist)}");

            song.Artist = "Low Tide";
            Console.WriteLine($"Artist stored as: {(song.Artist)}");

            song.DurationSeconds = 412;
            Console.WriteLine($"Duration: {song.GetFormattedSecounds()}");


            try
            {
                song.DurationSeconds = 0;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                song.DurationSeconds = 3601;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                song.Title = "   ";

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
