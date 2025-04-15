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

        public List<string> ShowTime;
        public Movie(string name, string movieId, string duration, string genre)
        {
            MovieName = name;
            MovieId = movieId;
            Duration = duration;
            Genre = genre;
            ShowTime = new List<string>();
        }


        public String GetMovieName() => MovieName;
        public string GetMovieId() => MovieId;

        public void DisplayMovieInfo()
        {
            Console.WriteLine($"MovieName: {MovieName} - Duration: {Duration} - Genre: {Genre} ");
        }
        public void GetAvailbleShowtime()
        {
            foreach (var show in ShowTime)
            {
                Console.WriteLine($"shows: {show}");
            }
        }
    }

}


