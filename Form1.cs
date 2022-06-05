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
        DataBase database = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumn()
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
        private async void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();

            using (database.getConnection())
            {
                database.openConnection();

                string queryString = @"SELECT * FROM OrderTable";

                SqlCommand command = new SqlCommand(queryString, database.getConnection());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgv, reader);
                }
                reader.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumn();
            RefreshDgv(dgv);
        }
    }
}
