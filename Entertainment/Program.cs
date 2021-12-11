using System;
using System.Media;

namespace Entertainment
{
    class Program
    {

       
        static void Main(string[] args)
        {

          


            Menu m = new Menu();
            
            Console.WriteLine("+++++++Welcome to Entertainment Catalog System+++++++++");
            Console.WriteLine("\n");
            Console.WriteLine("Choose One of the options");
            Console.WriteLine("\n");
            Console.WriteLine("1.Movies");
            Console.WriteLine("2.Tvseries");
            Console.WriteLine("3.UpcomingMoviesAndTvShows");

            m.Choices();



        }
    }
}
