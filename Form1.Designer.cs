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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(106, 55);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1124, 376);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txt_Kod
            // 
            this.txt_Kod.Location = new System.Drawing.Point(12, 489);
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(100, 20);
            this.txt_Kod.TabIndex = 1;
            // 
            // txt_Leather
            // 
            this.txt_Leather.Location = new System.Drawing.Point(146, 489);
            this.txt_Leather.Name = "txt_Leather";
            this.txt_Leather.Size = new System.Drawing.Size(100, 20);
            this.txt_Leather.TabIndex = 2;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(275, 489);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 20);
            this.txt_Color.TabIndex = 3;
            // 
            // txt_35
            // 
            this.txt_35.Location = new System.Drawing.Point(436, 489);
            this.txt_35.Name = "txt_35";
            this.txt_35.Size = new System.Drawing.Size(30, 20);
            this.txt_35.TabIndex = 4;
            this.txt_35.TextChanged += new System.EventHandler(this.txt_35_TextChanged);
            // 
            // txt_36
            // 
            this.txt_36.Location = new System.Drawing.Point(504, 489);
            this.txt_36.Name = "txt_36";
            this.txt_36.Size = new System.Drawing.Size(30, 20);
            this.txt_36.TabIndex = 5;
            this.txt_36.TextChanged += new System.EventHandler(this.txt_36_TextChanged);
            // 
            // txt_37
            // 
            this.txt_37.Location = new System.Drawing.Point(569, 489);
            this.txt_37.Name = "txt_37";
            this.txt_37.Size = new System.Drawing.Size(30, 20);
            this.txt_37.TabIndex = 6;
            this.txt_37.TextChanged += new System.EventHandler(this.txt_37_TextChanged);
            // 
            // txt_38
            // 
            this.txt_38.Location = new System.Drawing.Point(624, 489);
            this.txt_38.Name = "txt_38";
            this.txt_38.Size = new System.Drawing.Size(30, 20);
            this.txt_38.TabIndex = 7;
            this.txt_38.TextChanged += new System.EventHandler(this.txt_38_TextChanged);
            // 
            // txt_39
            // 
            this.txt_39.Location = new System.Drawing.Point(684, 489);
            this.txt_39.Name = "txt_39";
            this.txt_39.Size = new System.Drawing.Size(30, 20);
            this.txt_39.TabIndex = 8;
            this.txt_39.TextChanged += new System.EventHandler(this.txt_39_TextChanged);
            // 
            // txt_40
            // 
            this.txt_40.Location = new System.Drawing.Point(740, 489);
            this.txt_40.Name = "txt_40";
            this.txt_40.Size = new System.Drawing.Size(30, 20);
            this.txt_40.TabIndex = 9;
            this.txt_40.TextChanged += new System.EventHandler(this.txt_40_TextChanged);
            // 
            // txt_41
            // 
            this.txt_41.Location = new System.Drawing.Point(792, 489);
            this.txt_41.Name = "txt_41";
            this.txt_41.Size = new System.Drawing.Size(30, 20);
            this.txt_41.TabIndex = 10;
            this.txt_41.TextChanged += new System.EventHandler(this.txt_41_TextChanged);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(942, 489);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(40, 20);
            this.txt_Price.TabIndex = 11;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(1073, 489);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(207, 20);
            this.txt_Note.TabIndex = 13;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(907, 622);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1008, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_41);
            this.Controls.Add(this.txt_40);
            this.Controls.Add(this.txt_39);
            this.Controls.Add(this.txt_38);
            this.Controls.Add(this.txt_37);
            this.Controls.Add(this.txt_36);
            this.Controls.Add(this.txt_35);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.txt_Leather);
            this.Controls.Add(this.txt_Kod);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

