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
using Word = Microsoft.Office.Interop.Word;

namespace eSchool
{
    public partial class manageStudentForm : Form
    {
        public manageStudentForm()
        {
            InitializeComponent();
        }
        iStudentTableDB iStudent = new iStudentTableDB();
        public void fillGrid(MySqlCommand command)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 160;
            dataGridView1.DataSource = iStudent.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            labelALL.Text = "Общая количество учеников: " + dataGridView1.Rows.Count;
            iClassTableDB iClass = new iClassTableDB();
            comboBoxClassName1.DataSource = iClass.getCommand(new MySqlCommand("SELECT * FROM `iclass`"));
            comboBoxClassName1.ValueMember = "className"; comboBoxClassName1.DisplayMember = "className";
            comboBoxClassName2.DataSource = iClass.getCommand(new MySqlCommand("SELECT * FROM `iclass`"));
            comboBoxClassName2.ValueMember = "className"; comboBoxClassName2.DisplayMember = "className";
        }

        private void manageStudentForm_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent`"));
            if (radioButtonBdateNo.Checked || radioButtonClassNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                comboBoxClassName1.Enabled = false;
                comboBoxClassName2.Enabled = false;
            }
        }

        private void radioButtonBdateYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButtonBdateNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonClassYes_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxClassName1.Enabled = true;
            comboBoxClassName2.Enabled = true;
        }

        private void radioButtonClassNo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxClassName1.Enabled = false;
            comboBoxClassName2.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            radioButtonClassNo.Checked = true;
            radioButtonBdateNo.Checked = true;
            radioButtonALL.Checked = true;
            comboBoxClassName1.Text = "";
            comboBoxClassName2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBoxSearch.Text = "";
            fillGrid(new MySqlCommand("SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent`"));
            button.Text = "Развернуть";
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (button.Text == "Развернуть")
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `istudent`");
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 130;
                dataGridView1.DataSource = iStudent.getStudents(command);

                picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                labelALL.Text = "Общая количество учеников: " + dataGridView1.Rows.Count;
                button.Text = "Свернуть";
            }
            else if (button.Text == "Свернуть")
            {
                fillGrid(new MySqlCommand("SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent`"));
                button.Text = "Развернуть";
            }
        }

        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            string query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent` WHERE CONCAT(`surName`, `name`, `patronymic`, `className_fk`) LIKE '%" + textBoxSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string query;
            MySqlCommand command;

            if (radioButtonBdateYes.Checked)
            {
                //сортировка по дате
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (radioButtonMale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent` WHERE `birthDate` BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Мужчина'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent` WHERE `birthDate` BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Женщина'";
                }
                else
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent` WHERE `birthDate` BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }
                command = new MySqlCommand(query);
                fillGrid(command);
            }
            else if (radioButtonClassYes.Checked)
            {
                var cName1 = Convert.ToInt32(comboBoxClassName1.Text);
                var cName2 = Convert.ToInt32(comboBoxClassName2.Text);
                if (radioButtonMale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent` WHERE `className_fk` BETWEEN '" + cName1 + "' AND '" + cName2 + "' AND gender='Мужчина'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent` WHERE `className_fk` BETWEEN '" + cName1 + "' AND '" + cName2 + "' AND gender='Женщина'";
                }
                else
                {
                    query = "SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `className_fk`,`studentPic` FROM `istudent` WHERE `className_fk` BETWEEN '" + cName1 + "' AND '" + cName2 + "'";
                }
                command = new MySqlCommand(query);
                fillGrid(command);
            }
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
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table style 
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "ТУТ ТИТУЛ";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }
        private void buttonPrintDocx_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        private void buttonPrintXlsx_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFileDialog = new SaveFileDialog();
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

