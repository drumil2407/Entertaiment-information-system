using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
       //Here I give 5 different genre with 5 movies


    class TVSeries : AbstractEntertaiment
    {
        //I use a generic list to add movie names in 5 genre category methods as below

        //ActionTvseriesList, BiographyTvseriesList, RomanceTvseriesList, ThrillerTvseriesLis, ScifiTvseriesList  

        private new List<string> TvSeriesName = new List<string>();

        public void ActionTvSeriesList()
        {

            TvSeriesName.Add("Strike back");
            TvSeriesName.Add("Arrow");
            TvSeriesName.Add("Warrior");
            TvSeriesName.Add("Nikita");
            TvSeriesName.Add("The human target");


            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(MoviesName[i]);
        }

        public void BiographyTvSeriesList()
        {

            TvSeriesName.Add("Da vinci's demons");
            TvSeriesName.Add("Narcos");
            TvSeriesName.Add("Manhunt");
            TvSeriesName.Add("The Crown");
            TvSeriesName.Add("Spartacus");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }

        public void RomanceTvSeriesList()
        {
            TvSeriesName.Add("Once upon a time");
            TvSeriesName.Add("Beauty and the beast");
            TvSeriesName.Add("A Discovery of Witches");
            TvSeriesName.Add("El Chapo");
            TvSeriesName.Add("Medici");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(MoviesName[i]);
        }

        public void ThrillerTvseriesList()
        {

            TvSeriesName.Add("The Sinner");
            TvSeriesName.Add("You");
            TvSeriesName.Add("Mindhumter");
            TvSeriesName.Add("Strangers");
            TvSeriesName.Add("Hannibal");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(MoviesName[i]);
        }

        public void ScifiTvSeriesList()
        {

            TvSeriesName.Add("Westworld");
            TvSeriesName.Add("Altered carbon");
            TvSeriesName.Add("Lost in space");
            TvSeriesName.Add("The Expanse");
            TvSeriesName.Add("Dark Matter");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }
    }
}
