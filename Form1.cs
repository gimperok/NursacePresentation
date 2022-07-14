using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace FinalOrder
{
    public partial class Form1 : Form
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OrderDB;Integrated Security=True;
                                    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private int nomerzakaza;
        private string txtNote;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)                       //загрузка главной формы
        {
            CreateColumn();
            RefreshDgv(dgv);
            string dateString = DateTime.Now.ToShortDateString();
            label_Date.Text = "Date: " + dateString;
            ShowNomerZakaza();
        }

        private void Form1_Click(object sender, EventArgs e)                      //при клике по пустому месту на форме чистит текстбоксы и сбрасывает маркер строки в DGV
        {
            ClearTextBox();
            dgv.ClearSelection();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)                //измениние размера столбцов при изменинии размеров формы
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            this.dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgv.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateNomerZakaza();  //итерация номера заказа
        }  //при закрытии формы обновляет номер заказа

        private void CreateColumn()                                               //создание колонок в DGV
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

            this.dgv.Columns[0].Width = 40;       //параметры столбца "Id"
            this.dgv.Columns[0].Visible = false;

            this.dgv.Columns[1].Width = 120;      //уст-ка мин. ширины колонок в DGV
            this.dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgv.Columns[4].Width = 35;
            this.dgv.Columns[5].Width = 35;
            this.dgv.Columns[6].Width = 35;
            this.dgv.Columns[7].Width = 35;
            this.dgv.Columns[8].Width = 35;
            this.dgv.Columns[9].Width = 35;
            this.dgv.Columns[10].Width = 30;
            this.dgv.Columns[11].Width = 55;
            this.dgv.Columns[12].Width = 75;
            this.dgv.Columns[13].Width = 80;
            this.dgv.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgv.Columns[14].MinimumWidth = 270;


            this.dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;  // зн-я ячеек по центру с колонки 4 по 13
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

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)          //заполнение ячеек DGV
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                         record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), record.GetInt32(7),
                         record.GetInt32(8), record.GetInt32(9), record.GetInt32(10), record.GetInt32(11),
                         record.GetDecimal(12), record.GetDecimal(13), record.GetString(14));
        }


        private void ChooseClientToolStripMenuItem_Click(object sender, EventArgs e) //открывает форму выбора клиента
        {
            new ClientsForm(this).Show();
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)        //вызывает из меню метод экспорта DGV в Excel
        {
            ExcelPrint();
        }

        private void btn_Add_Click(object sender, EventArgs e)      //кнопка добавления новой записи
        {
            AddNote();
            RefreshDgv(dgv);
            if (dgv.RowCount > 15)
            {
                dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 1; // прокручиваем таблицу до новой добавленной строки
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)     //кнопка редактирования выбранной записи
        {
            EditNote();
            RefreshDgv(dgv);
            VozvratKStroke();
        }

        private void btn_Del_Click(object sender, EventArgs e)      //кнопка удаления выбранной записи
        {
            DelNote();
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //при клике по логотипу открывает в браузере сайт nursace.com
        {
            var linkAddress = @"http://www.nursace.com";
            System.Diagnostics.Process.Start(linkAddress);
        }


        private async void RefreshDgv(DataGridView dgv)                        //обновление DGV
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
                decimal sum = 0;
                if (dgv.RowCount > 0)
                {
                    sum = Convert.ToDecimal(summa);
                }
                label1.Text = "Total positions: " + dgv.Rows.Count.ToString();
                label2.Text = "Order total: " + sum.ToString() + "$";
                label3.Text = "Deposit: " + (sum / 100 * 30) + "$";


                string parQuery = "SELECT SUM([Total]) FROM [OrderTable]";
                SqlCommand command2 = new SqlCommand(parQuery, connect);
                object par = command2.ExecuteScalar();
                int vsegoPar = 0;

                if (dgv.RowCount > 0)
                {
                    vsegoPar = Convert.ToInt32(par);
                }
                label4.Text = "Total pairs: " + vsegoPar.ToString();
                connect.Close();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) //вставка элементов в textbox'ы при клике по строке DGV
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
        private void VozvratKStroke()                                          //возвращаем фокус на измененную строку
        {
            for (int i = 0; i < dgv.RowCount; i++)  // циклом возвращаем к строке, которую мы редактировали
            {
                if (dgv[0, i].FormattedValue.ToString().Contains(txt_Id.Text))
                {
                    if (i < 15)
                    {
                        dgv.FirstDisplayedScrollingRowIndex = 0;
                        dgv.ClearSelection();
                        ClearTextBox();
                        return;
                    }
                    else
                    {
                        dgv.FirstDisplayedScrollingRowIndex = i;
                        ClearTextBox();
                        return;
                    }
                }
            }
        }


        private void AddNote()         //запрос к бд для ДОБАВЛЕНИЕ новой позиции
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                var kod = txt_Kod.Text.ToUpper();
                var leather = txt_Leather.Text.ToUpper();
                var color = txt_Color.Text.ToUpper();
                var txtNote = txt_Note.Text;

                if (!string.IsNullOrEmpty(kod) && !string.IsNullOrEmpty(leather) && !string.IsNullOrEmpty(color))
                {
                    if (int.TryParse(txt_35.Text, out int txt35) && int.TryParse(txt_36.Text, out int txt36) && int.TryParse(txt_37.Text, out int txt37)
                        && int.TryParse(txt_38.Text, out int txt38) && int.TryParse(txt_39.Text, out int txt39) && int.TryParse(txt_40.Text, out int txt40)
                        && int.TryParse(txt_41.Text, out int txt41) && decimal.TryParse(txt_Price.Text, out decimal txtPrice) && (txtNote.Length<150))
                    {
                        int txtKol = txt35 + txt36 + txt37 + txt38 + txt39 + txt40 + txt41;
                        label_Kol.Text = txtKol.ToString();

                        decimal txtTPrice = Convert.ToDecimal(label_TPrice.Text);


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
                        command.ExecuteNonQuery();

                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Error!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connect.Close();
            }
        }

        private void EditNote()        //запрос к бд на ИЗМЕНЕНИЕ данных
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                txtNote = txt_Note.Text;
                connect.Open();

                if (!string.IsNullOrEmpty(txt_Kod.Text) && !string.IsNullOrWhiteSpace(txt_Kod.Text)
                && !string.IsNullOrEmpty(txt_Leather.Text) && !string.IsNullOrWhiteSpace(txt_Leather.Text)
                && !string.IsNullOrEmpty(txt_Color.Text) && !string.IsNullOrWhiteSpace(txt_Color.Text))
                {
                    if (int.TryParse(txt_35.Text, out int txt35) && int.TryParse(txt_36.Text, out int txt36) && int.TryParse(txt_37.Text, out int txt37)
                        && int.TryParse(txt_38.Text, out int txt38) && int.TryParse(txt_39.Text, out int txt39) && int.TryParse(txt_40.Text, out int txt40)
                        && int.TryParse(txt_41.Text, out int txt41) && decimal.TryParse(txt_Price.Text, out decimal txtPrice) && (txtNote.Length < 150))
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
                        command.Parameters.AddWithValue("@S35", txt35);
                        command.Parameters.AddWithValue("@S36", txt36);
                        command.Parameters.AddWithValue("@S37", txt37);
                        command.Parameters.AddWithValue("@S38", txt38);
                        command.Parameters.AddWithValue("@S39", txt39);
                        command.Parameters.AddWithValue("@S40", txt40);
                        command.Parameters.AddWithValue("@S41", txt41);
                        command.Parameters.AddWithValue("Total", label_Kol.Text);
                        command.Parameters.AddWithValue("Price", dcmPrice);
                        command.Parameters.AddWithValue("TPrice", dcmTPrice);
                        command.Parameters.AddWithValue("Note", txt_Note.Text);

                        command.ExecuteNonQuery();
                    }
                    connect.Close();
                }
            }
        }

        private async void DelNote()   //запрос к бд на УДАЛЕНИЕ данных
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
                            RefreshDgv(dgv);
                }
                connect.Close();
            }
        }

        private void ExcelPrint()      //метод для экспорта из DGV в Excel
        {
            if (dgv.Rows.Count > 0)
            {
                Excel.Application exApp = new Excel.Application();  //Объявляю приложение

                exApp.Workbooks.Add();  //Добавляю рабочую книгу

                Microsoft.Office.Interop.Excel.Worksheet wsh = (Microsoft.Office.Interop.Excel.Worksheet)exApp.ActiveSheet;  //Получаю первый лист документа
                wsh.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                int i, j;

                for (j = 1; j <= dgv.ColumnCount - 1; j++)  //цикл перебора колонок
                {
                    for (i = 0; i <= dgv.RowCount - 1; i++)  //цикл перебора строк
                    {
                        wsh.Cells[6, j] = dgv.Columns[j].HeaderText.ToString();

                        wsh.Cells[i + 7, j] = dgv[j, i].Value.ToString();
                    }
                }

                Excel.Range razr = wsh.Cells[27, 1];
                wsh.HPageBreaks.Add(razr);            //разрыв для первой страницы (после 20ой строки заказа)


                for (int t = 27; t < dgv.RowCount + 25; t += 25)  //разрыв для всех последующих страниц (25 позиций на лист)
                {
                    Excel.Range razr2 = wsh.Cells[t, 1];
                    wsh.HPageBreaks.Add(razr2);
                }

                #region настройки отображения таблицы

                wsh.Range[wsh.Cells[1, 1], wsh.Cells[1, 3]].MergeCells = true;    //обьединяю ячейки (левая сторона шапки)
                wsh.Range[wsh.Cells[2, 1], wsh.Cells[2, 3]].MergeCells = true;
                wsh.Range[wsh.Cells[3, 1], wsh.Cells[3, 3]].MergeCells = true;
                wsh.Range[wsh.Cells[4, 1], wsh.Cells[4, 3]].MergeCells = true;

                wsh.Range[wsh.Cells[1, 12], wsh.Cells[1, 14]].MergeCells = true;   //обьединяю ячейки (правая сторона шапки)
                wsh.Range[wsh.Cells[2, 12], wsh.Cells[2, 14]].MergeCells = true;
                wsh.Range[wsh.Cells[3, 12], wsh.Cells[3, 14]].MergeCells = true;
                wsh.Range[wsh.Cells[4, 12], wsh.Cells[4, 14]].MergeCells = true;

                wsh.Range[wsh.Cells[5, 1], wsh.Cells[5, 14]].MergeCells = true;    //сплошная пустая строка после шапки


                string fname = Directory.GetCurrentDirectory() + @"\\weblogo.jpg";  //добавляем logo в шапку таблицы

                wsh.Shapes.AddPicture(fname, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 145, 0, 155, 65);


                wsh.Range[wsh.Cells[1, 1], wsh.Cells[1, 3]].Value = label_Name_Sur.Text;       //заполняем левую сторону шапки
                wsh.Range[wsh.Cells[2, 1], wsh.Cells[2, 3]].Value = label_Country_City.Text;
                wsh.Range[wsh.Cells[3, 1], wsh.Cells[3, 3]].Value = label_Tel.Text;
                wsh.Range[wsh.Cells[4, 1], wsh.Cells[4, 3]].Value = label_Cargo.Text;

                wsh.Range[wsh.Cells[1, 12], wsh.Cells[1, 14]].Value = label_Date.Text;          //заполняем правую сторону шапки
                wsh.Range[wsh.Cells[2, 12], wsh.Cells[2, 14]].Value = label_NomOrd.Text;


                Excel.Range range1 = wsh.Range[wsh.Cells[1, 1], wsh.Cells[4, 3]];                                         //левая часть шапки(данные клиента)

                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;     //настройка границ рамки левой части шапки
                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;

                range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;

                range1.Font.Bold = true;



                Excel.Range range2 = wsh.Range[wsh.Cells[1, 12], wsh.Cells[4, 14]];                                       //правая часть шапки (данные заказа)

                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;     //настройка границ рамки правой части шапки
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;

                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;

                range2.Font.Bold = true;



                Excel.Range range5 = wsh.Range[wsh.Cells[6, 1], wsh.Cells[6, 14]];                                      //строка заголовкой таблицы

                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDouble;       //настройка границ рамки строки заголовков таблицы
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlDouble;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDouble;

                range5.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlDouble;

                range5.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;             //выравнивание по центру ко всему диапазону
                range5.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);   //фон серый
                range5.Font.Bold = true;



                Excel.Range range6 = wsh.Range[wsh.Cells[7, 1], wsh.Cells[dgv.RowCount + 6, 14]];                       //таблица заказа после заголовоков

                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDouble;       //настройка границ таблицы заказа
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlDouble;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDouble;

                range6.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;



                Excel.Range range7 = wsh.Range[wsh.Cells[1, 1], wsh.Cells[dgv.RowCount + 9, 14]];  //вся таблица

                range7.Cells.Font.Name = "Palatino Linotype";
                range7.Font.Size = 13;
                range7.EntireColumn.AutoFit(); //Автоматическая подгонка всего столбца, чтобы достичь наилучшей посадки


                Excel.Range range8 = wsh.Range[wsh.Cells[7, 4], wsh.Cells[dgv.RowCount + 6, 10]];  //колонки размеров
                range8.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                range8.Font.Bold = true;


                Excel.Range range9 = wsh.Range[wsh.Cells[1, 4], wsh.Cells[4, 11]];               //лого
                range9.MergeCells = true;


                Excel.Range range10 = wsh.Range[wsh.Cells[dgv.RowCount + 7, 12], wsh.Cells[dgv.RowCount + 7, 14]];  //всего пар

                range10.MergeCells = true;
                range10.Value = label4.Text;


                Excel.Range range11 = wsh.Range[wsh.Cells[dgv.RowCount + 8, 12], wsh.Cells[dgv.RowCount + 8, 14]];  //вся сумма

                range11.MergeCells = true;
                range11.Value = label2.Text;


                Excel.Range range12 = wsh.Range[wsh.Cells[dgv.RowCount + 9, 12], wsh.Cells[dgv.RowCount + 9, 14]];  //депозит

                range12.MergeCells = true;
                range12.Value = label3.Text;


                Excel.Range range13 = wsh.Range[wsh.Cells[dgv.RowCount + 7, 12], wsh.Cells[dgv.RowCount + 9, 14]];  //  нижний блок после таблицы 3 строки(итог)

                range13.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDouble;
                range13.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble;
                range13.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlDouble;
                range13.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDouble;

                range13.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range13.Font.Bold = true;


                Excel.Range range16 = wsh.Range[wsh.Cells[1, 1], wsh.Cells[dgv.RowCount + 9, 1]];  //столбец Kod  
                range16.ColumnWidth = 13;

                Excel.Range range14 = wsh.Range[wsh.Cells[1, 2], wsh.Cells[dgv.RowCount + 9, 2]];  //столбец Leather    
                range14.ColumnWidth = 20;


                Excel.Range range17 = wsh.Range[wsh.Cells[1, 3], wsh.Cells[dgv.RowCount + 9, 3]];  //  столбец Color               
                range17.ColumnWidth = 20;


                Excel.Range range18 = wsh.Range[wsh.Cells[1, 12], wsh.Cells[dgv.RowCount + 9, 12]];  //  столбец Price
                range18.ColumnWidth = 7;


                Excel.Range range15 = wsh.Range[wsh.Cells[1, 13], wsh.Cells[dgv.RowCount + 9, 13]];  //  столбец Total Price
                range15.ColumnWidth = 9;


                Excel.Range range19 = wsh.Range[wsh.Cells[1, 14], wsh.Cells[dgv.RowCount + 9, 14]];  //столбец Note  
                range19.ColumnWidth = 22;

                #endregion
                exApp.Visible = true;
            }
        }

 
        private void resLabel()               //отвечает за работу label - (кол-во пар и сумму в серии)
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

        #region Sizes                                //считываем количество всех размеров

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

        private async void ShowNomerZakaza()  //получает из бд и присвает переменной номер заказа
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                await connect.OpenAsync();

                string queryNomera = @"SELECT * FROM NomerZakaza";

                SqlCommand command = new SqlCommand(queryNomera, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (await reader.ReadAsync())
                {
                    object nomer = reader.GetValue(1);
                    nomerzakaza = Convert.ToInt32(nomer);
                    label_NomOrd.Text = "Order №: " + nomerzakaza.ToString();
                }
                reader.Close();
            }
        }

        private void UpdateNomerZakaza()      //изменяет в  бд номер заказа
        {
            nomerzakaza++;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string queryEditNomer = $"UPDATE NomerZakaza SET Nomer={nomerzakaza} WHERE Id=1";
                SqlCommand command = new SqlCommand(queryEditNomer, connect);
                command.ExecuteNonQuery();
            }
        }

        private void ClearTextBox()           //очистка всех текстбоксов
        {
            txt_Id.Clear();
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
    }
}