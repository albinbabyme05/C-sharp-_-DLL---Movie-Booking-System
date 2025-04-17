
using MovieBookingSystem;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        
        // initialze movie objects
        Movie movie1 = new Movie("Sevens", "s7", "2h30m", "thriller");
        Movie movie2 = new Movie("inception", "I3", "1h15m", "KRIMI");
        Movie movie3 = new Movie("kali", "KM7", "3H", "Drama");

        //initialize theatre objects
        Theatre t1 = new Theatre("PVR", "Kochi");
        Theatre t2 = new Theatre("airMax", "Kannur");
        Theatre t3 = new Theatre("Lulu", "Trivandram");

        // created a list for the theatre list
        List<Theatre> theatreList = new List<Theatre> { t1, t2, t3 };

        // add movies to list
        t1.AddMovie(movie1);
        t1.AddMovie(movie2);
        t1.AddMovie(movie3);
        t2.AddMovie(movie1);

        t1.AddShowTime(movie1, "3pm");
        t1.AddShowTime(movie1, "6pm");
        t1.AddShowTime(movie1, "9pm");
        t2.AddShowTime(movie1, "3pm");

        t1.AddShowTime(movie2, "10am");
        t1.AddShowTime(movie2, "2pm");
  
        t1.AddShowTime(movie3, "7am");

        t1.SetSeatAvailbilty(movie1, "3pm", 50);
        t1.SetSeatAvailbilty(movie1, "2pm", 50);
        t1.SetSeatAvailbilty(movie1, "9pm", 70);

        t2.SetSeatAvailbilty(movie1, "3pm", 20);
        Console.WriteLine("Available Movies:");


        //check availble shows
        foreach (var movie in t1.AvailableMovies)
        {
            movie.DisplayMovieInfo();
            var times = t1.GetShowTime(movie);
            Console.WriteLine("Showtimes: " + string.Join(", ", times));
        }

        //book a seat
        t1.BookSeat(movie1, "3pm", 15);
        t2.BookSeat(movie1, "3pm", 9);
        t1.BookSeat(movie1, "9pm", 20);


        Console.WriteLine($"Remaining Seats for {movie1.GetMovieName()}   {t2.CheckSeatAvailbilty(movie1, "3pm")}");
        Console.WriteLine($"Remaining Seats for {movie1.GetMovieName()}   {t1.CheckSeatAvailbilty(movie1, "9pm")}");

        // initializing regsiter user
        RegisteredUser user1 = new RegisteredUser("albin", "albin@g.com", "9744004873");

        Console.WriteLine("=============================================================");

        // search for a movie
        var searchResults = user1.SearchMovie(movie1.GetMovieName(), t1.AvailableMovies);
        Console.WriteLine("Search Results:");
        foreach (var movie in searchResults)
        {
            Console.WriteLine($"- {movie.GetMovieName()} ({movie.GetMovieName()})");
        }

        Console.WriteLine("=============================================================");

        // search for a theatre where movies are available
        var availableTheatres = user1.ViewTheatre(movie1, theatreList);
        Console.WriteLine("Available Theatres for this movie:");
        foreach (var theatre in availableTheatres)
        {
            Console.WriteLine($"- {theatre.TheatreName} at {theatre.Location}");
        }
        Console.WriteLine("=============================================================");

        //booking a ticket for reguster user
        user1.BookTicket(t1, movie1, "9pm", 5);
        user1.BookTicket(t2, movie1, "3pm", 4);

        Console.WriteLine($"Remaining Seats for {movie1.GetMovieName()}   {t2.CheckSeatAvailbilty(movie1, "3pm")}");
        Console.WriteLine($"Remaining Seats for {movie1.GetMovieName()}   {t1.CheckSeatAvailbilty(movie1, "9pm")}");
    }
}

