using System;

namespace Entertainment
{
    class Program
    {
        static void Main(string[] args)
        {
            //class movie object
            Movies M = new Movies();
            //class Tvseries object
            TVSeries TV = new TVSeries();
            
            Console.WriteLine("+++++++Welcome to Entertainment Catalog System+++++++++");
            Console.WriteLine("\n");
            Console.WriteLine("Choose One of the options");
            Console.WriteLine("\n");
            Console.WriteLine("1.Movies");
            Console.WriteLine("2.Tvseries");

            // Use switch case to navigate through the different genre of movies

            int h = Convert.ToInt32(Console.ReadLine());


            switch (h)
            {

                case 1:


                    Console.WriteLine("\n");
                    Console.WriteLine("Select any one genre for movie list");
                    Console.WriteLine("\n");
                    Console.WriteLine("1.Action");
                    Console.WriteLine("2.Biography");
                    Console.WriteLine("3.Romance");
                    Console.WriteLine("4.Thriller");
                    Console.WriteLine("5.Scifi");


                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {

                        case 1:
                            Console.WriteLine("\n");
                            Console.WriteLine("#Action Movies List#");
                            Console.WriteLine("\n");
                            M.ActionMovieList();

                            break;

                        case 2:
                            Console.WriteLine("\n");
                            Console.WriteLine("#Biography Movies List#");
                            Console.WriteLine("\n");
                            M.BiographyMovieList();
                            break;

                        case 3:
                            Console.WriteLine("\n");
                            Console.WriteLine("#Romance Movies List#");
                            Console.WriteLine("\n");
                            M.RomanceMovieList();
                            break;

                        case 4:
                            Console.WriteLine("\n");
                            Console.WriteLine("#Thriller Movies List#");
                            Console.WriteLine("\n");
                            M.ThrillerMovieList();
                            break;

                        case 5:
                            Console.WriteLine("\n");
                            Console.WriteLine("#Scifi Movies List#");
                            Console.WriteLine("\n");
                            M.ScifiMovieList();

                            break;

                    }
                    break;



                case 2:

                    Console.WriteLine("\n");
                    Console.WriteLine("Select any one genre for Tvseries list");
                    Console.WriteLine("\n");
                    Console.WriteLine("1.Action");
                    Console.WriteLine("2.Biography");
                    Console.WriteLine("3.Romance");
                    Console.WriteLine("4.Thriller");
                    Console.WriteLine("5.Scifi");

                    int b = Convert.ToInt32(Console.ReadLine());
                    switch (b)
                    {
                        case 1:
                            Console.WriteLine("\n");
                            Console.WriteLine("#ActionTvSeries List#");
                            Console.WriteLine("\n");
                            TV.ActionTvSeriesList();
                            
                            break;
                        case 2:
                            Console.WriteLine("\n");
                            Console.WriteLine("#BiographyTvSeries List#");
                            Console.WriteLine("\n");
                            TV.BiographyTvSeriesList();
                            
                            break;
                        case 3:
                            Console.WriteLine("\n");
                            Console.WriteLine("#RomanceTvSeries List#");
                            Console.WriteLine("\n");
                            TV.RomanceTvSeriesList();
                            
                            break;
                        case 4:
                            Console.WriteLine("\n");
                            Console.WriteLine("#ThrillerTvseries List#");
                            Console.WriteLine("\n");
                            TV.ThrillerTvseriesList();
                            
                            break;
                        case 5:
                            Console.WriteLine("\n");
                            Console.WriteLine("#ScifiTvSeries List#");
                            Console.WriteLine("\n");
                            TV.ScifiTvSeriesList();
                           
                            break;
                    }
                break;
                       
            }

        }
    }
}
