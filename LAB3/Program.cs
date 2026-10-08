namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first  song, three objects
            song song1 = new song();
            song1.Title = "Galway Girl";
            song1.Artist = "Steve Earle";
            song1.Duration = 200;
            //Second song, three objects
            song song2 = new song();
            song2.Title = "Night DRIVE";
            song2.Artist = "Low Tide";
            song2.Duration = 150;
            //third song, three objects
            song song3 = new song();
            song3.Title = "Intro";
            song3.Artist = "The opener";
            song3.Duration = 250;


            Console.WriteLine($"{song1.Title} - {song1.Artist}({song1.GetFormattedDuration()})");
            Console.WriteLine($"{song2.Title} - {song2.Artist}({song2.GetFormattedDuration()})");
            Console.WriteLine($"{song3.Title} - {song3.Artist}({song3.GetFormattedDuration()})");
        }
    }
}
