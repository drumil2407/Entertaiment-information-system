using System;

namespace Entertainment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use switch case to navigate through the different genre of movies
            Console.WriteLine("+++++++Welcome to Entertainment Catalog System+++++++++");
            
            Movies M = new Movies();
            M.ActionMovieList();
            M.BiographyMovieList();
            M.RomanceMovieList();
            M.ThrillerList();
            M.ScifiList();



        }
    }
}
