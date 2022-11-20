using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TevelCampersUpdated.TrackerLibrary.Models;

namespace TevelCampersUpdated.TrackerLibrary.DataAccess
{
    public class TextConnector :IDataConnector
    {
        private const string CustomerFile = "CustomerFile.txt";
        private const string OverAllOrdersFile = "OverAllOrderFile.txt";
        public OrdersModel CreateOrder(OrdersModel model)
        {
            List<OrdersModel> orders = OverAllOrdersFile.FullFillPath().LoadFile().ConvertToOrdersModel(CustomerFile);
            int currentId = 1;

            if (orders.Count > 0)
            {
                currentId = orders.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            orders.Add(model);

            orders.SaveToOrderFile(OverAllOrdersFile);

            return model;
        }
        public CustomerModel CreateCustomer(CustomerModel model)
        {
            List<CustomerModel> customer = CustomerFile.FullFillPath().LoadFile().ConvertToCustomerModels();
            int currentId = 1;

            if (customer.Count > 0)
            {
                currentId = customer.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            customer.Add(model);

            customer.SaveToCustomerFile(CustomerFile);

            return model;
        }
        public void UpdateQuotation(int result, int id)
        {
            List<CustomerModel> customers = CustomerFile.FullFillPath().LoadFile().ConvertToCustomerModels();
            foreach (CustomerModel c in customers)
            {
                if (c.Id == id)
                {
                    c.Quotation = result;
                    break;
                }
            }
            customers.SaveToCustomerFile(CustomerFile);
        }

        public void DeleteCustomer(CustomerModel model)
        {
            int uniq = model.Id;
            List<CustomerModel> customer = CustomerFile.FullFillPath().LoadFile().ConvertToCustomerModels();
            foreach (CustomerModel item in customer)
            {
                if (item.Id == uniq)
                {
                    customer.Remove(item);
                    customer.SaveToCustomerFile(CustomerFile);
                    break;
                }
            }
        }

        public List<CustomerModel> GetCustomer_All()
        {
            return CustomerFile.FullFillPath().LoadFile().ConvertToCustomerModels();
        }
        public List<OrdersModel> GetOrders_All()
        {
            return OverAllOrdersFile.FullFillPath().LoadFile().ConvertToOrdersModel(CustomerFile);
        }

        public void UpdateActualPrice(int result, int id)
        {
            List<CustomerModel> customers = CustomerFile.FullFillPath().LoadFile().ConvertToCustomerModels();
            foreach (CustomerModel c in customers)
            {
                if (c.Id == id)
                {
                    c.ActualPrice = result;
                    break;
                }
            }
            customers.SaveToCustomerFile(CustomerFile);
        }
    }
}
