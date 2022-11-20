using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TevelCampersUpdated.TrackerLibrary;
using TevelCampersUpdated.TrackerLibrary.Models;

namespace TevelCampersUpdated.Forms
{
    public partial class QuotationForm : Form
    {
        private List<CustomerModel> selectedCustomers = GlobalConfig.Connection.GetCustomer_All();
        private CustomerModel CustomerFound = new CustomerModel();
        private int SumDays = 0;
        public QuotationForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            selectcustomersdropdown.DataSource = null;
            selectcustomersdropdown.DataSource = selectedCustomers;
            selectcustomersdropdown.DisplayMember = "FullDetail2";

            selectcustomersdropdown.SelectedItem = CustomerFound;
        }
        private void searchbutton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string result = searchcustomertextbox.Text;
            if (searchcustomertextbox.Text.Length == 0)
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
                        CustomerFound = c;
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
        private bool ValidateForm()
        {
            if (depaturelocationdropdown.Text.Length == 0)
            {
                return false;
            }
            if (arrivallocationdropdown.Text.Length == 0)
            {
                return false;
            }
            if (manualradiobutton.Checked == false && automaticradiobutton.Checked == false)
            {
                return false;
            }
            return true;
        }
        private void calculatebutton_Click(object sender, EventArgs e)
        {
            decimal Flight_sum = 0;
            int Rental_sum = 0;
            decimal OverAllPrice = 0;
            if (ValidateForm())
            {
                Rental_sum = Rental_Calculator();
                Flight_sum = OverallCalculate();
                CustomerFound.Quotation = (int)Flight_sum;
                OverAllPrice = Rental_sum + Flight_sum;

                calculatevalue.Text = OverAllPrice.ToString();
            }
            else
            {
                MessageBox.Show("You need to fill in all of the filds.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal OverallCalculate()
        {
            int Flight = 400;
            int My_Profit = 150;
            decimal adults = numberofadultscounter.Value;
            decimal children = numberofchildrencounter.Value;

            return (adults + children) * (Flight + My_Profit);
        }
        public int Rental_Calculator()
        {
            int Sum = 0, ending_month;
            SumDays = 0;
            if (automaticradiobutton.Checked == true)
            {
                if (depature_date.Value.Month == returndate.Value.Month)
                {
                    for (int i = depature_date.Value.Day; i <= returndate.Value.Day; i++)
                    {
                        Sum += automatic_rental_per_day(depature_date.Value.Month, i);
                        SumDays++;
                    }
                }
                else
                {
                    ending_month = Month_End(depature_date.Value.Month);
                    for (int i = depature_date.Value.Day; i <= ending_month; i++)
                    {
                        Sum += automatic_rental_per_day(depature_date.Value.Month, i);
                        SumDays++;
                    }
                    for (int j = 1; j <= returndate.Value.Day; j++)
                    {
                        Sum += automatic_rental_per_day(returndate.Value.Month, j);
                        SumDays++;
                    }

                }
            }
            else
            {
                if (depature_date.Value.Month == returndate.Value.Month)
                {
                    for (int i = depature_date.Value.Day; i <= returndate.Value.Day; i++)
                    {
                        Sum += manual_rental_per_day(depature_date.Value.Month, i);
                        SumDays++;
                    }
                }
                else
                {
                    ending_month = Month_End(depature_date.Value.Month);
                    for (int i = depature_date.Value.Day; i <= ending_month; i++)
                    {
                        Sum += manual_rental_per_day(depature_date.Value.Month, i);
                        SumDays++;
                    }
                    for (int j = 1; j <= returndate.Value.Day; j++)
                    {
                        Sum += manual_rental_per_day(returndate.Value.Month, j);
                        SumDays++;
                    }

                }
            }
            return Sum;
        }
        int manual_rental_per_day(int month, int day)
        {
            if ((month >= 7 && month <= 12) || (month >= 2 && month <= 5))
            {
                switch (month)
                {
                    case 2:
                        return 90;
                    case 3:
                        return 90;
                    case 4:
                        return 110;
                    case 5:
                        return 115;
                    case 7:
                        return 145;
                    case 8:
                        return 135;
                    case 9:
                        return 125;
                    case 10:
                        return 110;
                    case 11:
                        return 90;
                    case 12:
                        return 110;
                    default:
                        return 0;
                }
            }
            else if (month == 1)
            {
                if (day <= 12)
                {
                    return 110;
                }
                else
                {
                    return 90;
                }
            }
            else if (month == 6)
            {
                if (day <= 20)
                {
                    return 125;
                }
                else
                {
                    return 135;
                }
            }
            else
            {
                MessageBox.Show("InValid Month!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        int automatic_rental_per_day(int month, int day)
        {
            if ((month >= 7 && month <= 12) || (month >= 2 && month <= 5))
            {
                switch (month)
                {
                    case 2:
                        return 105;
                    case 3:
                        return 105;
                    case 4:
                        return 125;
                    case 5:
                        return 130;
                    case 7:
                        return 165;
                    case 8:
                        return 150;
                    case 9:
                        return 140;
                    case 10:
                        return 125;
                    case 11:
                        return 105;
                    case 12:
                        return 125;
                    default:
                        return 0;
                }
            }
            else if (month == 1)
            {
                if (day <= 12)
                {
                    return 125;
                }
                else
                {
                    return 105;
                }
            }
            else if (month == 6)
            {
                if (day <= 20)
                {
                    return 140;
                }
                else
                {
                    return 150;
                }
            }
            else
            {
                MessageBox.Show("InValid Month!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        int Month_End(int selected_month)
        {
            /* local variable definition */
            int month = selected_month;
            switch (month)
            {
                case 1:
                    return 31;
                case 2:
                    return 28;
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31; ;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;
                default:
                    MessageBox.Show("InValid Month!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
            }
        }

        private void SentQuotationbutton_Click(object sender, EventArgs e)
        {
            int result = int.Parse(calculatevalue.Text);
            if (result != 0)
            {
                CustomerModel customer = new CustomerModel();
                customer = (CustomerModel)selectcustomersdropdown.SelectedItem;
                GlobalConfig.Connection.UpdateQuotation(result, customer.Id);
                decimal total_passangers = numberofadultscounter.Value + numberofchildrencounter.Value;
                string fromMail = "hai842@gmail.com";
                string fromPassword = "kdrxdncnvmmmoprg";
                string toMail = "haielimelech1@gmail.com";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Tevel Campers:Quotation ";
                message.To.Add(new MailAddress(toMail));

                message.Body = "<html>" + "<body> " + "<p> " +
                                                     "<h1>" + "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;" + "<u>" + "Quotation Customer:&nbsp;" + customer.Identity_Number + "</u>" + "</h1>" +
                                                     "<br>" + "<h2>" + "<u>" + ":Trip Details" + "</u>" + "</h2>" +
                                                     "<br>" + "<strong>" + "Full Name:&nbsp; &nbsp; &nbsp;" + "</strong>" + customer.FirstName + " " + customer.LastName +
                                                     "<br>" + "<strong>" + "Depature Location:&nbsp; &nbsp; &nbsp;" + "</strong>" + "Prague" + //TODO - make a locationsModel
                                                     "<br>" + "<strong>" + "Arrival Location:&nbsp;&nbsp;&nbsp;" + "</strong>" + "Prague" +
                                                     "<br>" + "<strong>" + "Depature Date:&nbsp; &nbsp;" + "</strong>" + depature_date.Value.ToString("dd-MM-yyyy") +
                                                     "<br>" + "<strong>" + "Return Date:&nbsp; &nbsp;" + "</strong>" + returndate.Value.ToString("dd-MM-yyyy") +
                                                     "<br>" + "<strong>" + "Overall Days:&nbsp; &nbsp;" + "</strong>" + SumDays.ToString() +
                                                     "<br>" + "<strong>" + "Total Number Of Adults:&nbsp; &nbsp;&nbsp;" + "</strong>" + numberofadultscounter.Value.ToString() +
                                                     "<br>" + "<strong>" + "Total Number Of Children:&nbsp; &nbsp;&nbsp;" + "</strong>" + numberofchildrencounter.Value.ToString() +
                                                     "<br>" + "<strong>" + "€" + "Price:&nbsp; &nbsp; &nbsp;" + "</strong>" + calculatevalue.Text.ToString() +
                                                     "<br>" +
                                                     "<br>" + "<em>" + "Sincerely,  " + "</em>" +
                                                     "<br>" + "<em>" + "© 2022 Tevel campers" + "</em>" +
                                                     "<br>" + "<em>" + "052-9882864" + "</em>" +
                                                     "<br>" + "TevelCampers@gmail.com" +
                                                     "<br>" + "<a href =https://tevel-campers.co.il/" + " Tevel Campers Official Site " + "</ a >" +

                                                      "</p> " +
                                        "</body>" +
                             "</html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };
                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Mail has Sent Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.ToString(), "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                WireUpLists();
            }
            else
            {
                MessageBox.Show("Please Calculate a Quotation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sentmailbutton_Click(object sender, EventArgs e)
        {
            int result = int.Parse(calculatevalue.Text);
            if (result != 0)
            {
                //Take Customer From selectedDropDown
                CustomerModel customer = new CustomerModel();
                customer = (CustomerModel)selectcustomersdropdown.SelectedItem;
                //Make a OrderModel with the selected Customer
                OrdersModel t = new OrdersModel();
                t.Customer = customer;
                t.Depature_Date = depature_date.Value;
                t.Return_Date = returndate.Value;
                t.Overall_Days = SumDays;
                t.NumberOfPeople = (int)numberofadultscounter.Value + (int)numberofchildrencounter.Value;
                GlobalConfig.Connection.CreateOrder(t);

                GlobalConfig.Connection.UpdateActualPrice(result, customer.Id);
                decimal total_passangers = numberofadultscounter.Value + numberofchildrencounter.Value;
                string fromMail = "hai842@gmail.com";
                string fromPassword = "kdrxdncnvmmmoprg";
                string toMail = "haielimelech1@gmail.com";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Tevel Campers:Quotation ";
                message.To.Add(new MailAddress(toMail));

                message.Body = "<html>" + "<body> " + "<p> " +
                                                     "<h1>" + "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;" + "<u>" + "Order Customer:&nbsp;" + customer.Identity_Number + "</u>" + "</h1>" +
                                                     "<br>" + "<h2>" + "<u>" + ":Trip Details" + "</u>" + "</h2>" +
                                                     "<br>" + "<strong>" + "Full Name:&nbsp; &nbsp; &nbsp;" + "</strong>" + customer.FirstName + " " + customer.LastName +
                                                     "<br>" + "<strong>" + "Depature Location:&nbsp; &nbsp; &nbsp;" + "</strong>" + "Prague" + //TODO - make a locationsModel
                                                     "<br>" + "<strong>" + "Arrival Location:&nbsp;&nbsp;&nbsp;" + "</strong>" + "Prague" +
                                                     "<br>" + "<strong>" + "Depature Date:&nbsp; &nbsp;" + "</strong>" + depature_date.Value.ToString("dd-MM-yyyy") +
                                                     "<br>" + "<strong>" + "Return Date:&nbsp; &nbsp;" + "</strong>" + returndate.Value.ToString("dd-MM-yyyy") +
                                                     "<br>" + "<strong>" + "Overall Days:&nbsp; &nbsp;" + "</strong>" + SumDays.ToString() +
                                                     "<br>" + "<strong>" + "Total Number Of Adults:&nbsp; &nbsp;&nbsp;" + "</strong>" + numberofadultscounter.Value.ToString() +
                                                     "<br>" + "<strong>" + "Total Number Of Children:&nbsp; &nbsp;&nbsp;" + "</strong>" + numberofchildrencounter.Value.ToString() +
                                                     "<br>" + "<strong>" + "€" + "Price:&nbsp; &nbsp; &nbsp;" + "</strong>" + calculatevalue.Text.ToString() +
                                                     "<br>" +
                                                     "<br>" + "<em>" + "Sincerely,  " + "</em>" +
                                                     "<br>" + "<em>" + "© 2022 Tevel campers" + "</em>" +
                                                     "<br>" + "<em>" + "052-9882864" + "</em>" +
                                                     "<br>" + "TevelCampers@gmail.com" +
                                                     "<br>" + "<a href =https://tevel-campers.co.il/" + " Tevel Campers Official Site " + "</ a >" +

                                                      "</p> " +
                                        "</body>" +
                             "</html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };
                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Mail has Sent Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.ToString(), "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                WireUpLists();
            }
            else
            {
                MessageBox.Show("Please Calculate a Quotation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NameText_Enter(object sender, EventArgs e)
        {
            if(searchcustomertextbox.Text == "Search by ID")
            {
                searchcustomertextbox.Text = "";
                searchcustomertextbox.ForeColor = Color.Black;
            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (searchcustomertextbox.Text == "")
            {
                searchcustomertextbox.Text = "Search by ID";
                searchcustomertextbox.ForeColor = Color.Silver;
            }
        }
    }
}
