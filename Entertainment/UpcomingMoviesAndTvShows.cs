using System;
using System.Collections;

namespace Entertainment
{
    class UpcomingMoviesAndTvShows
    {
        //I use Arraylist collection class for printing upcomingTandmovie
        ArrayList UpcomingTAndMovie = new ArrayList()
        {
            "1.The Batman", "2.The king's Man", "3.Morbius", "4.The Flash"
        };

        public void Run()
        {
            for (int i = 0; i < UpcomingTAndMovie.Count; i++)
                Console.WriteLine(UpcomingTAndMovie[i]);  
        }
      


    }
}
