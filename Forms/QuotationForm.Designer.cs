namespace TevelCampersUpdated.Forms
{
    partial class QuotationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quotationlabel = new System.Windows.Forms.Label();
            this.orlabel = new System.Windows.Forms.Label();
            this.searchcustomertextbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.selectcustomersdropdown = new System.Windows.Forms.ComboBox();
            this.depature_date = new System.Windows.Forms.DateTimePicker();
            this.returndate = new System.Windows.Forms.DateTimePicker();
            this.depaturedatelabel = new System.Windows.Forms.Label();
            this.returndatelabel = new System.Windows.Forms.Label();
            this.typelabel = new System.Windows.Forms.Label();
            this.childtenlabel = new System.Windows.Forms.Label();
            this.adultslabel = new System.Windows.Forms.Label();
            this.gearlabel = new System.Windows.Forms.Label();
            this.manualradiobutton = new System.Windows.Forms.RadioButton();
            this.automaticradiobutton = new System.Windows.Forms.RadioButton();
            this.sentmailbutton = new System.Windows.Forms.Button();
            this.SentQuotationbutton = new System.Windows.Forms.Button();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.arrivallocationlabel = new System.Windows.Forms.Label();
            this.depaturelocationlabel = new System.Windows.Forms.Label();
            this.depaturelocationdropdown = new System.Windows.Forms.ComboBox();
            this.arrivallocationdropdown = new System.Windows.Forms.ComboBox();
            this.calculatevalue = new System.Windows.Forms.TextBox();
            this.numberofadultscounter = new System.Windows.Forms.NumericUpDown();
            this.numberofchildrencounter = new System.Windows.Forms.NumericUpDown();
            this.eurolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberofadultscounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberofchildrencounter)).BeginInit();
            this.SuspendLayout();
            // 
            // quotationlabel
            // 
            this.quotationlabel.AutoSize = true;
            this.quotationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.quotationlabel.Location = new System.Drawing.Point(11, 9);
            this.quotationlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quotationlabel.Name = "quotationlabel";
            this.quotationlabel.Size = new System.Drawing.Size(166, 37);
            this.quotationlabel.TabIndex = 1;
            this.quotationlabel.Text = "Quotation:";
            // 
            // orlabel
            // 
            this.orlabel.AutoSize = true;
            this.orlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orlabel.Location = new System.Drawing.Point(226, 107);
            this.orlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orlabel.Name = "orlabel";
            this.orlabel.Size = new System.Drawing.Size(23, 20);
            this.orlabel.TabIndex = 3;
            this.orlabel.Text = "or";
            // 
            // searchcustomertextbox
            // 
            this.searchcustomertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchcustomertextbox.ForeColor = System.Drawing.Color.Silver;
            this.searchcustomertextbox.Location = new System.Drawing.Point(18, 104);
            this.searchcustomertextbox.Name = "searchcustomertextbox";
            this.searchcustomertextbox.Size = new System.Drawing.Size(121, 29);
            this.searchcustomertextbox.TabIndex = 4;
            this.searchcustomertextbox.Text = "Search by ID";
            this.searchcustomertextbox.Enter += new System.EventHandler(this.NameText_Enter);
            // 
            // searchbutton
            // 
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchbutton.Location = new System.Drawing.Point(145, 104);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(76, 29);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // selectcustomersdropdown
            // 
            this.selectcustomersdropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.selectcustomersdropdown.FormattingEnabled = true;
            this.selectcustomersdropdown.Location = new System.Drawing.Point(254, 104);
            this.selectcustomersdropdown.Name = "selectcustomersdropdown";
            this.selectcustomersdropdown.Size = new System.Drawing.Size(515, 28);
            this.selectcustomersdropdown.TabIndex = 6;
            this.selectcustomersdropdown.Text = "Select Customer *";
            // 
            // depature_date
            // 
            this.depature_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.depature_date.CustomFormat = "dd/mm/yyyy";
            this.depature_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.depature_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.depature_date.Location = new System.Drawing.Point(18, 264);
            this.depature_date.Name = "depature_date";
            this.depature_date.Size = new System.Drawing.Size(254, 22);
            this.depature_date.TabIndex = 7;
            this.depature_date.Value = new System.DateTime(2022, 7, 14, 0, 0, 0, 0);
            // 
            // returndate
            // 
            this.returndate.CustomFormat = "dd/mm/yyyy";
            this.returndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.returndate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returndate.Location = new System.Drawing.Point(509, 263);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(260, 22);
            this.returndate.TabIndex = 8;
            this.returndate.Value = new System.DateTime(2022, 7, 14, 0, 0, 0, 0);
            // 
            // depaturedatelabel
            // 
            this.depaturedatelabel.AutoSize = true;
            this.depaturedatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.depaturedatelabel.Location = new System.Drawing.Point(14, 241);
            this.depaturedatelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depaturedatelabel.Name = "depaturedatelabel";
            this.depaturedatelabel.Size = new System.Drawing.Size(125, 20);
            this.depaturedatelabel.TabIndex = 9;
            this.depaturedatelabel.Text = "Depature Date *";
            // 
            // returndatelabel
            // 
            this.returndatelabel.AutoSize = true;
            this.returndatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.returndatelabel.Location = new System.Drawing.Point(505, 240);
            this.returndatelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returndatelabel.Name = "returndatelabel";
            this.returndatelabel.Size = new System.Drawing.Size(107, 20);
            this.returndatelabel.TabIndex = 10;
            this.returndatelabel.Text = "Return Date *";
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.typelabel.Location = new System.Drawing.Point(14, 309);
            this.typelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(53, 20);
            this.typelabel.TabIndex = 11;
            this.typelabel.Text = "Type *";
            // 
            // childtenlabel
            // 
            this.childtenlabel.AutoSize = true;
            this.childtenlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.childtenlabel.Location = new System.Drawing.Point(506, 358);
            this.childtenlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.childtenlabel.Name = "childtenlabel";
            this.childtenlabel.Size = new System.Drawing.Size(112, 15);
            this.childtenlabel.TabIndex = 15;
            this.childtenlabel.Text = "Number of children";
            // 
            // adultslabel
            // 
            this.adultslabel.AutoSize = true;
            this.adultslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.adultslabel.Location = new System.Drawing.Point(15, 361);
            this.adultslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adultslabel.Name = "adultslabel";
            this.adultslabel.Size = new System.Drawing.Size(101, 15);
            this.adultslabel.TabIndex = 14;
            this.adultslabel.Text = "Number of adults";
            // 
            // gearlabel
            // 
            this.gearlabel.AutoSize = true;
            this.gearlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gearlabel.Location = new System.Drawing.Point(14, 383);
            this.gearlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gearlabel.Name = "gearlabel";
            this.gearlabel.Size = new System.Drawing.Size(55, 20);
            this.gearlabel.TabIndex = 16;
            this.gearlabel.Text = "Gear *";
            // 
            // manualradiobutton
            // 
            this.manualradiobutton.AutoSize = true;
            this.manualradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manualradiobutton.Location = new System.Drawing.Point(196, 411);
            this.manualradiobutton.Name = "manualradiobutton";
            this.manualradiobutton.Size = new System.Drawing.Size(69, 20);
            this.manualradiobutton.TabIndex = 17;
            this.manualradiobutton.TabStop = true;
            this.manualradiobutton.Text = "Manual";
            this.manualradiobutton.UseVisualStyleBackColor = true;
            // 
            // automaticradiobutton
            // 
            this.automaticradiobutton.AutoSize = true;
            this.automaticradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.automaticradiobutton.Location = new System.Drawing.Point(18, 411);
            this.automaticradiobutton.Name = "automaticradiobutton";
            this.automaticradiobutton.Size = new System.Drawing.Size(84, 20);
            this.automaticradiobutton.TabIndex = 18;
            this.automaticradiobutton.TabStop = true;
            this.automaticradiobutton.Text = "Automatic";
            this.automaticradiobutton.UseVisualStyleBackColor = true;
            // 
            // sentmailbutton
            // 
            this.sentmailbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sentmailbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentmailbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sentmailbutton.Image = global::TevelCampersUpdated.Properties.Resources.mail;
            this.sentmailbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sentmailbutton.Location = new System.Drawing.Point(509, 496);
            this.sentmailbutton.Margin = new System.Windows.Forms.Padding(2);
            this.sentmailbutton.Name = "sentmailbutton";
            this.sentmailbutton.Size = new System.Drawing.Size(260, 63);
            this.sentmailbutton.TabIndex = 21;
            this.sentmailbutton.Text = "Sent Order";
            this.sentmailbutton.UseVisualStyleBackColor = true;
            this.sentmailbutton.Click += new System.EventHandler(this.sentmailbutton_Click);
            // 
            // SentQuotationbutton
            // 
            this.SentQuotationbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SentQuotationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SentQuotationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SentQuotationbutton.Image = global::TevelCampersUpdated.Properties.Resources.update1;
            this.SentQuotationbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SentQuotationbutton.Location = new System.Drawing.Point(509, 415);
            this.SentQuotationbutton.Margin = new System.Windows.Forms.Padding(2);
            this.SentQuotationbutton.Name = "SentQuotationbutton";
            this.SentQuotationbutton.Size = new System.Drawing.Size(260, 65);
            this.SentQuotationbutton.TabIndex = 20;
            this.SentQuotationbutton.Text = "     Sent Quotation";
            this.SentQuotationbutton.UseVisualStyleBackColor = true;
            this.SentQuotationbutton.Click += new System.EventHandler(this.SentQuotationbutton_Click);
            // 
            // calculatebutton
            // 
            this.calculatebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.calculatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.calculatebutton.Image = global::TevelCampersUpdated.Properties.Resources.transaction;
            this.calculatebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculatebutton.Location = new System.Drawing.Point(18, 468);
            this.calculatebutton.Margin = new System.Windows.Forms.Padding(2);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(247, 63);
            this.calculatebutton.TabIndex = 19;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // arrivallocationlabel
            // 
            this.arrivallocationlabel.AutoSize = true;
            this.arrivallocationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.arrivallocationlabel.Location = new System.Drawing.Point(505, 173);
            this.arrivallocationlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arrivallocationlabel.Name = "arrivallocationlabel";
            this.arrivallocationlabel.Size = new System.Drawing.Size(127, 20);
            this.arrivallocationlabel.TabIndex = 23;
            this.arrivallocationlabel.Text = "Arrival Location *";
            // 
            // depaturelocationlabel
            // 
            this.depaturelocationlabel.AutoSize = true;
            this.depaturelocationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.depaturelocationlabel.Location = new System.Drawing.Point(14, 174);
            this.depaturelocationlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depaturelocationlabel.Name = "depaturelocationlabel";
            this.depaturelocationlabel.Size = new System.Drawing.Size(151, 20);
            this.depaturelocationlabel.TabIndex = 22;
            this.depaturelocationlabel.Text = "Depature Location *";
            // 
            // depaturelocationdropdown
            // 
            this.depaturelocationdropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.depaturelocationdropdown.FormattingEnabled = true;
            this.depaturelocationdropdown.Location = new System.Drawing.Point(18, 198);
            this.depaturelocationdropdown.Name = "depaturelocationdropdown";
            this.depaturelocationdropdown.Size = new System.Drawing.Size(254, 26);
            this.depaturelocationdropdown.TabIndex = 24;
            this.depaturelocationdropdown.Text = "Prague";
            // 
            // arrivallocationdropdown
            // 
            this.arrivallocationdropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.arrivallocationdropdown.FormattingEnabled = true;
            this.arrivallocationdropdown.Location = new System.Drawing.Point(509, 196);
            this.arrivallocationdropdown.Name = "arrivallocationdropdown";
            this.arrivallocationdropdown.Size = new System.Drawing.Size(260, 26);
            this.arrivallocationdropdown.TabIndex = 25;
            this.arrivallocationdropdown.Text = "Prague";
            // 
            // calculatevalue
            // 
            this.calculatevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.calculatevalue.Location = new System.Drawing.Point(18, 535);
            this.calculatevalue.Name = "calculatevalue";
            this.calculatevalue.Size = new System.Drawing.Size(227, 24);
            this.calculatevalue.TabIndex = 26;
            this.calculatevalue.Text = "0";
            // 
            // numberofadultscounter
            // 
            this.numberofadultscounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numberofadultscounter.Location = new System.Drawing.Point(18, 332);
            this.numberofadultscounter.Name = "numberofadultscounter";
            this.numberofadultscounter.Size = new System.Drawing.Size(254, 24);
            this.numberofadultscounter.TabIndex = 27;
            // 
            // numberofchildrencounter
            // 
            this.numberofchildrencounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numberofchildrencounter.Location = new System.Drawing.Point(509, 331);
            this.numberofchildrencounter.Name = "numberofchildrencounter";
            this.numberofchildrencounter.Size = new System.Drawing.Size(260, 24);
            this.numberofchildrencounter.TabIndex = 28;
            // 
            // eurolabel
            // 
            this.eurolabel.AutoSize = true;
            this.eurolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eurolabel.Location = new System.Drawing.Point(245, 535);
            this.eurolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eurolabel.Name = "eurolabel";
            this.eurolabel.Size = new System.Drawing.Size(20, 24);
            this.eurolabel.TabIndex = 29;
            this.eurolabel.Text = "€";
            // 
            // QuotationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 605);
            this.Controls.Add(this.eurolabel);
            this.Controls.Add(this.numberofchildrencounter);
            this.Controls.Add(this.numberofadultscounter);
            this.Controls.Add(this.calculatevalue);
            this.Controls.Add(this.arrivallocationdropdown);
            this.Controls.Add(this.depaturelocationdropdown);
            this.Controls.Add(this.arrivallocationlabel);
            this.Controls.Add(this.depaturelocationlabel);
            this.Controls.Add(this.sentmailbutton);
            this.Controls.Add(this.SentQuotationbutton);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.automaticradiobutton);
            this.Controls.Add(this.manualradiobutton);
            this.Controls.Add(this.gearlabel);
            this.Controls.Add(this.childtenlabel);
            this.Controls.Add(this.adultslabel);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.returndatelabel);
            this.Controls.Add(this.depaturedatelabel);
            this.Controls.Add(this.returndate);
            this.Controls.Add(this.depature_date);
            this.Controls.Add(this.selectcustomersdropdown);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchcustomertextbox);
            this.Controls.Add(this.orlabel);
            this.Controls.Add(this.quotationlabel);
            this.Name = "QuotationForm";
            this.Text = "Quotation";
            this.Leave += new System.EventHandler(this.NameText_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.numberofadultscounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberofchildrencounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quotationlabel;
        private System.Windows.Forms.Label orlabel;
        private System.Windows.Forms.TextBox searchcustomertextbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.ComboBox selectcustomersdropdown;
        private System.Windows.Forms.DateTimePicker depature_date;
        private System.Windows.Forms.DateTimePicker returndate;
        private System.Windows.Forms.Label depaturedatelabel;
        private System.Windows.Forms.Label returndatelabel;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label childtenlabel;
        private System.Windows.Forms.Label adultslabel;
        private System.Windows.Forms.Label gearlabel;
        private System.Windows.Forms.RadioButton manualradiobutton;
        private System.Windows.Forms.RadioButton automaticradiobutton;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Button SentQuotationbutton;
        private System.Windows.Forms.Button sentmailbutton;
        private System.Windows.Forms.Label arrivallocationlabel;
        private System.Windows.Forms.Label depaturelocationlabel;
        private System.Windows.Forms.ComboBox depaturelocationdropdown;
        private System.Windows.Forms.ComboBox arrivallocationdropdown;
        private System.Windows.Forms.TextBox calculatevalue;
        private System.Windows.Forms.NumericUpDown numberofadultscounter;
        private System.Windows.Forms.NumericUpDown numberofchildrencounter;
        private System.Windows.Forms.Label eurolabel;
    }
}