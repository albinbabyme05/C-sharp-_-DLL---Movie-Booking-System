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
        public List<Movie> AvailbleMovies;
        public Dictionary<Movie, List<string>> ShowTimes;
        public Dictionary<Movie, Dictionary<string, int>> SeatAvailbilty;

        public Theatre(string theatreName, string location)
        {
            TheatreName = theatreName;
            Location = location;
            ShowTimes = new Dictionary<Movie, List<string>>();
            AvailbleMovies = new List<Movie>();
            SeatAvailbilty = new Dictionary<Movie, Dictionary<string, int>>();
            
        }

        public List<string> GetShowTime(Movie movie)
        {
            if (ShowTimes.ContainsKey(movie))
            {
                return ShowTimes[movie];
            }
            else
            {
                return new List<string>();
            }
        }

        public int CheckSeatAvailbilty(Movie movie, String timing)
        {
            if(SeatAvailbilty.ContainsKey(movie) && SeatAvailbilty[movie].ContainsKey(timing))
            {
                return SeatAvailbilty[movie][timing];
            }
            else
            {
                return 0;
            }
        }

        public void BookSeat(Movie movie, string timing, int numberOfSeat)
        {
            if(SeatAvailbilty.ContainsKey(movie) && SeatAvailbilty[movie].ContainsKey(timing))
            {
                if (SeatAvailbilty[movie][timing] >= numberOfSeat)
                {
                    SeatAvailbilty[movie][timing] -= numberOfSeat;
                    Console.WriteLine($"Successfully booked {numberOfSeat} seat(s) for {movie.GetMovieName()} at {timing}.");
                    return;
                }
                else
                {
                    Console.WriteLine("Not enough seats available for this booking.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Movie, Try Again.");
            }
        }

        public void AddMovie(Movie movie)
        {
            AvailbleMovies.Add(movie);
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

        public void SetSeatAvailbilty(Movie movie, string timing, int seats)
        {
            if (SeatAvailbilty.ContainsKey(movie))
            {
                if (SeatAvailbilty[movie].ContainsKey(timing))
                {
                    SeatAvailbilty[movie][timing]  = seats;
                }
                else
                {
                    // If the timing is not found, add it to the dictionary.
                    SeatAvailbilty[movie].Add(timing, seats);
                }
            }
            
        }






    }
}
