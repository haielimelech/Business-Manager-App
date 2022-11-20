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
    public partial class AddCustomerForm : Form
    {
        private List<CustomerModel> selectedCustomers = GlobalConfig.Connection.GetCustomer_All();
        public AddCustomerForm()
        {
            InitializeComponent();
            WireUpLists();


        }
        private void WireUpLists()
        {
            customerslistbox.DataSource = null;

            customerslistbox.DataSource = selectedCustomers;
            customerslistbox.DisplayMember = "FullName";
        }
        private bool ValidateForm()
        {
            if (firstnametextbox.Text.Length == 0)
            {
                return false;
            }
            if (lastnametextbox.Text.Length == 0)
            {
                return false;
            }
            if (phonenumbertextbox.Text.Length == 0)
            {
                return false;
            }
            if (emailtextbox.Text.Length == 0)
            {
                return false;
            }
            if (idtextbox.Text.Length == 0)
            {
                return false;
            }


            return true;
        }
        private void addcustomerbutton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CustomerModel c = new CustomerModel();
                c.FirstName = firstnametextbox.Text;
                c.LastName = lastnametextbox.Text;
                c.PhoneNumber = phonenumbertextbox.Text;
                c.Email = emailtextbox.Text;
                c.Quotation = 0;
                c.ActualPrice = 0;
                c.Identity_Number = idtextbox.Text;

                c = GlobalConfig.Connection.CreateCustomer(c);

                selectedCustomers.Add(c);
                WireUpLists();

                firstnametextbox.Text = "";
                lastnametextbox.Text = "";
                phonenumbertextbox.Text = "";
                emailtextbox.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the filds.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removecustomerbutton_Click(object sender, EventArgs e)
        {
            CustomerModel c = (CustomerModel)customerslistbox.SelectedItem;

            if (c != null)
            {
                if (MessageBox.Show("Delete this Customer?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    GlobalConfig.Connection.DeleteCustomer(c);
                    selectedCustomers.Remove(c);
                    WireUpLists();
                }
            }
            WireUpLists();

        }
    }
}
