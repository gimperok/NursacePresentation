using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label_Kol = new System.Windows.Forms.Label();
            this.label_TPrice = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_NomOrd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Cargo = new System.Windows.Forms.Label();
            this.label_Tel = new System.Windows.Forms.Label();
            this.label_Country_City = new System.Windows.Forms.Label();
            this.label_Name_Sur = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Note = new System.Windows.Forms.Label();
            this.label_TPrice_Label = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Kol_Label = new System.Windows.Forms.Label();
            this.label_41 = new System.Windows.Forms.Label();
            this.label_40 = new System.Windows.Forms.Label();
            this.label_39 = new System.Windows.Forms.Label();
            this.label_38 = new System.Windows.Forms.Label();
            this.label_37 = new System.Windows.Forms.Label();
            this.label_36 = new System.Windows.Forms.Label();
            this.label_35 = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.label_Leather = new System.Windows.Forms.Label();
            this.label_Kod = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.CausesValidation = false;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.Black;
            this.dgv.Location = new System.Drawing.Point(28, 149);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.ShowCellErrors = false;
            this.dgv.ShowCellToolTips = false;
            this.dgv.ShowEditingIcon = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(1264, 373);
            this.dgv.TabIndex = 100;
            this.dgv.TabStop = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txt_Kod
            // 
            this.txt_Kod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Kod.Location = new System.Drawing.Point(10, 45);
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(100, 20);
            this.txt_Kod.TabIndex = 1;
            // 
            // txt_Leather
            // 
            this.txt_Leather.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Leather.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Leather.Location = new System.Drawing.Point(144, 45);
            this.txt_Leather.Name = "txt_Leather";
            this.txt_Leather.Size = new System.Drawing.Size(100, 20);
            this.txt_Leather.TabIndex = 2;
            // 
            // txt_Color
            // 
            this.txt_Color.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Color.Location = new System.Drawing.Point(273, 45);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 20);
            this.txt_Color.TabIndex = 3;
            // 
            // txt_35
            // 
            this.txt_35.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_35.Location = new System.Drawing.Point(444, 45);
            this.txt_35.Margin = new System.Windows.Forms.Padding(5);
            this.txt_35.Name = "txt_35";
            this.txt_35.Size = new System.Drawing.Size(30, 20);
            this.txt_35.TabIndex = 4;
            this.txt_35.TextChanged += new System.EventHandler(this.txt_35_TextChanged);
            // 
            // txt_36
            // 
            this.txt_36.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_36.Location = new System.Drawing.Point(500, 45);
            this.txt_36.Margin = new System.Windows.Forms.Padding(5);
            this.txt_36.Name = "txt_36";
            this.txt_36.Size = new System.Drawing.Size(30, 20);
            this.txt_36.TabIndex = 5;
            this.txt_36.TextChanged += new System.EventHandler(this.txt_36_TextChanged);
            // 
            // txt_37
            // 
            this.txt_37.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_37.Location = new System.Drawing.Point(556, 45);
            this.txt_37.Name = "txt_37";
            this.txt_37.Size = new System.Drawing.Size(30, 20);
            this.txt_37.TabIndex = 6;
            this.txt_37.TextChanged += new System.EventHandler(this.txt_37_TextChanged);
            // 
            // txt_38
            // 
            this.txt_38.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_38.Location = new System.Drawing.Point(612, 45);
            this.txt_38.Name = "txt_38";
            this.txt_38.Size = new System.Drawing.Size(30, 20);
            this.txt_38.TabIndex = 7;
            this.txt_38.TextChanged += new System.EventHandler(this.txt_38_TextChanged);
            // 
            // txt_39
            // 
            this.txt_39.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_39.Location = new System.Drawing.Point(668, 45);
            this.txt_39.Name = "txt_39";
            this.txt_39.Size = new System.Drawing.Size(30, 20);
            this.txt_39.TabIndex = 8;
            this.txt_39.TextChanged += new System.EventHandler(this.txt_39_TextChanged);
            // 
            // txt_40
            // 
            this.txt_40.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_40.Location = new System.Drawing.Point(724, 45);
            this.txt_40.Name = "txt_40";
            this.txt_40.Size = new System.Drawing.Size(30, 20);
            this.txt_40.TabIndex = 9;
            this.txt_40.TextChanged += new System.EventHandler(this.txt_40_TextChanged);
            // 
            // txt_41
            // 
            this.txt_41.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_41.Location = new System.Drawing.Point(780, 45);
            this.txt_41.Name = "txt_41";
            this.txt_41.Size = new System.Drawing.Size(30, 20);
            this.txt_41.TabIndex = 10;
            this.txt_41.TextChanged += new System.EventHandler(this.txt_41_TextChanged);
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Price.Location = new System.Drawing.Point(876, 45);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(55, 20);
            this.txt_Price.TabIndex = 11;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Note
            // 
            this.txt_Note.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Note.Location = new System.Drawing.Point(1026, 45);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(222, 20);
            this.txt_Note.TabIndex = 13;
            // 
            // label_Kol
            // 
            this.label_Kol.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Kol.AutoSize = true;
            this.label_Kol.Location = new System.Drawing.Point(838, 48);
            this.label_Kol.Name = "label_Kol";
            this.label_Kol.Size = new System.Drawing.Size(13, 13);
            this.label_Kol.TabIndex = 15;
            this.label_Kol.Text = "—";
            // 
            // label_TPrice
            // 
            this.label_TPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_TPrice.AutoSize = true;
            this.label_TPrice.Location = new System.Drawing.Point(960, 50);
            this.label_TPrice.Name = "label_TPrice";
            this.label_TPrice.Size = new System.Drawing.Size(28, 13);
            this.label_TPrice.TabIndex = 16;
            this.label_TPrice.Text = "     —";
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Id.Location = new System.Drawing.Point(21, 19);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(18, 20);
            this.txt_Id.TabIndex = 18;
            this.txt_Id.TabStop = false;
            this.txt_Id.Visible = false;
            // 
            // label_Date
            // 
            this.label_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Date.Location = new System.Drawing.Point(26, 16);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(53, 22);
            this.label_Date.TabIndex = 120;
            this.label_Date.Text = "Date: ";
            // 
            // label_NomOrd
            // 
            this.label_NomOrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NomOrd.AutoSize = true;
            this.label_NomOrd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NomOrd.Location = new System.Drawing.Point(26, 55);
            this.label_NomOrd.Name = "label_NomOrd";
            this.label_NomOrd.Size = new System.Drawing.Size(122, 22);
            this.label_NomOrd.TabIndex = 121;
            this.label_NomOrd.Text = "OrderNumber:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Cargo);
            this.groupBox1.Controls.Add(this.label_Tel);
            this.groupBox1.Controls.Add(this.label_Country_City);
            this.groupBox1.Controls.Add(this.label_Name_Sur);
            this.groupBox1.Location = new System.Drawing.Point(31, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 83);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.t.SetToolTip(this.groupBox1, "Customer\'s data");
            // 
            // label_Cargo
            // 
            this.label_Cargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Cargo.AutoSize = true;
            this.label_Cargo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Cargo.Location = new System.Drawing.Point(217, 55);
            this.label_Cargo.Name = "label_Cargo";
            this.label_Cargo.Size = new System.Drawing.Size(59, 22);
            this.label_Cargo.TabIndex = 30;
            this.label_Cargo.Text = "Cargo:";
            // 
            // label_Tel
            // 
            this.label_Tel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tel.AutoSize = true;
            this.label_Tel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tel.Location = new System.Drawing.Point(16, 55);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(37, 22);
            this.label_Tel.TabIndex = 29;
            this.label_Tel.Text = "Tel:";
            // 
            // label_Country_City
            // 
            this.label_Country_City.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Country_City.AutoSize = true;
            this.label_Country_City.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Country_City.Location = new System.Drawing.Point(217, 16);
            this.label_Country_City.Name = "label_Country_City";
            this.label_Country_City.Size = new System.Drawing.Size(77, 22);
            this.label_Country_City.TabIndex = 28;
            this.label_Country_City.Text = "Country:";
            // 
            // label_Name_Sur
            // 
            this.label_Name_Sur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name_Sur.AutoSize = true;
            this.label_Name_Sur.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name_Sur.Location = new System.Drawing.Point(15, 16);
            this.label_Name_Sur.Name = "label_Name_Sur";
            this.label_Name_Sur.Size = new System.Drawing.Size(58, 22);
            this.label_Name_Sur.TabIndex = 27;
            this.label_Name_Sur.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label_Date);
            this.groupBox2.Controls.Add(this.label_NomOrd);
            this.groupBox2.Location = new System.Drawing.Point(891, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 83);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.t.SetToolTip(this.groupBox2, "Order\'s data");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.label_Note);
            this.groupBox3.Controls.Add(this.label_TPrice_Label);
            this.groupBox3.Controls.Add(this.label_Price);
            this.groupBox3.Controls.Add(this.label_Kol_Label);
            this.groupBox3.Controls.Add(this.label_41);
            this.groupBox3.Controls.Add(this.label_40);
            this.groupBox3.Controls.Add(this.label_39);
            this.groupBox3.Controls.Add(this.label_38);
            this.groupBox3.Controls.Add(this.label_37);
            this.groupBox3.Controls.Add(this.label_36);
            this.groupBox3.Controls.Add(this.label_35);
            this.groupBox3.Controls.Add(this.label_Color);
            this.groupBox3.Controls.Add(this.label_Leather);
            this.groupBox3.Controls.Add(this.label_Kod);
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
            this.groupBox3.Location = new System.Drawing.Point(33, 542);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1254, 93);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            // 
            // label_Note
            // 
            this.label_Note.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Note.AutoSize = true;
            this.label_Note.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Note.Location = new System.Drawing.Point(1101, 21);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(46, 22);
            this.label_Note.TabIndex = 120;
            this.label_Note.Text = "Note";
            this.label_Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TPrice_Label
            // 
            this.label_TPrice_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_TPrice_Label.AutoSize = true;
            this.label_TPrice_Label.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TPrice_Label.Location = new System.Drawing.Point(957, 21);
            this.label_TPrice_Label.Name = "label_TPrice_Label";
            this.label_TPrice_Label.Size = new System.Drawing.Size(45, 22);
            this.label_TPrice_Label.TabIndex = 119;
            this.label_TPrice_Label.Text = "Sum";
            this.label_TPrice_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Price
            // 
            this.label_Price.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.Location = new System.Drawing.Point(880, 21);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(47, 22);
            this.label_Price.TabIndex = 118;
            this.label_Price.Text = "Price";
            this.label_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Kol_Label
            // 
            this.label_Kol_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Kol_Label.AutoSize = true;
            this.label_Kol_Label.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Kol_Label.Location = new System.Drawing.Point(821, 21);
            this.label_Kol_Label.Name = "label_Kol_Label";
            this.label_Kol_Label.Size = new System.Drawing.Size(49, 22);
            this.label_Kol_Label.TabIndex = 117;
            this.label_Kol_Label.Text = "Total";
            this.label_Kol_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_41
            // 
            this.label_41.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_41.AutoSize = true;
            this.label_41.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_41.Location = new System.Drawing.Point(782, 21);
            this.label_41.Name = "label_41";
            this.label_41.Size = new System.Drawing.Size(26, 22);
            this.label_41.TabIndex = 116;
            this.label_41.Text = "41";
            this.label_41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_40
            // 
            this.label_40.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_40.AutoSize = true;
            this.label_40.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_40.Location = new System.Drawing.Point(726, 21);
            this.label_40.Name = "label_40";
            this.label_40.Size = new System.Drawing.Size(26, 22);
            this.label_40.TabIndex = 115;
            this.label_40.Text = "40";
            this.label_40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_39
            // 
            this.label_39.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_39.AutoSize = true;
            this.label_39.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_39.Location = new System.Drawing.Point(670, 21);
            this.label_39.Name = "label_39";
            this.label_39.Size = new System.Drawing.Size(26, 22);
            this.label_39.TabIndex = 114;
            this.label_39.Text = "39";
            this.label_39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_38
            // 
            this.label_38.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_38.AutoSize = true;
            this.label_38.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_38.Location = new System.Drawing.Point(614, 21);
            this.label_38.Name = "label_38";
            this.label_38.Size = new System.Drawing.Size(26, 22);
            this.label_38.TabIndex = 113;
            this.label_38.Text = "38";
            this.label_38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_37
            // 
            this.label_37.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_37.AutoSize = true;
            this.label_37.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_37.Location = new System.Drawing.Point(558, 21);
            this.label_37.Name = "label_37";
            this.label_37.Size = new System.Drawing.Size(26, 22);
            this.label_37.TabIndex = 112;
            this.label_37.Text = "37";
            this.label_37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_36
            // 
            this.label_36.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_36.AutoSize = true;
            this.label_36.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_36.Location = new System.Drawing.Point(502, 21);
            this.label_36.Name = "label_36";
            this.label_36.Size = new System.Drawing.Size(26, 22);
            this.label_36.TabIndex = 111;
            this.label_36.Text = "36";
            this.label_36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_35
            // 
            this.label_35.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_35.AutoSize = true;
            this.label_35.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_35.Location = new System.Drawing.Point(446, 21);
            this.label_35.Name = "label_35";
            this.label_35.Size = new System.Drawing.Size(26, 22);
            this.label_35.TabIndex = 110;
            this.label_35.Text = "35";
            this.label_35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Color
            // 
            this.label_Color.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Color.AutoSize = true;
            this.label_Color.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Color.Location = new System.Drawing.Point(298, 21);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(52, 22);
            this.label_Color.TabIndex = 109;
            this.label_Color.Text = "Color";
            this.label_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Leather
            // 
            this.label_Leather.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Leather.AutoSize = true;
            this.label_Leather.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Leather.Location = new System.Drawing.Point(155, 21);
            this.label_Leather.Name = "label_Leather";
            this.label_Leather.Size = new System.Drawing.Size(67, 22);
            this.label_Leather.TabIndex = 108;
            this.label_Leather.Text = "Leather";
            this.label_Leather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Kod
            // 
            this.label_Kod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Kod.AutoSize = true;
            this.label_Kod.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Kod.Location = new System.Drawing.Point(38, 21);
            this.label_Kod.Name = "label_Kod";
            this.label_Kod.Size = new System.Drawing.Size(41, 22);
            this.label_Kod.TabIndex = 107;
            this.label_Kod.Text = "Kod";
            this.label_Kod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.btn_Add);
            this.groupBox4.Controls.Add(this.btn_Edit);
            this.groupBox4.Controls.Add(this.btn_Del);
            this.groupBox4.Location = new System.Drawing.Point(396, 655);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 76);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Image = global::FinalOrder.Properties.Resources.addicon;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(53, 24);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 40);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = " Add";
            this.t.SetToolTip(this.btn_Add, "Add position in this order");
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Edit.BackColor = System.Drawing.Color.White;
            this.btn_Edit.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Edit.Image = global::FinalOrder.Properties.Resources.editicon;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(209, 23);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 40);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = " Edit";
            this.t.SetToolTip(this.btn_Edit, "Edit current position in the order");
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Del.BackColor = System.Drawing.Color.White;
            this.btn_Del.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Del.Image = global::FinalOrder.Properties.Resources.delicon;
            this.btn_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del.Location = new System.Drawing.Point(365, 23);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(110, 40);
            this.btn_Del.TabIndex = 20;
            this.btn_Del.Text = " Del";
            this.t.SetToolTip(this.btn_Del, "Remove current position from the order");
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1320, 29);
            this.menuStrip1.TabIndex = 107;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseClientToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ChooseClientToolStripMenuItem
            // 
            this.ChooseClientToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ChooseClientToolStripMenuItem.Name = "ChooseClientToolStripMenuItem";
            this.ChooseClientToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.ChooseClientToolStripMenuItem.Text = "Choose Client";
            this.ChooseClientToolStripMenuItem.Click += new System.EventHandler(this.ChooseClientToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelToolStripMenuItem});
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // ExcelToolStripMenuItem
            // 
            this.ExcelToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem";
            this.ExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ExcelToolStripMenuItem.Text = ">Excel";
            this.ExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(957, 708);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 111;
            this.label4.Text = "Количество пар:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1133, 708);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 110;
            this.label3.Text = "Залог: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1128, 671);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 109;
            this.label2.Text = "Общая сумма заказа:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(957, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 108;
            this.label1.Text = "Количство моделей:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FinalOrder.Properties.Resources.nurasce_web_logo_02;
            this.pictureBox1.Location = new System.Drawing.Point(551, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            this.t.SetToolTip(this.pictureBox1, "Open web site nursace.com");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1320, 745);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1336, 784);
            this.Name = "Form1";
            this.Text = "NURSACE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        protected internal System.Windows.Forms.Label label_Tel;
        protected internal System.Windows.Forms.Label label_Country_City;
        protected internal System.Windows.Forms.Label label_Name_Sur;
        protected internal System.Windows.Forms.Label label_Cargo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExcelToolStripMenuItem;
        private System.Windows.Forms.Label label_Note;
        private System.Windows.Forms.Label label_TPrice_Label;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Kol_Label;
        private System.Windows.Forms.Label label_41;
        private System.Windows.Forms.Label label_40;
        private System.Windows.Forms.Label label_39;
        private System.Windows.Forms.Label label_38;
        private System.Windows.Forms.Label label_37;
        private System.Windows.Forms.Label label_36;
        private System.Windows.Forms.Label label_35;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label label_Leather;
        private System.Windows.Forms.Label label_Kod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private ToolTip t;
    }
}

