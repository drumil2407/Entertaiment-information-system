using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
    class MoviesInformation : AbstractEntertaiment
    {

        public void DarkKnight()
        {
            
            MovieDescription = "With the help of allies Lt." +
                " Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart)," +
                " Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. " +
                "But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws " +
                "the town into chaos, the caped Crusader begins to tread a fine line between heroism and " +
                "vigilantism.";
            
            Ratings = 9.0;
            
            Review = "The Dark Knight will forever be the greatest comic book movie ever made. " +
                "The cast is once again superb and the standout performance by Heath Ledger as the Joker " +
                "really make this film stand out amongst all others. It Draws the perfect line between Heroism " +
                "and the villain as well as having an excellent lesson tied in within its plot. It has great action" +
                " sequences and ultimately is a story about Batman being pushed to his limits to the point where he" +
                " be considered neither hero nor villain. It lives up to the expectations it had upon release" +
                " and probably even well exceeded them. A great film to watch and guarantee 90% of people will " +
                "be blown out of their seats when watching this ultimate thrill ride about the battle between" +
                " good and evil.";
           
            Casts = "Aaron Eckhart, Christian Bale, Heath Ledger";
            Console.WriteLine("DESCRIPTION");
            Console.WriteLine(MovieDescription);
            Console.WriteLine("\n");
            Console.WriteLine("RATINGS");
            Console.WriteLine(Ratings);
            Console.WriteLine("\n");
            Console.WriteLine("REVIEW");
            Console.WriteLine(Review);
            Console.WriteLine("\n");
            Console.WriteLine("CASTS");
            Console.WriteLine(Casts);
        }

    }
}
