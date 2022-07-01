using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalOrder
{
    public partial class Form1 : Form
    {
        
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrderDB;Integrated Security=True;
                                    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        int nomerOrd = 0;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)  //загрузка главной формы
        {
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CreateColumn();
            RefreshDgv(dgv);
            string dateString = DateTime.Now.ToShortDateString();
            label_Date.Text = "Date: " + dateString;
            nomerOrd++;
            label_NomOrd.Text = "Nomer: " + nomerOrd.ToString();
            // dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void CreateColumn()  //создание колонок в DGV
        {
            dgv.Columns.Add("Id", "Id");
            dgv.Columns.Add("Kod", "Kod");
            dgv.Columns.Add("Leather", "Leather");
            dgv.Columns.Add("Color", "Color");
            dgv.Columns.Add("S35", "35");
            dgv.Columns.Add("S36", "36");
            dgv.Columns.Add("S37", "37");
            dgv.Columns.Add("S38", "38");
            dgv.Columns.Add("S39", "39");
            dgv.Columns.Add("S40", "40");
            dgv.Columns.Add("S41", "41");
            dgv.Columns.Add("Total", "Total");
            dgv.Columns.Add("Price", "Price");
            dgv.Columns.Add("TPrice", "Total Price");
            dgv.Columns.Add("Note", "Note");

            this.dgv.Columns[0].Width = 40;
            this.dgv.Columns[0].Visible = false;

            this.dgv.Columns[1].Width = 115;
            this.dgv.Columns[2].Width = 200;
            this.dgv.Columns[3].Width = 150;
            this.dgv.Columns[4].Width = 35;
            this.dgv.Columns[5].Width = 35;
            this.dgv.Columns[6].Width = 35;
            this.dgv.Columns[7].Width = 35;
            this.dgv.Columns[8].Width = 35;
            this.dgv.Columns[9].Width = 35;
            this.dgv.Columns[10].Width = 30;
            this.dgv.Columns[11].Width = 55;
            this.dgv.Columns[12].Width = 65;
            this.dgv.Columns[13].Width = 75;
            this.dgv.Columns[14].Width = 300;

            this.dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgv.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            


        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                         record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), record.GetInt32(7),
                         record.GetInt32(8), record.GetInt32(9), record.GetInt32(10), record.GetInt32(11),
                         record.GetDecimal(12), record.GetDecimal(13), record.GetString(14));
        }

        private void btn_Add_Click(object sender, EventArgs e) //кнопка добавления новой записи
        {
            AddNote();
            RefreshDgv(dgv);
        }

        private void btn_Edit_Click(object sender, EventArgs e) //кнопка редактирования выбранной записи
        {
            EditNote();
            RefreshDgv(dgv);
        }

        private void btn_Del_Click(object sender, EventArgs e) //кнопка удаления выбранной записи
        {
            DelNote();
            RefreshDgv(dgv);
        }

        private async void RefreshDgv(DataGridView dgv) //обновление DGV
        {
            dgv.Rows.Clear();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

                string queryString = @"SELECT * FROM OrderTable";

                SqlCommand command = new SqlCommand(queryString, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgv, reader);
                }
                reader.Close();

                string sumQuery = "SELECT SUM([TPrice]) FROM [OrderTable]";
                SqlCommand command1 = new SqlCommand(sumQuery, connect); 
                object summa = command1.ExecuteScalar();
                decimal sum = Convert.ToDecimal(summa);
                label1.Text = "Колличество позиций: " + dgv.Rows.Count.ToString();
                label2.Text = "Общаяя сумма заказа:" + sum.ToString() + "$";
                label3.Text = "Залог: " + (sum/100*30) + "$";
                connect.Close();

            }


            //label2.Text = sum.ToString();



            //label1.Text = "Колличество позиций: " + dgv.Rows.Count.ToString();
            //label2.Text = "Общаяя сумма заказа:" + sum.ToString();

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) //вставка элементов в textbox'ы при клике по ячейке
        {
            if (e.RowIndex >= 0)
            {
               txt_Id.Text = dgv[0, e.RowIndex].Value.ToString();
               txt_Kod.Text = dgv[1, e.RowIndex].Value.ToString();
               txt_Leather.Text = dgv[2, e.RowIndex].Value.ToString();
               txt_Color.Text = dgv[3, e.RowIndex].Value.ToString();
               txt_35.Text = dgv[4, e.RowIndex].Value.ToString();
               txt_36.Text = dgv[5, e.RowIndex].Value.ToString();
               txt_37.Text = dgv[6, e.RowIndex].Value.ToString();
               txt_38.Text = dgv[7, e.RowIndex].Value.ToString();
               txt_39.Text = dgv[8, e.RowIndex].Value.ToString();
               txt_40.Text = dgv[9, e.RowIndex].Value.ToString();
               txt_41.Text = dgv[10, e.RowIndex].Value.ToString();
               txt_Price.Text = dgv[12, e.RowIndex].Value.ToString();
               txt_Note.Text = dgv[14, e.RowIndex].Value.ToString();
            }
        }


        private async void AddNote()   //запрос к бд на ДОБАВЛЕНИЕ данных 
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

                var kod = txt_Kod.Text.ToUpper();
                var leather = txt_Leather.Text.ToUpper();
                var color = txt_Color.Text.ToUpper();
                int txt35, txt36, txt37, txt38, txt39, txt40, txt41, txtKol;
                decimal txtPrice, txtTPrice;
                var txtNote = txt_Note.Text;

                if (!string.IsNullOrEmpty(kod) && !string.IsNullOrEmpty(leather) && !string.IsNullOrEmpty(color))
                {
                    if (int.TryParse(txt_35.Text, out txt35) && int.TryParse(txt_36.Text, out txt36) && int.TryParse(txt_37.Text, out txt37)
                        && int.TryParse(txt_38.Text, out txt38) && int.TryParse(txt_39.Text, out txt39) && int.TryParse(txt_40.Text, out txt40)
                        && int.TryParse(txt_41.Text, out txt41) && decimal.TryParse(txt_Price.Text, out txtPrice))
                    {
                        txtKol = txt35 + txt36 + txt37 + txt38 + txt39 + txt40 + txt41;
                        label_Kol.Text = txtKol.ToString();

                        txtTPrice = Convert.ToDecimal(label_TPrice.Text);


                        var addQuery = "INSERT INTO OrderTable (Kod, Leather, Color, s35, s36, s37, s38, s39, s40, s41, Total, Price, TPrice, Note) " +
                                                  "VALUES (@kod, @leather, @color, @txt35, @txt36, @txt37, @txt38, @txt39, @txt40, @txt41, @txtKol, " +
                                                          "@txtPrice, @txtTPrice, @txtNote)";

                        SqlCommand command = new SqlCommand(addQuery, connect);

                        command.Parameters.AddWithValue("@kod",     kod);
                        command.Parameters.AddWithValue("@leather", leather);
                        command.Parameters.AddWithValue("@color",   color);
                        command.Parameters.AddWithValue("@txt35",   txt35);
                        command.Parameters.AddWithValue("@txt36",   txt36);
                        command.Parameters.AddWithValue("@txt37",   txt37);
                        command.Parameters.AddWithValue("@txt38",   txt38);
                        command.Parameters.AddWithValue("@txt39",   txt39);
                        command.Parameters.AddWithValue("@txt40",   txt40);
                        command.Parameters.AddWithValue("@txt41",   txt41);
                        command.Parameters.AddWithValue("@txtKol",  txtKol);
                        command.Parameters.AddWithValue("@txtPrice",  txtPrice);
                        command.Parameters.AddWithValue("@txtTPrice", txtTPrice);
                        command.Parameters.AddWithValue("@txtNote",   txtNote);
                  await command.ExecuteNonQueryAsync();

                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connect.Close();
            }
        }

        private void EditNote()  //запрос к бд на ИЗМЕНЕНИЕ данных
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.OpenAsync();

                if (!string.IsNullOrEmpty(txt_Kod.Text) && !string.IsNullOrWhiteSpace(txt_Kod.Text)
                && !string.IsNullOrEmpty(txt_Leather.Text) && !string.IsNullOrWhiteSpace(txt_Leather.Text)
                && !string.IsNullOrEmpty(txt_Color.Text) && !string.IsNullOrWhiteSpace(txt_Color.Text))
                {
                    decimal dcmPrice = Convert.ToDecimal(txt_Price.Text);
                    decimal dcmTPrice = Convert.ToDecimal(label_TPrice.Text);

                    string editQuery = "UPDATE OrderTable " +
                                                          "SET [Kod]=@Kod, [Leather]=@Leather, [Color]=@Color, " +
                                                              "[S35]=@S35, [S36]=@S36, [S37]=@S37, [S38]=@S38, [S39]=@S39, [S40]=@S40, [S41]=@S41, " +
                                                              "[Total]=@Total, [Price]=@Price, [TPrice]=@TPrice, [Note]=@Note " +
                                                        "WHERE [Id]=@id";

                    SqlCommand command = new SqlCommand(editQuery, connect);

                    command.Parameters.AddWithValue("id", txt_Id.Text);
                    command.Parameters.AddWithValue("Kod", txt_Kod.Text);
                    command.Parameters.AddWithValue("Leather", txt_Leather.Text);
                    command.Parameters.AddWithValue("Color", txt_Color.Text);
                    command.Parameters.AddWithValue("S35", txt_35.Text);
                    command.Parameters.AddWithValue("S36", txt_36.Text);
                    command.Parameters.AddWithValue("S37", txt_37.Text);
                    command.Parameters.AddWithValue("S38", txt_38.Text);
                    command.Parameters.AddWithValue("S39", txt_39.Text);
                    command.Parameters.AddWithValue("S40", txt_40.Text);
                    command.Parameters.AddWithValue("S41", txt_41.Text);
                    command.Parameters.AddWithValue("Total", label_Kol.Text);
                    command.Parameters.AddWithValue("Price", dcmPrice);
                    command.Parameters.AddWithValue("TPrice", dcmTPrice);
                    command.Parameters.AddWithValue("Note", txt_Note.Text);

                    command.ExecuteNonQuery();
                }
                connect.Close();
            }
        }

        private async void DelNote()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

                if (!string.IsNullOrEmpty(txt_Id.Text) &&
                    !string.IsNullOrWhiteSpace(txt_Id.Text))
                {
                    string delQuery = "DELETE FROM OrderTable WHERE [Id]=@id";

                    SqlCommand command = new SqlCommand(delQuery, connect);
                    command.Parameters.AddWithValue("id", txt_Id.Text);
                    
                    var result = MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        await command.ExecuteNonQueryAsync();

                }
                connect.Close();
            }
        }

        private void ClearTextBox()   //очистка всех текстбоксов
        {
            txt_Kod.Clear();
            txt_Leather.Clear();
            txt_Color.Clear();
            txt_35.Clear();
            txt_36.Clear();
            txt_37.Clear();
            txt_38.Clear();
            txt_39.Clear();
            txt_40.Clear();
            txt_41.Clear();
            txt_Price.Clear();
            txt_Note.Clear();
        }
  
        private void resLabel()  //отвечает за работу label1 и label2
        {
            int a, b, c, d, e, f, g;
            int.TryParse(txt_35.Text, out a);
            int.TryParse(txt_36.Text, out b);
            int.TryParse(txt_37.Text, out c);
            int.TryParse(txt_38.Text, out d);
            int.TryParse(txt_39.Text, out e);
            int.TryParse(txt_40.Text, out f);
            int.TryParse(txt_41.Text, out g);
            int res = a + b + c + d + e + f + g;

            label_Kol.Text = Convert.ToString(res);

            decimal x, y;
            decimal.TryParse(txt_Price.Text, out x);
            decimal.TryParse(label_Kol.Text, out y);
            decimal res1 = x * y;

            label_TPrice.Text = Convert.ToString(res1);
        }



        #region Sizes

        private void txt_35_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }

        private void txt_36_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }

        private void txt_37_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }

        private void txt_38_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }

        private void txt_39_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }

        private void txt_40_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }

        private void txt_41_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            resLabel();
        }
        #endregion

        private void btn_Client_Click(object sender, EventArgs e)
        {
            new ClientsForm(this).Show();
        }

   
    }
    
}
