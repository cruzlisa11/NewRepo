using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Show
    /*always use public instead of private*/

    { //now let's make an instance of the class Show
        public string show_title { get; set; }
        public DateTime release_date { get; set; }

        public string genre { get; set; }
        public double rating { get; set; }

        //now we make a default constructor

        //<summary>
        //default / empty constructor
        //</summary> 
        
        public Show()
        {
            show_title = string.Empty;
            release_date = DateTime.Now;
            genre = string.Empty;
            rating = 0.0;
        }
        public override string ToString()
        { //now we will return the show title and the release date
            return $"{show_title} ({ release_date}) - {genre} - {rating.ToString("N2")}";
        }

    }
}
