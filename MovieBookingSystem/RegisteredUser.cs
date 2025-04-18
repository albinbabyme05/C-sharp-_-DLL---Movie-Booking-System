using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem
{
    public class RegisteredUser : User
    {
        private string PhoneNumber { get; set; }
        private List<string> Booking = new List<string>();

        public RegisteredUser(string userName, string email, string phoneNumber):base(userName, email)
        {
            PhoneNumber = phoneNumber;
            Booking = new List<string>();
        }

        public string GetPhoneNumber() => PhoneNumber;

        public override string BookTicket(Theatre theatre, Movie movie, string timing, int seats)
        {
            // check show exist -->
            if (!theatre.ShowTimes.ContainsKey(movie) || !theatre.ShowTimes[movie].Contains(timing))
            {
                return "Show time is not available for this Movie";
            }
            // check seat availbilty
            int availableSeat = theatre.CheckSeatAvailbilty(movie, timing);
            if(availableSeat <seats)
            {
                return $"Only {availableSeat} seats availble, Booking Failed";
            }
            // book a seat
            bool success = theatre.BookSeat(movie, timing, seats);
            if (success)
            {
                string bookingDetails = $"{movie.GetMovieName()} - Theatre:{theatre.TheatreName} - Time: {timing} - seats: {seats}";
                Booking.Add(bookingDetails);
                return "Booking Successful!";
            }
            else
            {
                return "Booking failed due to system error";
            }

        }

        public override List<Movie> SearchMovie(string movieName, List<Movie> movielist)
        {
            var result = new List<Movie>();
            foreach (var movie in movielist)
            {
                if (movie.GetMovieName().Contains(movieName))
                {
                    result.Add(movie);
                }
            }
            return result;
        }

        public override List<Theatre> ViewTheatre(Movie movie, List<Theatre> theatresList)
        {
            var result = new List<Theatre>();
            foreach (var theatre in theatresList)
            {
                if (theatre.AvailableMovies.Contains(movie))
                {
                    result.Add(theatre);
                }
            }
            return result;

        }

        public void ViewBookingHistroy() 
        {
            Console.WriteLine("============**");
            foreach (var item in Booking)
            {
                Console.WriteLine($"{item}");
                
            }
            Console.WriteLine("============**");
        }


    }
}
