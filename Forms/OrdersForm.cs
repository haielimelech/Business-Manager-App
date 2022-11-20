using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TevelCampersUpdated.TrackerLibrary;
using TevelCampersUpdated.TrackerLibrary.Models;

namespace TevelCampersUpdated.Forms
{
    public partial class OrdersForm : Form
    {
        private List<OrdersModel> OverallOrders = GlobalConfig.Connection.GetOrders_All();
        private List<OrdersModel> LiveOrders = new List<OrdersModel>();
        public OrdersForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        public void UpdateLiveOrders()
        {
            foreach (OrdersModel order in OverallOrders)
            {
                if (DateTime.Now >= order.Depature_Date.Date && DateTime.Now <= order.Return_Date.Date)
                {
                    LiveOrders.Add(order);
                }
            }
        }
        private void WireUpLists()
        {
            UpdateLiveOrders();
            overallordersdatagrid.DataSource = null;
            overallordersdatagrid.DataSource = OverallOrders;
            overallordersdatagrid.Columns["Id"].Visible = false;
            overallordersdatagrid.Columns["Customer"].Visible = false;

            liveordersdatagrid.DataSource = null;
            liveordersdatagrid.DataSource = LiveOrders;
            liveordersdatagrid.Columns["Id"].Visible = false;
            liveordersdatagrid.Columns["Customer"].Visible = false;
        }

        private void sortbutton_Click(object sender, EventArgs e)
        {
            OverallOrders = OverallOrders.OrderBy(x => x.Depature_Date).ToList();
            LiveOrders.Clear();
            WireUpLists();
        }
    }
}
