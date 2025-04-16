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


        public string GetMovieName() => MovieName;
        public string GetMovieId() => MovieId;

        public void DisplayMovieInfo()
        {
            Console.WriteLine($"MovieName: {MovieName} - Duration: {Duration} - Genre: {Genre} ");
        }

        public override bool Equals(object? obj)
        {
            if (obj is Movie other)
            {
                return MovieId == other.MovieId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return MovieId.GetHashCode();
        }
    }

}


