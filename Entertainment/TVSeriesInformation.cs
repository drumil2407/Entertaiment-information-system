using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
    class TVSeriesInformation
    {
        public string TVDescription { get; set; }
        public double TVRatings { get; set; }
        public string TVReview { get; set; }
        public string TVCasts { get; set; }

        public void Warrior()
        {

            TVDescription = "A crime drama that takes place in the latter half of the 19th century during brutal gang wars in San Francisco's Chinatown, it follows martial arts prodigy Ah Sahm, a Chinese immigrant who arrives in the City of Lights under mysterious circumstances. Once he proves his prowess as a fighter, Sahm becomes a hit man for one of Chinatown's most powerful organized crime families." +
                " As he is mentored by the son of the crime family's leader, learning the ins and outs of gang warfare, Al Sahm wins the confidence of brothel madam Ah Toy, eventually revealing to her his true intentions. Warrior is based on the writings of martial arts legend Bruce Lee and features a largely Asian cast.";

            TVRatings = 8.4;

            TVReview = "This show is nothing short of OUTSTANDING!!  The plot, the drama and the martial arts kept me on a roller coaster ride and salivating for the next episode!!  ThIs SUPER TALENTED cast is so well put together and the actors/actresses all deserve OSCARS for their SUPERB performances because they breathe stimulating air into this Chinese/Irish/American western style series that keeps me on the edge of my seat while begging for more.  The choreography was beautiful and the story lines were so realistic that I was drawn into this western world of kung fu drama with sexy actors and actresses who brought it all with each episode.  Bruce Lee would have been so proud of this MASTERPIECE and extremely hard work that results in a FLAWLESS SERIES!!  This is a HIT and will be for years to come!!!!!";

            TVCasts = "Andrew Koji, Olivia Cheng, Dianne Doan";
            Console.WriteLine("DESCRIPTION");
            Console.WriteLine(TVDescription);
            Console.WriteLine("\n");
            Console.WriteLine("RATINGS");
            Console.WriteLine(TVRatings);
            Console.WriteLine("\n");
            Console.WriteLine("REVIEW");
            Console.WriteLine(TVReview);
            Console.WriteLine("\n");
            Console.WriteLine("CASTS");
            Console.WriteLine(TVCasts);
        }


    }
}
