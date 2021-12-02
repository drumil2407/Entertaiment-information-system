using System;
using System.Collections.Generic;

namespace Entertainment
{
    //Here I give 5  genre with 5 movies

    class Movies : AbstractEntertaiment
    {
        //I use a generic list to add movie names in 5 genre category in methods as below

        //ActionMovieList, BiographyMovieList, RomanceMovieList, ThrillerMovieLis, ScifiMovieList  

        private new List<string> MoviesName = new List<string>();
        

        public void ActionMovieList()
        {
            
            MoviesName.Add("The Dark Knight");
            MoviesName.Add("Inception");
            MoviesName.Add("Gladiator");
            MoviesName.Add("Dune");
            MoviesName.Add("The Expandables");


            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);
            
        }

        public void BiographyMovieList()
        {

            MoviesName.Add("The theory of everything");
            MoviesName.Add("The Imitation Game");
            MoviesName.Add("The Social Network");
            MoviesName.Add("American Sniper");
            MoviesName.Add("First Man");

            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }

        public void RomanceMovieList()
        {
            MoviesName.Add("Titanic");
            MoviesName.Add("The Shape of water");
            MoviesName.Add("Me before you");
            MoviesName.Add("2:22");
            MoviesName.Add("La la land");

            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }

        public void ThrillerMovieList()
        {

            MoviesName.Add("Parasite");
            MoviesName.Add("Gone girl");
            MoviesName.Add("The girl with the dragon tattoo");
            MoviesName.Add("Wind river");
            MoviesName.Add("The revanant");

            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);
        }

        public void ScifiMovieList()
        {

            MoviesName.Add("The passengers");
            MoviesName.Add("Venom");
            MoviesName.Add("Upgrade");
            MoviesName.Add("The blade runner");
            MoviesName.Add("Chaos Walking");

            for (int i = 0; i < MoviesName.Count; i++)
                Console.WriteLine(MoviesName[i]);

        }

    }
}
