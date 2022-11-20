using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TevelCampersUpdated.TrackerLibrary.Models;

namespace TevelCampersUpdated.TrackerLibrary.DataAccess
{
    public interface IDataConnector
    {
        CustomerModel CreateCustomer(CustomerModel model);
        OrdersModel CreateOrder(OrdersModel model);
        List<CustomerModel> GetCustomer_All();
        List<OrdersModel> GetOrders_All();
        void DeleteCustomer(CustomerModel model);
        void UpdateQuotation(int result, int id);
        void UpdateActualPrice(int result, int id);
    }
}
