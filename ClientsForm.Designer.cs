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
            this.dgv_Clients = new System.Windows.Forms.DataGridView();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.btn_Select_Client = new System.Windows.Forms.Button();
            this.bmt_New_Client = new System.Windows.Forms.Button();
            this.btn_Edit_Client = new System.Windows.Forms.Button();
            this.btn_Del_Client = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.AllowUserToAddRows = false;
            this.dgv_Clients.AllowUserToDeleteRows = false;
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clients.Location = new System.Drawing.Point(28, 73);
            this.dgv_Clients.Name = "dgv_Clients";
            this.dgv_Clients.ReadOnly = true;
            this.dgv_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clients.Size = new System.Drawing.Size(798, 194);
            this.dgv_Clients.TabIndex = 0;
            this.dgv_Clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clients_CellClick);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(28, 273);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(169, 315);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(169, 350);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(100, 20);
            this.txt_Surname.TabIndex = 3;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(169, 376);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 20);
            this.txt_Country.TabIndex = 4;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(169, 402);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 5;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(169, 437);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 20);
            this.txt_Tel.TabIndex = 6;
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(169, 463);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(100, 20);
            this.txt_Cargo.TabIndex = 7;
            // 
            // btn_Select_Client
            // 
            this.btn_Select_Client.Location = new System.Drawing.Point(433, 364);
            this.btn_Select_Client.Name = "btn_Select_Client";
            this.btn_Select_Client.Size = new System.Drawing.Size(75, 23);
            this.btn_Select_Client.TabIndex = 8;
            this.btn_Select_Client.Text = "Выбрать";
            this.btn_Select_Client.UseVisualStyleBackColor = true;
            this.btn_Select_Client.Click += new System.EventHandler(this.btn_Select_Client_Click);
            // 
            // bmt_New_Client
            // 
            this.bmt_New_Client.Location = new System.Drawing.Point(737, 347);
            this.bmt_New_Client.Name = "bmt_New_Client";
            this.bmt_New_Client.Size = new System.Drawing.Size(75, 23);
            this.bmt_New_Client.TabIndex = 9;
            this.bmt_New_Client.Text = "Новый";
            this.bmt_New_Client.UseVisualStyleBackColor = true;
            this.bmt_New_Client.Click += new System.EventHandler(this.bmt_New_Client_Click);
            // 
            // btn_Edit_Client
            // 
            this.btn_Edit_Client.Location = new System.Drawing.Point(737, 390);
            this.btn_Edit_Client.Name = "btn_Edit_Client";
            this.btn_Edit_Client.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit_Client.TabIndex = 10;
            this.btn_Edit_Client.Text = "Изменить";
            this.btn_Edit_Client.UseVisualStyleBackColor = true;
            this.btn_Edit_Client.Click += new System.EventHandler(this.btn_Edit_Client_Click);
            // 
            // btn_Del_Client
            // 
            this.btn_Del_Client.Location = new System.Drawing.Point(737, 434);
            this.btn_Del_Client.Name = "btn_Del_Client";
            this.btn_Del_Client.Size = new System.Drawing.Size(75, 23);
            this.btn_Del_Client.TabIndex = 11;
            this.btn_Del_Client.Text = "Удалить";
            this.btn_Del_Client.UseVisualStyleBackColor = true;
            this.btn_Del_Client.Click += new System.EventHandler(this.btn_Del_Client_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(265, 30);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(220, 20);
            this.txt_Search.TabIndex = 12;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 504);
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
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
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
    }
}