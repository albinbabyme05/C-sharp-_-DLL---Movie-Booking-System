using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem
{
    public abstract class User
    {
        private string UserName { get; set; }
        private Guid UserId { get; set; }
        private string Email { get; set; }

        protected User(string userName, string email)
        {
            UserName = userName;
            UserId = Guid.NewGuid();
            Email = email;
        }

        public abstract List<Movie> SearchMovie(string movieName, List<Movie> movielist);

        public abstract List<Theatre> ViewTheatre(Movie movie, List<Theatre> theatresList);

        public abstract string BookTicket(Theatre theatre, Movie movie, string timing, int seats);
    }
}
