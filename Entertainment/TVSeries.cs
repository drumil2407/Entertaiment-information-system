using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
    interface ITvserieName
    {
        public abstract void ActionTvSeriesList();
        public abstract void BiographyTvSeriesList();
        public abstract void RomanceTvSeriesList();
        public abstract void ThrillerTvseriesList();
        public abstract void ScifiTvSeriesList();

    }
       //Here I give 5 different genre with 5 movies


    class TVSeries : ITvserieName
    {
        //I use a generic list to add Tv series names in 5 genre category in methods as below

        //ActionTvseriesList, BiographyTvseriesList, RomanceTvseriesList, ThrillerTvseriesLis, ScifiTvseriesList  

        private List<string> TvSeriesName = new List<string>();



        public void ActionTvSeriesList()
        {

            TvSeriesName.Add("1.Strike back");
            TvSeriesName.Add("2.Arrow");
            TvSeriesName.Add("3.Warrior");
            TvSeriesName.Add("4.Nikita");
            TvSeriesName.Add("5.The human target");


            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(TvSeriesName[i]);
        }

        public void BiographyTvSeriesList()
        {

            TvSeriesName.Add("1.Da vinci's demons");
            TvSeriesName.Add("2.Narcos");
            TvSeriesName.Add("3.Manhunt");
            TvSeriesName.Add("4.The Crown");
            TvSeriesName.Add("5.Spartacus");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(TvSeriesName[i]);

        }

        public void RomanceTvSeriesList()
        {
            TvSeriesName.Add("1.Once upon a time");
            TvSeriesName.Add("2.Beauty and the beast");
            TvSeriesName.Add("3.A Discovery of Witches");
            TvSeriesName.Add("4.El Chapo");
            TvSeriesName.Add("5.Medici");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(TvSeriesName[i]);
        }

        public void ThrillerTvseriesList()
        {

            TvSeriesName.Add("1.The Sinner");
            TvSeriesName.Add("2.You");
            TvSeriesName.Add("3.Mindhumter");
            TvSeriesName.Add("4.Strangers");
            TvSeriesName.Add("5.Hannibal");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(TvSeriesName[i]);
        }

        public void ScifiTvSeriesList()
        {

            TvSeriesName.Add("1.Westworld");
            TvSeriesName.Add("2.Altered carbon");
            TvSeriesName.Add("3.Lost in space");
            TvSeriesName.Add("4.The Expanse");
            TvSeriesName.Add("5.Dark Matter");

            for (int i = 0; i < TvSeriesName.Count; i++)
                Console.WriteLine(TvSeriesName[i]);

        }
    }
}
