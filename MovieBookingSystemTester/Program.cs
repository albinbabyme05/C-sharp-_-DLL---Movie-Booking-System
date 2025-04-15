
using MovieBookingSystem;


class Program
{
    static void Main(string[] args)
    {
        Movie movie = new Movie("Sevens", "s7", "2h30m", "thriller");

        movie.DisplayMovieInfo();
        movie.ShowTime.Add("12pm, 6pm, 9pm");
        movie.GetAvailbleShowtime();
    }
}

