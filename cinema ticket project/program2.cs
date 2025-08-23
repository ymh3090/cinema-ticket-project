using cinema_ticket_project;













/*
Admin Methods
- addMovie() → add a new movie


public void addMovie()
{
    Console.Write("\nenter movie title: ");       string title = Console.ReadLine();

Console.Write("enter duration (in minutes): ");
     if (int.TryParse(Console.ReadLine(), out int duration)){
         
        Console.Write("enter number of seats : ");
        string seatInput = Console.ReadLine();

        Movie m = new Movie(title, duration, seatCount);
        movies.Add(m);
        }
        else{
            Console.WriteLine("invalid duration entered!");
       }
}





- viewAllBookings() → view all bookings

public void ShowSeats(){
    











Customer Methods
- chooseMovie(Movie m) → select a movie
- bookSeat(Movie m, seatNumber) → book a seat

*/




/*
 
 
 
 
 class Movie
{
    public string title;
    public int duration;
    public bool[] seats;

    public Movie(string t, int d, int numSeats)
    {
        title = t;
        duration = d;
        seats = new bool[numSeats];
    }

    public void ShowSeats()
    {
        Console.WriteLine("Seats for " + title);
        for (int i = 0; i < seats.Length; i++)
        {
            if (seats[i] == true)
                Console.WriteLine("Seat " + (i + 1) + ": booked");
            else
                Console.WriteLine("Seat " + (i + 1) + ": available");
        }
    }

    public void BookSeat(int seatNum)
    {
        if (seatNum < 1 || seatNum > seats.Length)
        {
            Console.WriteLine("Seat number not valid.");
            return;
        }

        if (seats[seatNum - 1] == false)
        {
            seats[seatNum - 1] = true;
            Console.WriteLine("Seat " + seatNum + " booked.");
        }
        else
        {
            Console.WriteLine("Seat " + seatNum + " already booked.");
        }
    }
}
 
 
 
 
 
 
 
 */