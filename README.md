Movie Booking System (C# Console App)

Overview:
----------
This is a simple object-oriented console-based application to simulate an online movie ticket booking system.

Features:
---------
- Add movies to a theatre
- Add showtimes for each movie
- Set seat availability per show
- Book tickets for a selected movie and time
- Check remaining seats

OOP Concepts Used:
------------------
- Encapsulation (private fields, controlled access)
- Inheritance ready structure (can extend to Guest/RegisteredUser)
- Polymorphism (via Equals & GetHashCode for Dictionary keys)

  
![movieBooking output](https://github.com/user-attachments/assets/042c702a-46b6-4e44-ae04-f065f57c0296)


Project Structure:
------------------
- Movie.cs         --> Represents a movie (name, ID, genre, duration)
- Theatre.cs       --> Manages movies, showtimes, and seat bookings
- Program.cs       --> Main entry point to run and test the logic

How to Run:
-----------
1. Compile and run the project in any C# IDE or using .NET CLI:
   dotnet run

2. The app will simulate:
   - Adding movies
   - Setting showtimes and seats
   - Booking tickets
   - Printing confirmation and seat status

Further developemnt needed in :
----------
 - track for user
 - payment
 - GUI development
 - 

