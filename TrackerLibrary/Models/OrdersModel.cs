using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevelCampersUpdated.TrackerLibrary.Models
{
    public class OrdersModel
    {
        public string Customer_Name
        {
            get
            {
                return $"{Customer.FullName}";
            }
        }
        public string Phone_Number
        {
            get
            {
                return $"{Customer.PhoneNumber}";
            }
        }
        public int Id { get; set; }
        public CustomerModel Customer { get; set; } = new CustomerModel();
        public DateTime Depature_Date { get; set; } = new DateTime();
        public DateTime Return_Date { get; set; } = new DateTime();
        public int Overall_Days { get; set; }
        public int NumberOfPeople { get; set; }
        public string Customer_ID
        {
            get
            {
                return $"{Customer.Identity_Number}";
            }
        }
    }
}
