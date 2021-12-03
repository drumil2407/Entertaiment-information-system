using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
  abstract class AbstractEntertaiment
   {
      //properties for Moviename and Tvseries
      public string MoviesName { get; set; }
      public string TvSeriesName { get; set; }
     
      //properties for movie inforamtion
      public string MovieDescription { get; set; }
      public double Ratings { get; set; } 
      public string Review { get; set; }
      public string Casts { get; set; }
        

  }
}
