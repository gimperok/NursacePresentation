namespace FinalOrder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.txt_Leather = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_35 = new System.Windows.Forms.TextBox();
            this.txt_36 = new System.Windows.Forms.TextBox();
            this.txt_37 = new System.Windows.Forms.TextBox();
            this.txt_38 = new System.Windows.Forms.TextBox();
            this.txt_39 = new System.Windows.Forms.TextBox();
            this.txt_40 = new System.Windows.Forms.TextBox();
            this.txt_41 = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_Kol = new System.Windows.Forms.Label();
            this.label_TPrice = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label_NomOrd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Client = new System.Windows.Forms.Button();
            this.label_Cargo = new System.Windows.Forms.Label();
            this.label_Tel = new System.Windows.Forms.Label();
            this.label_Country_City = new System.Windows.Forms.Label();
            this.label_Name_Sur = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv.CausesValidation = false;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.Black;
            this.dgv.Location = new System.Drawing.Point(60, 125);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.ShowCellErrors = false;
            this.dgv.ShowCellToolTips = false;
            this.dgv.ShowEditingIcon = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(1280, 411);
            this.dgv.TabIndex = 100;
            this.dgv.TabStop = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txt_Kod
            // 
            this.txt_Kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Kod.Location = new System.Drawing.Point(59, 19);
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(100, 20);
            this.txt_Kod.TabIndex = 1;
            // 
            // txt_Leather
            // 
            this.txt_Leather.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Leather.Location = new System.Drawing.Point(193, 19);
            this.txt_Leather.Name = "txt_Leather";
            this.txt_Leather.Size = new System.Drawing.Size(100, 20);
            this.txt_Leather.TabIndex = 2;
            // 
            // txt_Color
            // 
            this.txt_Color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Color.Location = new System.Drawing.Point(322, 19);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 20);
            this.txt_Color.TabIndex = 3;
            // 
            // txt_35
            // 
            this.txt_35.Location = new System.Drawing.Point(493, 19);
            this.txt_35.Name = "txt_35";
            this.txt_35.Size = new System.Drawing.Size(30, 20);
            this.txt_35.TabIndex = 4;
            this.txt_35.TextChanged += new System.EventHandler(this.txt_35_TextChanged);
            // 
            // txt_36
            // 
            this.txt_36.Location = new System.Drawing.Point(541, 19);
            this.txt_36.Name = "txt_36";
            this.txt_36.Size = new System.Drawing.Size(30, 20);
            this.txt_36.TabIndex = 5;
            this.txt_36.TextChanged += new System.EventHandler(this.txt_36_TextChanged);
            // 
            // txt_37
            // 
            this.txt_37.Location = new System.Drawing.Point(606, 19);
            this.txt_37.Name = "txt_37";
            this.txt_37.Size = new System.Drawing.Size(30, 20);
            this.txt_37.TabIndex = 6;
            this.txt_37.TextChanged += new System.EventHandler(this.txt_37_TextChanged);
            // 
            // txt_38
            // 
            this.txt_38.Location = new System.Drawing.Point(661, 19);
            this.txt_38.Name = "txt_38";
            this.txt_38.Size = new System.Drawing.Size(30, 20);
            this.txt_38.TabIndex = 7;
            this.txt_38.TextChanged += new System.EventHandler(this.txt_38_TextChanged);
            // 
            // txt_39
            // 
            this.txt_39.Location = new System.Drawing.Point(721, 19);
            this.txt_39.Name = "txt_39";
            this.txt_39.Size = new System.Drawing.Size(30, 20);
            this.txt_39.TabIndex = 8;
            this.txt_39.TextChanged += new System.EventHandler(this.txt_39_TextChanged);
            // 
            // txt_40
            // 
            this.txt_40.Location = new System.Drawing.Point(777, 19);
            this.txt_40.Name = "txt_40";
            this.txt_40.Size = new System.Drawing.Size(30, 20);
            this.txt_40.TabIndex = 9;
            this.txt_40.TextChanged += new System.EventHandler(this.txt_40_TextChanged);
            // 
            // txt_41
            // 
            this.txt_41.Location = new System.Drawing.Point(829, 19);
            this.txt_41.Name = "txt_41";
            this.txt_41.Size = new System.Drawing.Size(30, 20);
            this.txt_41.TabIndex = 10;
            this.txt_41.TextChanged += new System.EventHandler(this.txt_41_TextChanged);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(933, 19);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(60, 20);
            this.txt_Price.TabIndex = 11;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(1043, 19);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(254, 20);
            this.txt_Note.TabIndex = 13;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(148, 30);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 26);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label_Kol
            // 
            this.label_Kol.AutoSize = true;
            this.label_Kol.Location = new System.Drawing.Point(905, 26);
            this.label_Kol.Name = "label_Kol";
            this.label_Kol.Size = new System.Drawing.Size(22, 13);
            this.label_Kol.TabIndex = 15;
            this.label_Kol.Text = "Kol";
            // 
            // label_TPrice
            // 
            this.label_TPrice.AutoSize = true;
            this.label_TPrice.Location = new System.Drawing.Point(999, 22);
            this.label_TPrice.Name = "label_TPrice";
            this.label_TPrice.Size = new System.Drawing.Size(38, 13);
            this.label_TPrice.TabIndex = 16;
            this.label_TPrice.Text = "TPrice";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(252, 30);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 26);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(59, 58);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(49, 20);
            this.txt_Id.TabIndex = 18;
            this.txt_Id.Visible = false;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(26, 25);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(36, 13);
            this.label_Date.TabIndex = 19;
            this.label_Date.Text = "Date: ";
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(378, 30);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 26);
            this.btn_Del.TabIndex = 20;
            this.btn_Del.Text = "Del";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // label_NomOrd
            // 
            this.label_NomOrd.AutoSize = true;
            this.label_NomOrd.Location = new System.Drawing.Point(26, 55);
            this.label_NomOrd.Name = "label_NomOrd";
            this.label_NomOrd.Size = new System.Drawing.Size(73, 13);
            this.label_NomOrd.TabIndex = 21;
            this.label_NomOrd.Text = "OrderNumber:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Client);
            this.groupBox1.Controls.Add(this.label_Cargo);
            this.groupBox1.Controls.Add(this.label_Tel);
            this.groupBox1.Controls.Add(this.label_Country_City);
            this.groupBox1.Controls.Add(this.label_Name_Sur);
            this.groupBox1.Location = new System.Drawing.Point(60, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 92);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // btn_Client
            // 
            this.btn_Client.Location = new System.Drawing.Point(290, 25);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(75, 23);
            this.btn_Client.TabIndex = 31;
            this.btn_Client.Text = "Clinet";
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // label_Cargo
            // 
            this.label_Cargo.AutoSize = true;
            this.label_Cargo.Location = new System.Drawing.Point(171, 59);
            this.label_Cargo.Name = "label_Cargo";
            this.label_Cargo.Size = new System.Drawing.Size(38, 13);
            this.label_Cargo.TabIndex = 30;
            this.label_Cargo.Text = "Cargo:";
            // 
            // label_Tel
            // 
            this.label_Tel.AutoSize = true;
            this.label_Tel.Location = new System.Drawing.Point(16, 54);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(25, 13);
            this.label_Tel.TabIndex = 29;
            this.label_Tel.Text = "Tel:";
            // 
            // label_Country_City
            // 
            this.label_Country_City.AutoSize = true;
            this.label_Country_City.Location = new System.Drawing.Point(171, 25);
            this.label_Country_City.Name = "label_Country_City";
            this.label_Country_City.Size = new System.Drawing.Size(46, 13);
            this.label_Country_City.TabIndex = 28;
            this.label_Country_City.Text = "Country:";
            // 
            // label_Name_Sur
            // 
            this.label_Name_Sur.AutoSize = true;
            this.label_Name_Sur.Location = new System.Drawing.Point(16, 25);
            this.label_Name_Sur.Name = "label_Name_Sur";
            this.label_Name_Sur.Size = new System.Drawing.Size(38, 13);
            this.label_Name_Sur.TabIndex = 27;
            this.label_Name_Sur.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Date);
            this.groupBox2.Controls.Add(this.label_NomOrd);
            this.groupBox2.Location = new System.Drawing.Point(838, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 92);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_Leather);
            this.groupBox3.Controls.Add(this.txt_Kod);
            this.groupBox3.Controls.Add(this.txt_Color);
            this.groupBox3.Controls.Add(this.txt_35);
            this.groupBox3.Controls.Add(this.txt_Id);
            this.groupBox3.Controls.Add(this.txt_36);
            this.groupBox3.Controls.Add(this.txt_37);
            this.groupBox3.Controls.Add(this.label_TPrice);
            this.groupBox3.Controls.Add(this.txt_38);
            this.groupBox3.Controls.Add(this.label_Kol);
            this.groupBox3.Controls.Add(this.txt_39);
            this.groupBox3.Controls.Add(this.txt_40);
            this.groupBox3.Controls.Add(this.txt_Note);
            this.groupBox3.Controls.Add(this.txt_41);
            this.groupBox3.Controls.Add(this.txt_Price);
            this.groupBox3.Location = new System.Drawing.Point(28, 539);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1303, 112);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1002, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Залог: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Общая сумма заказа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Количство моделей:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Add);
            this.groupBox4.Controls.Add(this.btn_Edit);
            this.groupBox4.Controls.Add(this.btn_Del);
            this.groupBox4.Location = new System.Drawing.Point(350, 657);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 76);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(1071, 689);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(75, 23);
            this.btn_Excel.TabIndex = 105;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1387, 745);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.TextBox txt_Leather;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_35;
        private System.Windows.Forms.TextBox txt_36;
        private System.Windows.Forms.TextBox txt_37;
        private System.Windows.Forms.TextBox txt_38;
        private System.Windows.Forms.TextBox txt_39;
        private System.Windows.Forms.TextBox txt_40;
        private System.Windows.Forms.TextBox txt_41;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label_Kol;
        private System.Windows.Forms.Label label_TPrice;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label label_NomOrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Client;
        protected internal System.Windows.Forms.Label label_Tel;
        protected internal System.Windows.Forms.Label label_Country_City;
        protected internal System.Windows.Forms.Label label_Name_Sur;
        protected internal System.Windows.Forms.Label label_Cargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Excel;
    }
}

