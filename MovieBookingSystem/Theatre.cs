using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem
{
    public class Theatre
    {
        public string TheatreName { get; set; }
        public string Location { get; set; }
        public List<Movie> AvailableMovies;
        public Dictionary<Movie, List<string>> ShowTimes;
        public Dictionary<Movie, Dictionary<string, int>> SeatAvailabilty;

        public Theatre(string theatreName, string location)
        {
            TheatreName = theatreName;
            Location = location;
            ShowTimes = new Dictionary<Movie, List<string>>();
            AvailableMovies = new List<Movie>();
            SeatAvailabilty = new Dictionary<Movie, Dictionary<string, int>>();
            
        }

        public List<string> GetShowTime(Movie movie)
        {
            if (ShowTimes.ContainsKey(movie))
            {
                return ShowTimes[movie];
            }
            else
            {
                return new List<string>(); //return a empty list -  useful because it ensures that the method always returns a valid List<string>
            }
        }

        public List<Movie> GetAvailableMovies()
        {
              return new List<Movie>(AvailableMovies);
        }

        public int CheckSeatAvailbilty(Movie movie, string timing)
        {
            if(SeatAvailabilty.ContainsKey(movie) && SeatAvailabilty[movie].ContainsKey(timing))
            {
                return SeatAvailabilty[movie][timing];
            }
            else
            {
                return 0;
            }
        }

        public bool BookSeat(Movie movie, string timing, int numberOfSeat)
        {
            if(SeatAvailabilty.ContainsKey(movie) && SeatAvailabilty[movie].ContainsKey(timing))
            {
                if (SeatAvailabilty[movie][timing] >= numberOfSeat)
                {
                    SeatAvailabilty[movie][timing] -= numberOfSeat;
                    Console.WriteLine($"Successfully booked {numberOfSeat} seat(s) for {movie.GetMovieName()} at {timing}.");
                    return true;
                }
               
            }
            return false; 
        }

        public void AddMovie(Movie movie)
        {
            AvailableMovies.Add(movie);
        }

        public void AddShowTime(Movie movie, string timing)
        {
            if (ShowTimes.ContainsKey(movie))
            {
                ShowTimes[movie].Add(timing);
            }
            else
            {
                ShowTimes[movie] = new List<string> { timing };
            }
        }

        //public void SetSeatAvailbilty(Movie movie, string timing, int seats)
        //{
        //    if (!SeatAvailabilty.ContainsKey(movie))
        //    {
        //        SeatAvailabilty[movie] = new Dictionary<string, int>();//Adds a new entry for the movie with an empty inner dictionary (timing ➝ seats).
        //    }

        //    SeatAvailabilty[movie][timing] = seats;
        //}
        public void SetSeatAvailbilty(Movie movie, string timing, int seats)
        {
            if (SeatAvailabilty.ContainsKey(movie))
            {
                SeatAvailabilty[movie][timing] = seats;
            }
            else
            {
                SeatAvailabilty[movie] = new Dictionary<string, int>() { { timing, seats } };
            }
        }
    }






}

