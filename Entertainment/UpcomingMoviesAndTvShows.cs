using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
    class UpcomingMoviesAndTvShows
    {

        ArrayList UpcomingTAndMovie = new ArrayList()
        {
            "1.The Batman", "2.The king's Man", "3.Morbius", "4.The Flash"
        };

        public void run()
        {
            for (int i = 0; i < UpcomingTAndMovie.Count; i++)
                Console.WriteLine(UpcomingTAndMovie[i]);
            
        }
      


    }
}
