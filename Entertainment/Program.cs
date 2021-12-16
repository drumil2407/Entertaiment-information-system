using System;
using System.Media;

namespace Entertainment
{
    class Program
    {

       
        static void Main(string[] args)
        {

            //menu class object

            Menu m = new Menu();
           
            while (true)
            {
                
                Console.WriteLine("+++++++Welcome to Entertainment Catalog System+++++++++");
                Console.WriteLine("\n");
                Console.WriteLine("Choose One of the options");
                Console.WriteLine("\n");
                Console.WriteLine("1.Movies");
                Console.WriteLine("2.Tvseries");
                Console.WriteLine("3.UpcomingMoviesAndTvShows");
                Console.WriteLine("4.Add a movies");
                Console.WriteLine("5.The movies which you enter");
                Console.WriteLine("6.Clear screen");
                
                //call menu class method

                m.Choices();

                Console.Clear();
            }

        }
    }
}
