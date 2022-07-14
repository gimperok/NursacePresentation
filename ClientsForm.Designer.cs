using System.Windows.Forms;

namespace FinalOrder
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.dgv_Clients = new System.Windows.Forms.DataGridView();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.bmt_New_Client = new System.Windows.Forms.Button();
            this.btn_Edit_Client = new System.Windows.Forms.Button();
            this.btn_Del_Client = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Tel = new System.Windows.Forms.Label();
            this.label_Cargo = new System.Windows.Forms.Label();
            this.btn_Select_Client = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.AllowUserToAddRows = false;
            this.dgv_Clients.AllowUserToDeleteRows = false;
            this.dgv_Clients.AllowUserToResizeColumns = false;
            this.dgv_Clients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Clients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Clients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_Clients.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Clients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Clients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Clients.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_Clients.Location = new System.Drawing.Point(33, 73);
            this.dgv_Clients.MultiSelect = false;
            this.dgv_Clients.Name = "dgv_Clients";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Clients.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_Clients.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clients.Size = new System.Drawing.Size(798, 194);
            this.dgv_Clients.TabIndex = 1000;
            this.dgv_Clients.TabStop = false;
            this.dgv_Clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clients_CellClick);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(37, 47);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(33, 20);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Name.Location = new System.Drawing.Point(141, 289);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Surname.Location = new System.Drawing.Point(141, 317);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(100, 20);
            this.txt_Surname.TabIndex = 3;
            // 
            // txt_Country
            // 
            this.txt_Country.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Country.Location = new System.Drawing.Point(141, 345);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 20);
            this.txt_Country.TabIndex = 4;
            // 
            // txt_City
            // 
            this.txt_City.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_City.Location = new System.Drawing.Point(141, 373);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 5;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Tel.Location = new System.Drawing.Point(141, 401);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 20);
            this.txt_Tel.TabIndex = 6;
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Cargo.Location = new System.Drawing.Point(141, 429);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(100, 20);
            this.txt_Cargo.TabIndex = 7;
            // 
            // bmt_New_Client
            // 
            this.bmt_New_Client.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(this.bmt_New_Client, "Add new client");

            this.bmt_New_Client.BackColor = System.Drawing.Color.White;
            this.bmt_New_Client.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmt_New_Client.Image = global::FinalOrder.Properties.Resources.addicon;
            this.bmt_New_Client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bmt_New_Client.Location = new System.Drawing.Point(564, 278);
            this.bmt_New_Client.Name = "bmt_New_Client";
            this.bmt_New_Client.Size = new System.Drawing.Size(81, 29);
            this.bmt_New_Client.TabIndex = 9;
            this.bmt_New_Client.Text = "   New";
            this.bmt_New_Client.UseVisualStyleBackColor = false;
            this.bmt_New_Client.Click += new System.EventHandler(this.bmt_New_Client_Click);
            // 
            // btn_Edit_Client
            // 
            this.btn_Edit_Client.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            t1.SetToolTip(this.btn_Edit_Client, "Edit current client");

            this.btn_Edit_Client.BackColor = System.Drawing.Color.White;
            this.btn_Edit_Client.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Edit_Client.Image = global::FinalOrder.Properties.Resources.editicon;
            this.btn_Edit_Client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit_Client.Location = new System.Drawing.Point(657, 278);
            this.btn_Edit_Client.Name = "btn_Edit_Client";
            this.btn_Edit_Client.Size = new System.Drawing.Size(81, 29);
            this.btn_Edit_Client.TabIndex = 10;
            this.btn_Edit_Client.Text = "   Edit";
            this.btn_Edit_Client.UseVisualStyleBackColor = false;
            this.btn_Edit_Client.Click += new System.EventHandler(this.btn_Edit_Client_Click);
            // 
            // btn_Del_Client
            // 
            this.btn_Del_Client.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            t1.SetToolTip(this.btn_Del_Client, "Remove current client");

            this.btn_Del_Client.BackColor = System.Drawing.Color.White;
            this.btn_Del_Client.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Del_Client.Image = global::FinalOrder.Properties.Resources.delicon;
            this.btn_Del_Client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del_Client.Location = new System.Drawing.Point(750, 278);
            this.btn_Del_Client.Name = "btn_Del_Client";
            this.btn_Del_Client.Size = new System.Drawing.Size(81, 29);
            this.btn_Del_Client.TabIndex = 11;
            this.btn_Del_Client.Text = "  Del";
            this.btn_Del_Client.UseVisualStyleBackColor = false;
            this.btn_Del_Client.Click += new System.EventHandler(this.btn_Del_Client_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Search.Location = new System.Drawing.Point(322, 30);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(220, 20);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(33, 284);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(71, 26);
            this.label_Name.TabIndex = 13;
            this.label_Name.Text = "Name:";
            // 
            // label_Surname
            // 
            this.label_Surname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname.Location = new System.Drawing.Point(33, 313);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(99, 26);
            this.label_Surname.TabIndex = 14;
            this.label_Surname.Text = "Surname:";
            // 
            // label_Country
            // 
            this.label_Country.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Country.Location = new System.Drawing.Point(33, 342);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(92, 26);
            this.label_Country.TabIndex = 15;
            this.label_Country.Text = "Country:";
            // 
            // label_City
            // 
            this.label_City.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_City.Location = new System.Drawing.Point(33, 368);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(55, 26);
            this.label_City.TabIndex = 16;
            this.label_City.Text = "City:";
            // 
            // label_Tel
            // 
            this.label_Tel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Tel.AutoSize = true;
            this.label_Tel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tel.Location = new System.Drawing.Point(33, 397);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(45, 26);
            this.label_Tel.TabIndex = 17;
            this.label_Tel.Text = "Tel:";
            // 
            // label_Cargo
            // 
            this.label_Cargo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Cargo.AutoSize = true;
            this.label_Cargo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Cargo.Location = new System.Drawing.Point(33, 426);
            this.label_Cargo.Name = "label_Cargo";
            this.label_Cargo.Size = new System.Drawing.Size(71, 26);
            this.label_Cargo.TabIndex = 18;
            this.label_Cargo.Text = "Cargo:";
            // 
            // btn_Select_Client
            // 
            this.btn_Select_Client.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            t1.SetToolTip(this.btn_Select_Client, "Select current client");

            this.btn_Select_Client.BackColor = System.Drawing.Color.White;
            this.btn_Select_Client.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Select_Client.Image = global::FinalOrder.Properties.Resources.checkicon;
            this.btn_Select_Client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Select_Client.Location = new System.Drawing.Point(721, 419);
            this.btn_Select_Client.Name = "btn_Select_Client";
            this.btn_Select_Client.Size = new System.Drawing.Size(110, 40);
            this.btn_Select_Client.TabIndex = 8;
            this.btn_Select_Client.Text = "  Check";
            this.btn_Select_Client.UseVisualStyleBackColor = false;
            this.btn_Select_Client.Click += new System.EventHandler(this.btn_Select_Client_Click);
            // 
            // label_Search
            // 
            this.label_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(238, 24);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(77, 26);
            this.label_Search.TabIndex = 19;
            this.label_Search.Text = "Search:";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(864, 471);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.label_Cargo);
            this.Controls.Add(this.label_Tel);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Del_Client);
            this.Controls.Add(this.btn_Edit_Client);
            this.Controls.Add(this.bmt_New_Client);
            this.Controls.Add(this.btn_Select_Client);
            this.Controls.Add(this.txt_Cargo);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.dgv_Clients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 510);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 510);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.Click += new System.EventHandler(this.ClientsForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Clients;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.Button btn_Select_Client;
        private System.Windows.Forms.Button bmt_New_Client;
        private System.Windows.Forms.Button btn_Edit_Client;
        private System.Windows.Forms.Button btn_Del_Client;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Tel;
        private System.Windows.Forms.Label label_Cargo;
        private System.Windows.Forms.Label label_Search;
    }
}