namespace FinalOrder
{
    partial class NewClient
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Tel = new System.Windows.Forms.Label();
            this.label_Cargo = new System.Windows.Forms.Label();
            this.btn_AddNewCL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(156, 95);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(156, 124);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(100, 20);
            this.txt_Surname.TabIndex = 1;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(156, 163);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 20);
            this.txt_Country.TabIndex = 2;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(156, 199);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 3;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(156, 242);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 20);
            this.txt_Tel.TabIndex = 4;
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(156, 273);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(100, 20);
            this.txt_Cargo.TabIndex = 5;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(99, 95);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Name";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(91, 131);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(49, 13);
            this.label_Surname.TabIndex = 7;
            this.label_Surname.Text = "Surname";
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Location = new System.Drawing.Point(97, 170);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(43, 13);
            this.label_Country.TabIndex = 8;
            this.label_Country.Text = "Country";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(116, 206);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(24, 13);
            this.label_City.TabIndex = 9;
            this.label_City.Text = "City";
            // 
            // label_Tel
            // 
            this.label_Tel.AutoSize = true;
            this.label_Tel.Location = new System.Drawing.Point(118, 242);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(22, 13);
            this.label_Tel.TabIndex = 10;
            this.label_Tel.Text = "Tel";
            // 
            // label_Cargo
            // 
            this.label_Cargo.AutoSize = true;
            this.label_Cargo.Location = new System.Drawing.Point(105, 273);
            this.label_Cargo.Name = "label_Cargo";
            this.label_Cargo.Size = new System.Drawing.Size(35, 13);
            this.label_Cargo.TabIndex = 11;
            this.label_Cargo.Text = "Cargo";
            // 
            // btn_AddNewCL
            // 
            this.btn_AddNewCL.Location = new System.Drawing.Point(102, 377);
            this.btn_AddNewCL.Name = "btn_AddNewCL";
            this.btn_AddNewCL.Size = new System.Drawing.Size(120, 23);
            this.btn_AddNewCL.TabIndex = 12;
            this.btn_AddNewCL.Text = "Add new client";
            this.btn_AddNewCL.UseVisualStyleBackColor = true;
            this.btn_AddNewCL.Click += new System.EventHandler(this.btn_AddNewCL_Click);
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 478);
            this.Controls.Add(this.btn_AddNewCL);
            this.Controls.Add(this.label_Cargo);
            this.Controls.Add(this.label_Tel);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.txt_Cargo);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_Name);
            this.Name = "NewClient";
            this.Text = "NewClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Tel;
        private System.Windows.Forms.Label label_Cargo;
        private System.Windows.Forms.Button btn_AddNewCL;
    }
}