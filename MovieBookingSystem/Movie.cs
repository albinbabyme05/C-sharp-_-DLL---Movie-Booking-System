using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem
{
    public class Movie
    {
        private string MovieId;
        private string MovieName { get; set; }
        private string Duration;
        private string Genre;

        public Movie(string name, string movieId, string duration, string genre)
        {
            MovieName = name;
            MovieId = movieId;
            Duration = duration;
            Genre = genre;

        }


        public String GetMovieName() => MovieName;
        public string GetMovieId() => MovieId;

        public void DisplayMovieInfo()
        {
            Console.WriteLine($"MovieName: {MovieName} - Duration: {Duration} - Genre: {Genre} ");
        }
       
        // check the movie availble in any other theatre
        //public void IsAailble()
        //{

        //}
    }

}


