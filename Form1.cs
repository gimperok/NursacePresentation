using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOrder
{
    public partial class Form1 : Form
    {
        //DataBase database = new DataBase();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrderDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumn();
            RefreshDgv(dgv);
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
            }
        }
        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) //вставка элементов в textbox'ы при клике по ячейке
        {
            if (e.RowIndex >= 0)
            {

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


        private void AddNote() //запрос к бд на ДОБАВЛЕНИЕ данных 
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

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
                        label1.Text = txtKol.ToString();

                        txtTPrice = Convert.ToDecimal(label2.Text);


                        var addQuery = "INSERT INTO OrderTable (Kod, Leather, Color, s35, s36, s37, s38, s39, s40, s41, Total, Price, TPrice, Note) " +
                                                  "VALUES (@kod, @leather, @color, @txt35, @txt36, @txt37, @txt38, @txt39, @txt40, @txt41, @txtKol, " +
                                                          "@txtPrice, @txtTPrice, @txtNote)";

                        SqlCommand command = new SqlCommand(addQuery, connect);

                        command.Parameters.AddWithValue("@kod", kod);
                        command.Parameters.AddWithValue("@leather", leather);
                        command.Parameters.AddWithValue("@color", color);
                        command.Parameters.AddWithValue("@txt35", txt35);
                        command.Parameters.AddWithValue("@txt36", txt36);
                        command.Parameters.AddWithValue("@txt37", txt37);
                        command.Parameters.AddWithValue("@txt38", txt38);
                        command.Parameters.AddWithValue("@txt39", txt39);
                        command.Parameters.AddWithValue("@txt40", txt40);
                        command.Parameters.AddWithValue("@txt41", txt41);
                        command.Parameters.AddWithValue("@txtKol", txtKol);
                        command.Parameters.AddWithValue("@txtPrice", txtPrice);
                        command.Parameters.AddWithValue("@txtTPrice", txtTPrice);
                        command.Parameters.AddWithValue("@txtNote", txtNote);
                        command.ExecuteNonQuery();

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

        private void ClearTextBox()
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

        //отвечает за работу label1 и label2
        private void resLabel()
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

            label1.Text = Convert.ToString(res);

            decimal x, y;
            decimal.TryParse(txt_Price.Text, out x);
            decimal.TryParse(label1.Text, out y);
            decimal res1 = x * y;

            label2.Text = Convert.ToString(res1);
        }
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
    }
}
