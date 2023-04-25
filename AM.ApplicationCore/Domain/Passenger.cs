using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain { 
    public class Passenger
    {
        //ID, id, PassengerId, PassengerID
        // Public int Id { get; set; }

        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }


        public FullName FullName { get; set; }

        [Display(Name ="Date of Birth")]
        //[DisplayName="Date Of Birth"]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        //[EmailAdress]
        public string EmailAdress { get; set; }

        public int Id { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string? ToString()
        {
            return "id" + Id + "FirstName" + FullName.FirstName + "LastName" + FullName.LastName;
        }
        public bool checkProfile(string lastname, string firstname)
        {
            return FullName.FirstName.Equals(firstname) && FullName.LastName.Equals(lastname);
        }

        public bool checkProfile(string lastname, string firstname, string email)
        {
            //return checkProfile(lastname, firstname) && EmailAdresse.Equals(email);
            return FullName.FirstName.Equals(firstname) && FullName.LastName.Equals(lastname) && EmailAdress.Equals(email);
        }
        public bool Login(string lastname, string firstname, string email = null)
        {
            if (email != null)
                return FullName.FirstName.Equals(firstname) && FullName.LastName.Equals(lastname) && EmailAdress.Equals(email);
            
                return FullName.FirstName.Equals(firstname) && FullName.LastName.Equals(lastname);
        }

        public virtual void PassengerType ()
        {
            Console.WriteLine("I  am passenger");
        }
        
    }
    
}
