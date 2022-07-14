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
    public partial class ClientsForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrderDB;Integrated Security=True;
                                    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        Form1 form1;
        IDataRecord record = null;
        public ClientsForm(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClientsForm_Load(object sender, EventArgs e)  //при загрузке формы создаются колонки и обновляется DGV Client
        {
            CreateColumnClients();
            RefreshClintsDgv(dgv_Clients);
        }

        private void ClientsForm_Click(object sender, EventArgs e) //при клике по пустому месту на форме чистит текстбоксы и сбрасывает маркер строки в DGV Client
        {
            ClearTextBox();
            dgv_Clients.ClearSelection();
        }

        private void CreateColumnClients()                                               //создание колонок в DGV Client
        {
            dgv_Clients.Columns.Add("Id", "Id");
            dgv_Clients.Columns.Add("Name", "Name");
            dgv_Clients.Columns.Add("Surname", "Surname");
            dgv_Clients.Columns.Add("Country", "Country");
            dgv_Clients.Columns.Add("City", "City");
            dgv_Clients.Columns.Add("Tel", "Tel");
            dgv_Clients.Columns.Add("Cargo", "Cargo");

            this.dgv_Clients.Columns[0].Width = 40;
            this.dgv_Clients.Columns[0].Visible = false;
            this.dgv_Clients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Clients.Columns[2].Width = 160;
            this.dgv_Clients.Columns[3].Width = 135;
            this.dgv_Clients.Columns[4].Width = 110;
            this.dgv_Clients.Columns[5].Width = 125;
            this.dgv_Clients.Columns[6].Width = 125;
        }

        private void ReadSingleRow(DataGridView dgv_Clients, IDataRecord record)         //заполнение ячеек в DGV Client
        {
            dgv_Clients.Rows.Add(record.GetInt32(0), record.GetString(1),
                                 record.GetString(2), record.GetString(3),
                                 record.GetString(4), record.GetString(5),
                                 record.GetString(6));
        }

        private async void RefreshClintsDgv(DataGridView dgv_Clients)                    //обновление DGV Client
        {
            dgv_Clients.Rows.Clear();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

                string queryString = @"SELECT * FROM ClientTable";

                SqlCommand command = new SqlCommand(queryString, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgv_Clients, reader);
                }
                reader.Close();
            }
        }

        private void dgv_Clients_CellClick(object sender, DataGridViewCellEventArgs e)   //при клике по пустому месту на форме очищаются текстбоксы и выборка в DGV Client
        {
            if (e.RowIndex >= 0)
            {
                txt_Id.Text = dgv_Clients[0, e.RowIndex].Value.ToString();
                txt_Name.Text = dgv_Clients[1, e.RowIndex].Value.ToString();
                txt_Surname.Text = dgv_Clients[2, e.RowIndex].Value.ToString();
                txt_Country.Text = dgv_Clients[3, e.RowIndex].Value.ToString();
                txt_City.Text = dgv_Clients[4, e.RowIndex].Value.ToString();
                txt_Tel.Text = dgv_Clients[5, e.RowIndex].Value.ToString();
                txt_Cargo.Text = dgv_Clients[6, e.RowIndex].Value.ToString();
            }
        }


        private void txt_Search_TextChanged(object sender, EventArgs e)   //вызов метода поиска по бд клиентов
        {
            Search(dgv_Clients);
        }

        private async void Search(DataGridView dgv_Clients)               //метод поиска по бд клиентов
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();
                dgv_Clients.Rows.Clear();

                string searchQuery = $"SELECT * FROM ClientTable WHERE CONCAT (Name, Surname, Country, City, Tel, Cargo) LIKE '%" + txt_Search.Text + "%'";
                SqlCommand com = new SqlCommand(searchQuery, connect);

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dgv_Clients, reader);
                }
                reader.Close();
            }
        }


        private void bmt_New_Client_Click(object sender, EventArgs e)     //кнопка для ДОБАВЛЕНИЯ в бд нового клиента
        {
            AddClient();
            RefreshClintsDgv(dgv_Clients);
        }

        private void btn_Edit_Client_Click(object sender, EventArgs e)    //кнопка для ИЗМЕНЕНИЯ в бд данных о клиенте
        {
            Edit();
            RefreshClintsDgv(dgv_Clients);
        }

        private void btn_Del_Client_Click(object sender, EventArgs e)     //кнопка для УДАЛЕНИЯ клиента из бд
        {
            Del();
            RefreshClintsDgv(dgv_Clients);
        }

        private void btn_Select_Client_Click(object sender, EventArgs e)  //перенос данных с текстбоксов на форму "родитель"
        {
            form1.label_Name_Sur.Text = txt_Name.Text + " " + txt_Surname.Text;
            form1.label_Country_City.Text = txt_Country.Text + " " + txt_City.Text;
            form1.label_Tel.Text = txt_Tel.Text;
            form1.label_Cargo.Text = txt_Cargo.Text;
            this.Close();
        }


        private void AddClient()   //метод для добавления в бд нового клиента
        {
            if (CheckClient())
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string name = txt_Name.Text.ToUpper();
                    string surname = txt_Surname.Text.ToUpper();
                    string country = txt_Country.Text.ToUpper();
                    string city = txt_City.Text.ToUpper();
                    string tel = txt_Tel.Text;
                    string cargo = txt_Cargo.Text;

                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(city))
                    {
                        var addQuery = "INSERT INTO ClientTable (Name, Surname, Country, City, Tel, Cargo) " +
                                                    "VALUES (@name, @surname, @country, @city, @tel, @cargo)";

                        SqlCommand command = new SqlCommand(addQuery, connect);

                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@country", country);
                        command.Parameters.AddWithValue("@city", city);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@cargo", cargo);

                        if (command.ExecuteNonQuery() == 1)
                        {
                            var result = MessageBox.Show($"Client {name} {surname} added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                ClearTextBox();
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                    connect.Close();
                }
            }
        }

        private void Edit()        //метод для изменения в бд данных о клиенте
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.OpenAsync();

                if (!string.IsNullOrEmpty(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_Name.Text)
                && !string.IsNullOrEmpty(txt_Surname.Text) && !string.IsNullOrWhiteSpace(txt_Surname.Text)
                && !string.IsNullOrEmpty(txt_City.Text) && !string.IsNullOrWhiteSpace(txt_City.Text))
                {

                    string editQuery = "UPDATE ClientTable " +
                                                          "SET [Name]=@Name, [Surname]=@Surname, " +
                                                              "[Country]=@Country, [City]=@City, [Tel]=@Tel, [Cargo]=@Cargo " +
                                                          "WHERE [Id]=@id";

                    SqlCommand command = new SqlCommand(editQuery, connect);

                    command.Parameters.AddWithValue("id", txt_Id.Text);
                    command.Parameters.AddWithValue("Name", txt_Name.Text);
                    command.Parameters.AddWithValue("Surname", txt_Surname.Text);
                    command.Parameters.AddWithValue("Country", txt_Country.Text);
                    command.Parameters.AddWithValue("City", txt_City.Text);
                    command.Parameters.AddWithValue("Tel", txt_Tel.Text);
                    command.Parameters.AddWithValue("Cargo", txt_Cargo.Text);

                    command.ExecuteNonQuery();
                }
                connect.Close();
            }
        }

        private async void Del()   //метод для удаления клиента из бд
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

                if (!string.IsNullOrEmpty(txt_Id.Text) &&
                    !string.IsNullOrWhiteSpace(txt_Id.Text))
                {
                    string delQuery = "DELETE FROM ClientTable WHERE [Id]=@id";

                    SqlCommand command = new SqlCommand(delQuery, connect);
                    command.Parameters.AddWithValue("id", txt_Id.Text);

                    var result = MessageBox.Show("Are you sure you want to delete this client?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        await command.ExecuteNonQueryAsync();
                }
                connect.Close();
            }
        }


        private Boolean CheckClient()    //проверка на наличие клиента
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                var client_Name = txt_Name.Text;
                var client_Surname = txt_Surname.Text;
                var client_City = txt_City.Text;


                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"SELECT Name, Surname, City FROM ClientTable WHERE Name = '{client_Name}' AND Surname = '{client_Surname}'AND City = '{client_City}'";
                SqlCommand command = new SqlCommand(querystring, connect);

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Error! This client is already registered!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void ClearTextBox()      //очистка всех текстбоксов
        {
            txt_Id.Clear();
            txt_Name.Clear();
            txt_Surname.Clear();
            txt_Country.Clear();
            txt_City.Clear();
            txt_Tel.Clear();
            txt_Cargo.Clear();
            txt_Search.Clear();
        }
    }
}