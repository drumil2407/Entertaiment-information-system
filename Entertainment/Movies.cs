using System;
using System.Collections.Generic;

namespace Entertainment
{
    abstract class AbstractMovies
    {
        //property for Moviename 

        public string MoviesName { get; set; }

        //methods of different genre and body is in the movies class
        public abstract void ActionMovieList();
        public abstract void BiographyMovieList();
        public abstract void RomanceMovieList();
        public abstract void ThrillerMovieList();
        public abstract void ScifiMovieList();

    }


    //Here I give 5  genre with 5 movies

    class Movies : AbstractMovies
    {

        public string MovieDescription { get; set; }
        public double Ratings { get; set; }
        public string Review { get; set; }
        public string Casts { get; set; }

        //I use a generic list to add movie names in 5 genre category in methods as below

        //ActionMovieList, BiographyMovieList, RomanceMovieList, ThrillerMovieLis, ScifiMovieList  

        private new List<string> MoviesName = new List<string>();
        public override void ActionMovieList()
        {

            MoviesName.Add("1.The Dark Knight");
            MoviesName.Add("2.Inception");
            MoviesName.Add("3.Gladiator");
            MoviesName.Add("4.Dune");
            MoviesName.Add("5.The Expandables");


            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }

        public override void BiographyMovieList()
        {

            MoviesName.Add("1.The theory of everything");
            MoviesName.Add("2.The Imitation Game");
            MoviesName.Add("3.The Social Network");
            MoviesName.Add("4.American Sniper");
            MoviesName.Add("5.First Man");

            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }

        public override void RomanceMovieList()
        {
            MoviesName.Add("1.Titanic");
            MoviesName.Add("2.The Shape of water");
            MoviesName.Add("3.Me before you");
            MoviesName.Add("4.2:22");
            MoviesName.Add("5.La la land");


            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }

        public override void ThrillerMovieList()
        {

            MoviesName.Add("1.Parasite");
            MoviesName.Add("2.Gone girl");
            MoviesName.Add("3.The girl with the dragon tattoo");
            MoviesName.Add("4.Wind river");
            MoviesName.Add("5.The revanant");

            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);
        }

        public override void ScifiMovieList()
        {

            MoviesName.Add("1.The passengers");
            MoviesName.Add("2.Venom");
            MoviesName.Add("3.Upgrade");
            MoviesName.Add("4.The blade runner");
            MoviesName.Add("5.Chaos Walking");

            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }
        

       

    }
}
