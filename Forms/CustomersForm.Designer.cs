namespace TevelCampersUpdated.Forms
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchbutton = new System.Windows.Forms.Button();
            this.findcustomertextbox = new System.Windows.Forms.TextBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.customerfoundlistbox = new System.Windows.Forms.ListBox();
            this.customerdatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchbutton.Location = new System.Drawing.Point(390, 12);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(87, 29);
            this.searchbutton.TabIndex = 7;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // findcustomertextbox
            // 
            this.findcustomertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.findcustomertextbox.ForeColor = System.Drawing.Color.Silver;
            this.findcustomertextbox.Location = new System.Drawing.Point(52, 12);
            this.findcustomertextbox.Name = "findcustomertextbox";
            this.findcustomertextbox.Size = new System.Drawing.Size(332, 29);
            this.findcustomertextbox.TabIndex = 6;
            this.findcustomertextbox.Text = "Find Customer by ID";
            this.findcustomertextbox.Enter += new System.EventHandler(this.NameText_Enter);
            this.findcustomertextbox.Leave += new System.EventHandler(this.NameText_Leave);
            // 
            // clearbutton
            // 
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearbutton.Location = new System.Drawing.Point(483, 12);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(90, 29);
            this.clearbutton.TabIndex = 8;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // customerfoundlistbox
            // 
            this.customerfoundlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.customerfoundlistbox.FormattingEnabled = true;
            this.customerfoundlistbox.ItemHeight = 20;
            this.customerfoundlistbox.Location = new System.Drawing.Point(52, 47);
            this.customerfoundlistbox.Name = "customerfoundlistbox";
            this.customerfoundlistbox.Size = new System.Drawing.Size(773, 44);
            this.customerfoundlistbox.TabIndex = 9;
            // 
            // customerdatagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.customerdatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerdatagrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerdatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerdatagrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerdatagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerdatagrid.GridColor = System.Drawing.Color.White;
            this.customerdatagrid.Location = new System.Drawing.Point(0, 102);
            this.customerdatagrid.Name = "customerdatagrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerdatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customerdatagrid.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerdatagrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.customerdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerdatagrid.Size = new System.Drawing.Size(864, 509);
            this.customerdatagrid.TabIndex = 10;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.customerdatagrid);
            this.Controls.Add(this.customerfoundlistbox);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.findcustomertextbox);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.customerdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox findcustomertextbox;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.ListBox customerfoundlistbox;
        private System.Windows.Forms.DataGridView customerdatagrid;
    }
}