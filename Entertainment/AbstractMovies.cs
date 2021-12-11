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
}
