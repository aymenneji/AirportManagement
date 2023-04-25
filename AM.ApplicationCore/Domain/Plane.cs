using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManuFactureDate { get; set; }
        [Range(1,int.MaxValue)]
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public IList<Flight> Flights { get; set; }
    }
}
