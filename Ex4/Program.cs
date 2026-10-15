using Ex_2;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
     {

            song[] songs =
        {
            new song("Galway  Girl", "Ed Sheeran", 170),
            new song("Shape of You", "Ed Sheeran", 240),
            new song("Perfect", 70),
            new song("Bad", "The Shouter", 245, true)
        };
            foreach (song s in songs)
            { 
              Console.WriteLine(s.GetSummary());

                // Category boundary
                Console.WriteLine();
                int[] lenghts = { 119, 120, 300 ,101 };
                foreach (int seconds in lenghts)
                {
                    song test = new song("Test", seconds);
                    Console.WriteLine($"{seconds} seconds {test.GetLengthCategory()}");
                }
            }
    }


    }




    
}
