using System;


namespace Entertainment
{

    //Music will play when user view the dark knight(Action) in movie and warrior(ActionRvseries) in tv series

    class Menu : Music
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

        private string Movies1;
        private string Movies2;
        private string Movies3;
        private string Movies4;
        private string Movies5;

        public void Choices()
        {

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
                            Console.WriteLine("Enter your choice to see movie information or press 6 and press enter twice for exit:");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {

                                case 1:
                                    Console.WriteLine("\n");
                                    MI.DarkKnight();
                                    m.Play2();
                                    break;
                                case 6:
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
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Romance Movies List#");
                            Console.WriteLine("\n");
                            M.RomanceMovieList();
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Thriller Movies List#");
                            Console.WriteLine("\n");
                            M.ThrillerMovieList();
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
                            Console.ReadLine();
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#Scifi Movies List#");
                            Console.WriteLine("\n");
                            M.ScifiMovieList();
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
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
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#ActionTvSeries List#");
                            Console.WriteLine("\n");
                            TV.ActionTvSeriesList();
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter your choice to see movie information or press 6 and press enter twice for exit:");
                            int d = Convert.ToInt32(Console.ReadLine());
                            switch (d)
                            {

                                case 1:
                                    tvinfo.Warrior();
                                    m.Play1();
                                    break;
                                case 6:
                                    break;
                            }
                            Console.ReadLine();
                            break;
                        case 2:

                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#BiographyTvSeries List#");
                            Console.WriteLine("\n");
                            TV.BiographyTvSeriesList();
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
                            Console.ReadLine();

                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#RomanceTvSeries List#");
                            Console.WriteLine("\n");
                            TV.RomanceTvSeriesList();
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#ThrillerTvseries List#");
                            Console.WriteLine("\n");
                            TV.ThrillerTvseriesList();
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
                            Console.ReadLine();

                            break;
                        case 5:

                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("#ScifiTvSeries List#");
                            Console.WriteLine("\n");
                            TV.ScifiTvSeriesList();
                            Console.WriteLine("");
                            Console.WriteLine("Please enter two times to exit and return to main menu");
                            Console.ReadLine();

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

                case 4:

                    Console.Clear();
                    Console.WriteLine("Add 5 movies of your choice");
                    Console.WriteLine("");
                    Console.Write("Enter Your First Movie: ");
                    Movies1 = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter Your Second Movie: ");
                    Movies2 = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter Your Third Movie: ");
                    Movies3 = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter Your Fourth Movie: ");
                    Movies4 = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter Your fifth Movie: ");
                    Movies5 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("List of Your Movies");
                    Console.WriteLine("");
                    Console.Write("First Movie: ");
                    Console.WriteLine(Movies1);
                    Console.Write("First Movie ");
                    Console.WriteLine(Movies2);
                    Console.Write("First Movie ");
                    Console.WriteLine(Movies3);
                    Console.Write("First Movie ");
                    Console.WriteLine(Movies4);
                    Console.Write("First Movie ");
                    Console.WriteLine(Movies5);
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    break;

                case 6:
                    Console.Clear();
                    break;

            }


        }


    }

}