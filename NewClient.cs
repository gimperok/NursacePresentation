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
    public partial class NewClient : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrderDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public NewClient()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_AddNewCL_Click(object sender, EventArgs e)
        {
            AddClient();
        }

        private async void AddClient()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

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

                    if (await command.ExecuteNonQueryAsync() == 1)
                    {
                        var result = MessageBox.Show($"Клиент {name} {surname} успешно добавлен!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            ClearTextBox();
                            this.Close();
                        }
                    }                 
                }
                else
                {
                    MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                connect.Close();
            }
        }
            private void ClearTextBox()   //очистка всех текстбоксов
            {
                txt_Name.Clear();
                txt_Surname.Clear();
                txt_Country.Clear();
                txt_City.Clear();
                txt_Tel.Clear();
                txt_Cargo.Clear();
            }
        
    }
}
