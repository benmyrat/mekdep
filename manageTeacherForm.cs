using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace eSchool
{
    public partial class manageTeacherForm : Form
    {
        public manageTeacherForm()
        {
            InitializeComponent();
        }
        iTeacherTableDB iTeacher = new iTeacherTableDB();
        private void manageTeacherForm_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, " +
                "`address`, `mail`, `mobile`, `teacherPic` FROM `iteacher`"));
            if (radioButtonIdNo.Checked || radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            else
            {

            }
        }
        public void fillGrid(MySqlCommand command)
        {
            //тут список учителей будет
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 155;
            dataGridView1.DataSource = iTeacher.getTeachers(command);
            //11 колонка для изображения
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //Показываю кол-во учителей
            labelTotalTeachers.Text = "Общая количество учителей: " + dataGridView1.Rows.Count;
        }

        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            //Ищем нужных людей
            string query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `teacherPic`" +
                " FROM `iteacher` WHERE CONCAT(`surName`, `name`, `patronymic`, `address`, `mail`) LIKE '%" + textBoxSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButtonIdNo_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
        }

        private void radioButtonIdYES_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string query;
            MySqlCommand command;

            if (radioButtonYES.Checked)
            {
                //сортировка по дате
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (radioButtonMale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `teacherPic`" +
                        " FROM `iteacher` WHERE `birthDate` BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Мужчина'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `teacherPic`" +
                        " FROM `iteacher` WHERE `birthDate` BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Женщина'";
                }
                else
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `teacherPic`" +
                        " FROM `iteacher` WHERE `birthDate` BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }
                command = new MySqlCommand(query);
                fillGrid(command);
            }
            else if (radioButtonIdYES.Checked)
            {
                var id1 = Convert.ToInt32(numericUpDown1.Value);
                var id2 = Convert.ToInt32(numericUpDown2.Value);
                if (radioButtonMale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `teacherPic`" +
                        " FROM `iteacher` WHERE `id` BETWEEN '" + id1 + "' AND '" + id2 + "' AND gender='Мужчина'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `teacherPic`" +
                        " FROM `iteacher` WHERE `id` BETWEEN '" + id1 + "' AND '" + id2 + "' AND gender='Женщина'";
                }
                else
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `teacherPic`" +
                        " FROM `iteacher` WHERE `id` BETWEEN '" + id1 + "' AND '" + id2 + "'";
                }
                command = new MySqlCommand(query);
                fillGrid(command);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            radioButtonAll.Checked = true;
            radioButtonIdNo.Checked = true;
            radioButtonNo.Checked = true;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBoxSearch.Text = "";
            fillGrid(new MySqlCommand("SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, " +
                "`address`, `mail`, `mobile`, `teacherPic` FROM `iteacher`"));
        }

        private void buttonPrintTXT_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Список_учителей.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                DateTime bdate;
                //строки
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 5)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t\t" + bdate.ToString("yyyy-MM-dd") + "\t\t" + "|");
                        }
                        else if (j == dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t\t" + "|");
                        }
                    }
                    //Чтобы не было всё на одном строке 
                    writer.WriteLine("");
                    writer.WriteLine("———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————");
                }
                writer.Close();
                MessageBox.Show("Текстовый файл сохранён", "Распечатка завершена успешна!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrintXlsx_Click(object sender, EventArgs e)
        {
            sFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sFileDialog.Title = "Сохранить как Excel";
            sFileDialog.FileName = "";
            sFileDialog.Filter = "Excel Файлы (2007|*.xlsx|Excel Files(.CSV)|*.csv";
            if (sFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                Cursor.Current = Cursors.WaitCursor;
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                excelApp.Columns.ColumnWidth = 28;
                /*                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                                {
                                    excelApp.Cells[i, 1] = dataGridView1.Columns[i - 1].HeaderText;
                                }*/

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excelApp.Cells[i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                excelApp.ActiveWorkbook.SaveCopyAs(sFileDialog.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();
                MessageBox.Show("Сохранение выполнена");

            }
            Cursor.Current = Cursors.Default;
        }
    }
}