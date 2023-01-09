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
    
    public partial class StatisticsForm : Form
    {
        private List<OrdersModel> OverallOrders = GlobalConfig.Connection.GetOrders_All();
        public int MySalary = 1800;
        public int Media = 2000;
        public int Adv = 2500;
        public int OverAllExpenses;
        public int EearningsPerMonth = 0;
        public int EarningsPerYear = 0;
        public int SumUntillProfit = 75000;
        public decimal untillProfitProgress = 0;
        
        public StatisticsForm()
        {
            InitializeComponent();
            WireUpData();
        }
        private void WireUpData()
        {   //expenses section
            OverAllExpenses = MySalary + Media + Adv;
            expensesvaluelabel.Text = OverAllExpenses.ToString() + "₪";

            //earnings per month section
            foreach (OrdersModel order in OverallOrders)
            {
                if(order.Depature_Date.Month.ToString()==DateTime.Now.Month.ToString())
                {
                    EearningsPerMonth += order.Customer.ActualPrice;
                }
            }
            earningsmonthvaluelabel.Text = EearningsPerMonth.ToString() + "₪";

            //earnings per Year section
            foreach (OrdersModel order in OverallOrders)
            {
                if (order.Depature_Date.Year.ToString() == DateTime.Now.Year.ToString())
                {
                    if(order.Depature_Date <= DateTime.Now)
                    {
                        EarningsPerYear += order.Customer.ActualPrice;
                    }

                }
            }
            earningyearvaluelabel.Text = EarningsPerYear.ToString() + "₪";
            //progressbarSection
            if (EarningsPerYear>=75000)
            {
                untillprofitsprogressbar.Value = 100;
                untillprofitsprogressbar.Text = untillprofitsprogressbar.Value.ToString() + "%";
            }
            else
            {
                untillProfitProgress = decimal.Divide(EarningsPerYear, SumUntillProfit) * 100;
                untillprofitsprogressbar.Value = (int)untillProfitProgress;
                untillprofitsprogressbar.Text = untillprofitsprogressbar.Value.ToString() + "%";
            }
            //Graphbar section
            //count by array
            int[] OrderPerMonth = new int[12];
            foreach (OrdersModel order in OverallOrders)
            {
                OrderPerMonth[order.Depature_Date.Month - 1]++;
            }
            Yearlychart.Series["Yearly"].Points.AddXY("January", OrderPerMonth[0]);
            Yearlychart.Series["Yearly"].Points.AddXY("February ", OrderPerMonth[1]);
            Yearlychart.Series["Yearly"].Points.AddXY("March", OrderPerMonth[2]);
            Yearlychart.Series["Yearly"].Points.AddXY("April ", OrderPerMonth[3]);
            Yearlychart.Series["Yearly"].Points.AddXY("May", OrderPerMonth[4]);
            Yearlychart.Series["Yearly"].Points.AddXY("June", OrderPerMonth[5]);
            Yearlychart.Series["Yearly"].Points.AddXY("July", OrderPerMonth[6]);
            Yearlychart.Series["Yearly"].Points.AddXY("August", OrderPerMonth[7]);
            Yearlychart.Series["Yearly"].Points.AddXY("September", OrderPerMonth[8]);
            Yearlychart.Series["Yearly"].Points.AddXY("October", OrderPerMonth[9]);
            Yearlychart.Series["Yearly"].Points.AddXY("November", OrderPerMonth[10]);
            Yearlychart.Series["Yearly"].Points.AddXY("December", OrderPerMonth[11]);
        }

    }
}
