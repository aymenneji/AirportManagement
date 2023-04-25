using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IserviceFlight
    {
      public IList<DateTime> GetFlightDates(string destination);
        public void ShowFlightDetails(Plane plane);
        public double DurationAverage(string destination);

       public int ProgrammedFlightNumber(DateTime startDate);
       public IEnumerable<Flight> OrderedDurationFlights();//name of class Flight

       public IEnumerable<Traveller> SeniorTravellers(Flight flight);

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
}
