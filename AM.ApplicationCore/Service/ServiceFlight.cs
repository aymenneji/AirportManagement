using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class ServiceFlight : IserviceFlight
    {    
        public IList<Flight> Flights { get; set; }  = new List<Flight>();

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            //linq

            //var query = from f in Flights

            //            group f by f.Destination;




            //expression Lambda




            var query = Flights.GroupBy(f => f.Destination);

            foreach (var f in query)

            {

                Console.WriteLine("Destination est : " + f.Key);

                foreach (var item in f)

                {

                    Console.WriteLine("La date de decollage est : " + item.FlightDate);

                }

            }

            return query;
        }

        public double DurationAverage(string destination)
        {
            //var query = from flight in Flights
            //            where flight.Destination == destination
            //            select flight.EstimatedDuration;
            //return query.Average();
            // return Flights.Where(f => (f.FlightDate - startDate).TotalDays <= 7).Count();
            return Flights.Where(flight => flight.Destination == destination).Select(flight => flight.EstimatedDuration).Average();



            //return Flights.Where(f => f.Destination.Equals(destination)).Select(f => f.EstimatedDuration).Average();

           // return Flights.Where((f) => f.Destination.Equals(destination)).Average(f => f.EstimatedDuration);
        }

        public IList<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();
            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //    {
            //        flightDates.Add(flight.FlightDate);
            //    }
            //}
            //return flightDates;
            //*** avec linq
            var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;
            return query.ToList();// cast avec ToList() car link son type de retour est ennumeré : ordonné

            
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            
            //    return Flights.OrderByDescending(flight => flight.EstimatedDuration);
            


                            var query = from flight in Flights
                                        orderby flight.EstimatedDuration descending
                                        select flight;
            return query;

        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //linq
            //var query = from f in Flights
            //            //where (f.FlightDate-startDate).TotalDays<=7
            //            where startDate.AddDays(7) < f.FlightDate
            //            select f;
            //return query.Count();

            //Expression Lambda
            // return Flights.Where(f => (f.FlightDate - startDate).TotalDays <= 7).Count();
            return Flights.Count(f => (f.FlightDate - startDate).TotalDays <= 7);

        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            //linq

            //var query = from p in flight.Passengers.OfType<Traveller>()

            //            orderby p.BirthDate

            //            select p;
            //return query.Take(3);

            //expression lambda
            return flight.Passengers.OfType<Traveller>().OrderBy(p =>p.BirthDate).Take(3);
        }

        public void ShowFlightDetails(Domain.Plane plane)
        {
            var query = from flight in Flights
                        where flight.Plane == plane
                        select (flight.FlightDate, flight.Destination);
           
            foreach ( var flight in query)
            {
                Console.WriteLine( "la date de ce vol est :" + flight.FlightDate+ "la destination est :" + flight.Destination);
            }
        }
    }
}
