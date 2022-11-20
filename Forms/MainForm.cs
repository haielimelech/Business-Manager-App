using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace TevelCampersUpdated
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //costructor
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
           buttonclosechildform.Visible = false;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButtom(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                    panelTitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrighthness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SeconderyColor = ThemeColor.ChangeColorBrighthness(color, -0.3);
                    buttonclosechildform.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousbtn in panelMenu.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousbtn.ForeColor = Color.Gainsboro;
                    previousbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                }
            }
        }
        private void OpenChileForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButtom(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;

        }

        private void addCustomerbutton_Click(object sender, EventArgs e)
        {
            OpenChileForm(new Forms.AddCustomerForm(), sender);
        }

        private void quotationbutton_Click(object sender, EventArgs e)
        {
            OpenChileForm(new Forms.QuotationForm(), sender);
        }

        private void customersbutton_Click(object sender, EventArgs e)
        {
            OpenChileForm(new Forms.CustomersForm(), sender);
        }

        private void ordersbutton_Click(object sender, EventArgs e)
        {
            OpenChileForm(new Forms.OrdersForm(), sender); 
        }

        private void statisticbutton_Click(object sender, EventArgs e)
        {
            OpenChileForm(new Forms.StatisticsForm(), sender);
        }

        private void buttonclosechildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitlebar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(51, 51, 76);
            currentButton = null;
            buttonclosechildform.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy HH:mm:ss tt");
            timer1.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timelabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy HH:mm:ss tt");
        }

  
    }
}
