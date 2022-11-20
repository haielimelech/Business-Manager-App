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
    public partial class CustomersForm : Form
    {
        private List<CustomerModel> selectedCustomers = GlobalConfig.Connection.GetCustomer_All();
        private List<CustomerModel> CustomerFound = new List<CustomerModel>();
        public CustomersForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            customerdatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            customerdatagrid.DataSource = null;
            customerdatagrid.DataSource = selectedCustomers;
            customerdatagrid.Columns["Id"].Visible = false;
            customerdatagrid.Columns["FullName"].Visible = false;
            customerdatagrid.Columns["FullDetails"].Visible = false;
            customerdatagrid.Columns["FullDetail2"].Visible = false;

            customerfoundlistbox.DataSource = null;
            customerfoundlistbox.DataSource = CustomerFound;
            customerfoundlistbox.DisplayMember = "FullDetails";

        }
        private void NameText_Enter(object sender, EventArgs e)
        {
            if (findcustomertextbox.Text == "Find Customer by ID")
            {
                findcustomertextbox.Text = "";
                findcustomertextbox.ForeColor = Color.Black;
            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (findcustomertextbox.Text == "")
            {
                findcustomertextbox.Text = "Find Customer by ID";
                findcustomertextbox.ForeColor = Color.Silver;
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            CustomerFound.Clear();
            string result = findcustomertextbox.Text;
            if (findcustomertextbox.Text.Length == 0)
            {
                MessageBox.Show("Please Fill an ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (CustomerModel c in selectedCustomers)
                {
                    if (c.Identity_Number.Equals(result))
                    {
                        flag = 1;
                        CustomerFound.Add(c);
                        WireUpLists();
                        break;


                    }
                }
                if (flag != 1)
                {
                    MessageBox.Show("Customer Not found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            CustomerFound.Clear();
            findcustomertextbox.Text = "";
            WireUpLists();
        }
    }
}
