using System;

namespace Entertainment
{

    class Menu : Music
    {

       public void Choices()
       {

            //class movie object
            Movies M = new Movies();
            //class Tvseries object
            TVSeries TV = new TVSeries();
            //class Movieinformation object
            MoviesInformation MI = new MoviesInformation();
            //class upcomingMoviesAndTvShows object
            UpcomingMoviesAndTvShows UMT = new UpcomingMoviesAndTvShows();
            //creating a music object
            Music m = new Music();
            //creating TvseriesInformation
            TVSeriesInformation tvinfo = new TVSeriesInformation();

            // Use switch case to navigate through the different genre of movies

            int h = Convert.ToInt32(Console.ReadLine());


            switch (h)
            {

                case 1:

                    Console.Clear();
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

                            // method which is called is from abstract class entertainment

                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Action Movies List#");
                            Console.WriteLine("\n");
                            M.ActionMovieList();
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter your choice to see movie information:");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {

                                case 1:
                                    MI.DarkKnight();
                                    m.Play2();
                                    break;

                            }
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Biography Movies List#");
                            Console.WriteLine("\n");
                            M.BiographyMovieList();
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Romance Movies List#");
                            Console.WriteLine("\n");
                            M.RomanceMovieList();
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Thriller Movies List#");
                            Console.WriteLine("\n");
                            M.ThrillerMovieList();
                            Console.ReadLine();
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Scifi Movies List#");
                            Console.WriteLine("\n");
                            M.ScifiMovieList();
                            Console.ReadLine();
                            break;

                    }
                    Console.ReadLine();
                    break;

            

                case 2:
                    Console.Clear();
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
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter your choice to see Tvseries information:");
                            int d = Convert.ToInt32(Console.ReadLine());
                            switch (d)
                            {

                                case 1:
                                    tvinfo.Warrior();
                                    m.Play1();
                                    break;

                            }

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
                    Console.ReadLine();
                    break;
                case 3:

                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("The list of UpcomingMovieAndTvseries");
                    Console.WriteLine("\n");
                    UMT.Run();
                    Console.ReadLine();
                    break;
            }


        }


    }
}
