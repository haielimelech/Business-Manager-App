namespace TevelCampersUpdated.Forms
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.earningspermonthpanel = new System.Windows.Forms.Panel();
            this.earningsmonthvaluelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.permonthlabel = new System.Windows.Forms.Label();
            this.earningspermonthlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.earningyearvaluelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.peryearlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expensesvaluelabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Expensespermonthlabel = new System.Windows.Forms.Label();
            this.Expenseslabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.processuntillprofitslabel = new System.Windows.Forms.Label();
            this.untillprofitsprogressbar = new CircularProgressBar.CircularProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Yearlychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.orderspermonthlabel = new System.Windows.Forms.Label();
            this.earningspermonthpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yearlychart)).BeginInit();
            this.SuspendLayout();
            // 
            // earningspermonthpanel
            // 
            this.earningspermonthpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.earningspermonthpanel.Controls.Add(this.earningsmonthvaluelabel);
            this.earningspermonthpanel.Controls.Add(this.pictureBox1);
            this.earningspermonthpanel.Controls.Add(this.permonthlabel);
            this.earningspermonthpanel.Controls.Add(this.earningspermonthlabel);
            this.earningspermonthpanel.Location = new System.Drawing.Point(42, 49);
            this.earningspermonthpanel.Name = "earningspermonthpanel";
            this.earningspermonthpanel.Size = new System.Drawing.Size(241, 148);
            this.earningspermonthpanel.TabIndex = 0;
            // 
            // earningsmonthvaluelabel
            // 
            this.earningsmonthvaluelabel.AutoSize = true;
            this.earningsmonthvaluelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.earningsmonthvaluelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.earningsmonthvaluelabel.Location = new System.Drawing.Point(37, 58);
            this.earningsmonthvaluelabel.Name = "earningsmonthvaluelabel";
            this.earningsmonthvaluelabel.Size = new System.Drawing.Size(36, 37);
            this.earningsmonthvaluelabel.TabIndex = 3;
            this.earningsmonthvaluelabel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TevelCampersUpdated.Properties.Resources.icons8_money_bag_70;
            this.pictureBox1.Location = new System.Drawing.Point(160, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 79);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // permonthlabel
            // 
            this.permonthlabel.AutoSize = true;
            this.permonthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.permonthlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.permonthlabel.Location = new System.Drawing.Point(6, 110);
            this.permonthlabel.Name = "permonthlabel";
            this.permonthlabel.Size = new System.Drawing.Size(67, 16);
            this.permonthlabel.TabIndex = 1;
            this.permonthlabel.Text = "Per Month";
            // 
            // earningspermonthlabel
            // 
            this.earningspermonthlabel.AutoSize = true;
            this.earningspermonthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.earningspermonthlabel.ForeColor = System.Drawing.Color.White;
            this.earningspermonthlabel.Location = new System.Drawing.Point(3, 11);
            this.earningspermonthlabel.Name = "earningspermonthlabel";
            this.earningspermonthlabel.Size = new System.Drawing.Size(130, 33);
            this.earningspermonthlabel.TabIndex = 0;
            this.earningspermonthlabel.Text = "Earnings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.earningyearvaluelabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.peryearlabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(339, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 148);
            this.panel1.TabIndex = 1;
            // 
            // earningyearvaluelabel
            // 
            this.earningyearvaluelabel.AutoSize = true;
            this.earningyearvaluelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.earningyearvaluelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.earningyearvaluelabel.Location = new System.Drawing.Point(30, 58);
            this.earningyearvaluelabel.Name = "earningyearvaluelabel";
            this.earningyearvaluelabel.Size = new System.Drawing.Size(36, 37);
            this.earningyearvaluelabel.TabIndex = 4;
            this.earningyearvaluelabel.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TevelCampersUpdated.Properties.Resources.icons8_money_bag_70;
            this.pictureBox2.Location = new System.Drawing.Point(160, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 79);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // peryearlabel
            // 
            this.peryearlabel.AutoSize = true;
            this.peryearlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.peryearlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.peryearlabel.Location = new System.Drawing.Point(6, 110);
            this.peryearlabel.Name = "peryearlabel";
            this.peryearlabel.Size = new System.Drawing.Size(60, 16);
            this.peryearlabel.TabIndex = 2;
            this.peryearlabel.Text = "Per Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Earnings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.expensesvaluelabel);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.Expensespermonthlabel);
            this.panel2.Controls.Add(this.Expenseslabel);
            this.panel2.Location = new System.Drawing.Point(651, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 148);
            this.panel2.TabIndex = 2;
            // 
            // expensesvaluelabel
            // 
            this.expensesvaluelabel.AutoSize = true;
            this.expensesvaluelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.expensesvaluelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.expensesvaluelabel.Location = new System.Drawing.Point(37, 58);
            this.expensesvaluelabel.Name = "expensesvaluelabel";
            this.expensesvaluelabel.Size = new System.Drawing.Size(36, 37);
            this.expensesvaluelabel.TabIndex = 5;
            this.expensesvaluelabel.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TevelCampersUpdated.Properties.Resources.icons8_money_circulation_70;
            this.pictureBox3.Location = new System.Drawing.Point(160, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 79);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Expensespermonthlabel
            // 
            this.Expensespermonthlabel.AutoSize = true;
            this.Expensespermonthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Expensespermonthlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Expensespermonthlabel.Location = new System.Drawing.Point(6, 110);
            this.Expensespermonthlabel.Name = "Expensespermonthlabel";
            this.Expensespermonthlabel.Size = new System.Drawing.Size(67, 16);
            this.Expensespermonthlabel.TabIndex = 3;
            this.Expensespermonthlabel.Text = "Per Month";
            // 
            // Expenseslabel
            // 
            this.Expenseslabel.AutoSize = true;
            this.Expenseslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Expenseslabel.ForeColor = System.Drawing.Color.White;
            this.Expenseslabel.Location = new System.Drawing.Point(3, 11);
            this.Expenseslabel.Name = "Expenseslabel";
            this.Expenseslabel.Size = new System.Drawing.Size(143, 33);
            this.Expenseslabel.TabIndex = 0;
            this.Expenseslabel.Text = "Expenses";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.processuntillprofitslabel);
            this.panel3.Controls.Add(this.untillprofitsprogressbar);
            this.panel3.Location = new System.Drawing.Point(42, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 308);
            this.panel3.TabIndex = 3;
            // 
            // processuntillprofitslabel
            // 
            this.processuntillprofitslabel.AutoSize = true;
            this.processuntillprofitslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.processuntillprofitslabel.ForeColor = System.Drawing.Color.White;
            this.processuntillprofitslabel.Location = new System.Drawing.Point(3, 6);
            this.processuntillprofitslabel.Name = "processuntillprofitslabel";
            this.processuntillprofitslabel.Size = new System.Drawing.Size(286, 33);
            this.processuntillprofitslabel.TabIndex = 1;
            this.processuntillprofitslabel.Text = "Process Untill Profits";
            // 
            // untillprofitsprogressbar
            // 
            this.untillprofitsprogressbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.untillprofitsprogressbar.AnimationSpeed = 500;
            this.untillprofitsprogressbar.BackColor = System.Drawing.Color.Transparent;
            this.untillprofitsprogressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untillprofitsprogressbar.ForeColor = System.Drawing.Color.White;
            this.untillprofitsprogressbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.untillprofitsprogressbar.InnerMargin = 2;
            this.untillprofitsprogressbar.InnerWidth = -1;
            this.untillprofitsprogressbar.Location = new System.Drawing.Point(23, 42);
            this.untillprofitsprogressbar.MarqueeAnimationSpeed = 2000;
            this.untillprofitsprogressbar.Name = "untillprofitsprogressbar";
            this.untillprofitsprogressbar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.untillprofitsprogressbar.OuterMargin = -25;
            this.untillprofitsprogressbar.OuterWidth = 26;
            this.untillprofitsprogressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.untillprofitsprogressbar.ProgressWidth = 10;
            this.untillprofitsprogressbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.untillprofitsprogressbar.Size = new System.Drawing.Size(266, 254);
            this.untillprofitsprogressbar.StartAngle = 270;
            this.untillprofitsprogressbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.untillprofitsprogressbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.untillprofitsprogressbar.SubscriptText = "";
            this.untillprofitsprogressbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.untillprofitsprogressbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.untillprofitsprogressbar.SuperscriptText = "";
            this.untillprofitsprogressbar.TabIndex = 0;
            this.untillprofitsprogressbar.Text = "57";
            this.untillprofitsprogressbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.untillprofitsprogressbar.Value = 57;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.Yearlychart);
            this.panel4.Controls.Add(this.orderspermonthlabel);
            this.panel4.Location = new System.Drawing.Point(423, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(487, 308);
            this.panel4.TabIndex = 4;
            // 
            // Yearlychart
            // 
            this.Yearlychart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Yearlychart.BorderSkin.BackColor = System.Drawing.Color.White;
            this.Yearlychart.BorderSkin.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.Yearlychart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Yearlychart.Legends.Add(legend3);
            this.Yearlychart.Location = new System.Drawing.Point(0, 42);
            this.Yearlychart.Name = "Yearlychart";
            series3.ChartArea = "ChartArea1";
            series3.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Yearly";
            this.Yearlychart.Series.Add(series3);
            this.Yearlychart.Size = new System.Drawing.Size(484, 263);
            this.Yearlychart.TabIndex = 3;
            this.Yearlychart.Text = "orderspermonthchart";
            // 
            // orderspermonthlabel
            // 
            this.orderspermonthlabel.AutoSize = true;
            this.orderspermonthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orderspermonthlabel.ForeColor = System.Drawing.Color.White;
            this.orderspermonthlabel.Location = new System.Drawing.Point(3, 6);
            this.orderspermonthlabel.Name = "orderspermonthlabel";
            this.orderspermonthlabel.Size = new System.Drawing.Size(230, 33);
            this.orderspermonthlabel.TabIndex = 2;
            this.orderspermonthlabel.Text = "Orders Per Moth";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(944, 612);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.earningspermonthpanel);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.earningspermonthpanel.ResumeLayout(false);
            this.earningspermonthpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yearlychart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel earningspermonthpanel;
        private System.Windows.Forms.Label earningspermonthlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Expenseslabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label permonthlabel;
        private System.Windows.Forms.Label peryearlabel;
        private System.Windows.Forms.Label Expensespermonthlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label earningsmonthvaluelabel;
        private System.Windows.Forms.Label earningyearvaluelabel;
        private System.Windows.Forms.Label expensesvaluelabel;
        private System.Windows.Forms.Label processuntillprofitslabel;
        private CircularProgressBar.CircularProgressBar untillprofitsprogressbar;
        private System.Windows.Forms.DataVisualization.Charting.Chart Yearlychart;
        private System.Windows.Forms.Label orderspermonthlabel;
    }
}