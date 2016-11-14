using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Assignment 3 Movie Bonanaza
 * Georgios Psarakis
 * 200289922 
 */
namespace MovieBonanza
{
    class Movies
    {
        /*Movie Title will be stored as title*/
        public string Title { get; set; }

        /*Movie genres
         * Comedy $1.99
           Drama $1.99
           Action $2.99
           Sci-Fi $2.99
           Horror $2.99
           Thriller $1.99
           Family $0.99
           New Releases $4.99  
            */
        public string Genre { get; set; }

        /*Movie cost before aditions are added */
        public string Cost { get; set; }

        /*Movie Total after all expenses */
        public string Total { get; set; }

        /*Movie poster picture*/
        public System.Drawing.Bitmap Poster { get; set; }


    }
}
