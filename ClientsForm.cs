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
        public ClientsForm(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }


        private void CreateClientsColumnClients()  //создание колонок в DGV
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
            this.dgv_Clients.Columns[1].Width = 80;
            this.dgv_Clients.Columns[2].Width = 200;
            this.dgv_Clients.Columns[3].Width = 125;
            this.dgv_Clients.Columns[4].Width = 125;
            this.dgv_Clients.Columns[5].Width = 125;
            this.dgv_Clients.Columns[6].Width = 125;


            //this.dgv_Clients.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //this.dgv_Clients.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;



        }
        IDataRecord record = null;
        private void ReadSingleRow(DataGridView dgv_Clients, IDataRecord record)
        {
            dgv_Clients.Rows.Add(record.GetInt32(0),  record.GetString(1),
                                 record.GetString(2), record.GetString(3),
                                 record.GetString(4), record.GetString(5),
                                 record.GetString(6));
        }



        private async void RefreshClintsDgv(DataGridView dgv_Clients) //обновление DGV
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

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            CreateClientsColumnClients();
            RefreshClintsDgv(dgv_Clients);
        }

        private void dgv_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_Select_Client_Click(object sender, EventArgs e)
        {
            form1.label_Name_Sur.Text = txt_Name.Text + " " + txt_Surname.Text;
            form1.label_Country_City.Text = txt_Country.Text + " " + txt_City.Text;
            form1.label_Tel.Text = txt_Tel.Text;
            form1.label_Cargo.Text = txt_Cargo.Text;
            this.Close();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dgv_Clients);
        }

        private async void Search(DataGridView dgv_Clients)
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

        private void bmt_New_Client_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
        }

        private void btn_Edit_Client_Click(object sender, EventArgs e)
        {
            Edit();
            RefreshClintsDgv(dgv_Clients);
        }

        private void Edit()
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

        private void btn_Del_Client_Click(object sender, EventArgs e)
        {
            Del();
            RefreshClintsDgv(dgv_Clients);
        }

        private async void Del()
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

                    var result = MessageBox.Show("Вы действительно хотите удалить данного клиента?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        await command.ExecuteNonQueryAsync();

                }
                connect.Close();
            }

        }
    }
}
