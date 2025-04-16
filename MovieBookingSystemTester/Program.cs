
using MovieBookingSystem;


class Program
{
    static void Main(string[] args)
    {
        Movie movie1 = new Movie("Sevens", "s7", "2h30m", "thriller");
        Movie movie2 = new Movie("inception", "I3", "1h15m", "KRIMI");
        Movie movie3 = new Movie("kali", "KM7", "3H", "Drama");
        Theatre t1 = new Theatre("PVR", "Kochi");

        t1.AddMovie(movie1);
        t1.AddMovie(movie2);
        t1.AddMovie(movie3);

        t1.AddShowTime(movie1, "3pm");
        t1.AddShowTime(movie1, "6pm");
        t1.AddShowTime(movie1, "9pm");

        t1.AddShowTime(movie2, "10am");
        t1.AddShowTime(movie2, "2pm");
  
        t1.AddShowTime(movie3, "7am");

        t1.SetSeatAvailbilty(movie1, "3pm", 50);
        t1.SetSeatAvailbilty(movie1, "2pm", 50);
        t1.SetSeatAvailbilty(movie1, "9pm", 70);
        Console.WriteLine("Available Movies:");

        foreach (var movie in t1.AvailableMovies)
        {
            movie.DisplayMovieInfo();
            var times = t1.GetShowTime(movie);
            Console.WriteLine("Showtimes: " + string.Join(", ", times));
        }

        t1.BookSeat(movie1, "3pm", 15);
        t1.BookSeat(movie1, "1pm", 3);
        t1.BookSeat(movie1, "9pm", 20);

        Console.WriteLine($"Remaining Seats for {movie1.GetMovieName()}   {t1.CheckSeatAvailbilty(movie1, "3pm")}");
        Console.WriteLine($"Remaining Seats for {movie1.GetMovieName()}   {t1.CheckSeatAvailbilty(movie1, "9pm")}");


    }
}

