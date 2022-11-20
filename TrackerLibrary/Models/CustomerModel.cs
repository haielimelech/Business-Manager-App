using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevelCampersUpdated.TrackerLibrary.Models
{
    public class CustomerModel
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Quotation { get; set; }
        public int ActualPrice { get; set; }
        public string Identity_Number { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string FullDetails
        {
            get
            {
                return $"{FirstName}                  {LastName}                 {PhoneNumber}             {Email}              {Quotation}                   {ActualPrice}";
            }
        }
        public string FullDetail2
        {
            get
            {
                return $"{FirstName} |{LastName} |{PhoneNumber} |{Email} |{Identity_Number}";
            }
        }
    }
}
