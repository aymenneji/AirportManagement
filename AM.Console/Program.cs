// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");

//Flight f1 = new Flight("Sfax","bouzid");
//Flight f2 = new Flight(1,DateTime.Now,2);
//Initialiseur d'objet
Flight f3 = new Flight
{
    Departure = "Tunis",
    Destination = "France",
    FlightDate = DateTime.Now

};
Flight f4 = new Flight
{
    // EstimatedDuation = 2
};
Flight f5 = new Flight
{
    FlightId = 1
};

Passenger p1 = new Passenger
{
    LastName = "neji",
    FirstName = "aymen",
    EmailAdress = "email"
};

Traveller t1 = new Traveller();
Staff st1 = new Staff();
Console.WriteLine(p1.checkProfile("neji", "aymen"));
Console.WriteLine(p1.checkProfile(  "dazadzad", "klkdk","efezfeze"));
Console.WriteLine(p1.Login("neji", "aymen"));
p1.PassengerType();
st1.PassengerType();
t1.PassengerType();

