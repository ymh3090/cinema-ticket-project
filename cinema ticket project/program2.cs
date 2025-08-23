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
 public class Person
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}
static List<Person> users = new List<Person>();

static void CreateAcc()
{
    Console.Clear();
    
    Console.Write("Enter Full Name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Username: ");
    string username = Console.ReadLine();

    
    foreach (var user in users)
    {
        if (user.Username == username)
        {

            Console.WriteLine("Username already exists! Press Enter please to try again");
            Console.ReadLine();
            return;
        }
    }

    Console.Write("Enter Password: ");


    string password = Console.ReadLine();

    string role;
    while (true)
    {

        Console.Write("Enter Role admin or customer (upper or lower not necessary): ");
        role = Console.ReadLine();

        if (role.ToLower() != "admin" && role.ToLower() != "customer")
        {
            break;
        }
        Console.WriteLine("Invalid role! please type admin or customer properly!!!");
    }
        users.Add(new Person
    {
        Name = name,
        Username = username,
        Password = password,
        Role = role
    });

    Console.WriteLine("Account creation succes!! Press enter please");
    Console.ReadLine();
}
static void Login()
{
    while (true)
    {
        Console.Clear();

        Console.Write("Enter Username: ");

        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();
        Person foundUser = null;
        foreach (var user in users)
        {
            if (user.Username == username && user.Password == password)
            {
                foundUser = user;
                break;

            }
        }
            if (foundUser != null)
            {
                Console.WriteLine($"You are logged in as {foundUser.Role}.");

                if (foundUser.Role.ToLower() == "admin")
                {
                    AdminMenu(user);

                }
                else
                {


                    CustomerMenu(user);
                }
                return;
            }
            else
            {
                Console.WriteLine("Invalid username or password! Please press enter to try again.");
                Console.ReadLine();
            }

        

    }
    
}
 
 
 
 
 
 
 */
