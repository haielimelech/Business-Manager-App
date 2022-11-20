using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TevelCampersUpdated.TrackerLibrary.Models;

namespace TevelCampersUpdated.TrackerLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFillPath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["FilePath"]}\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (File.Exists(file) == false) //if the file not exist
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        public static List<OrdersModel> ConvertToOrdersModel(this List<string> lines, string CustomerFileName)
        {
            List<OrdersModel> output = new List<OrdersModel>();
            List<CustomerModel> customers = CustomerFileName.FullFillPath().LoadFile().ConvertToCustomerModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                OrdersModel order = new OrdersModel();
                order.Id = int.Parse(cols[0]);

                string customerid = cols[1];

                order.Customer = customers.Where(x => x.Id == int.Parse(customerid)).First();

                order.Depature_Date = DateTime.Parse(cols[2]);
                order.Return_Date = DateTime.Parse(cols[3]);
                order.Overall_Days = int.Parse(cols[4]);
                order.NumberOfPeople = int.Parse(cols[5]);

                output.Add(order);
            }

            return output;
        }
        public static void SaveToOrderFile(this List<OrdersModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (OrdersModel t in models)
            {
                lines.Add($"{t.Id},{t.Customer.Id},{t.Depature_Date.Date.ToString()},{t.Return_Date.Date.ToString()},{t.Overall_Days},{t.NumberOfPeople}");
            }
            File.WriteAllLines(fileName.FullFillPath(), lines);
        }
        public static List<CustomerModel> ConvertToCustomerModels(this List<string> lines)
        {
            List<CustomerModel> output = new List<CustomerModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                CustomerModel p = new CustomerModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.PhoneNumber = cols[3];
                p.Email = cols[4];
                p.Quotation = int.Parse(cols[5]);
                p.ActualPrice = int.Parse(cols[6]);
                p.Identity_Number = cols[7];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToCustomerFile(this List<CustomerModel> models, string FileName)
        {
            List<string> lines = new List<string>();
            foreach (CustomerModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.PhoneNumber},{p.Email},{p.Quotation},{p.ActualPrice},{p.Identity_Number}");
            }
            File.WriteAllLines(FileName.FullFillPath(), lines);
        }

    }
}
