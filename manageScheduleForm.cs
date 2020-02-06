using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
namespace eSchool
{
    public partial class manageScheduleForm : Form
    {
        public manageScheduleForm()
        {
            InitializeComponent();
        }
        iScheduleTableDB iSchedule = new iScheduleTableDB();
        private void manageScheduleForm_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }
        void ReloadGrid()
        {
            dataGridView1.DataSource = iSchedule.getAll();
            dataGridView1.Columns[0].Width = 44; dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[0].HeaderText = "Код"; dataGridView1.Columns[1].HeaderText = "День";
            labelALL.Text = "Общая количество расписании: " + dataGridView1.Rows.Count;
            comboBoxDay1.DataSource = iSchedule.getAll();
            comboBoxDay1.DisplayMember = "day"; comboBoxDay1.ValueMember = "day"; comboBoxDay1.SelectedItem = null;
            comboBoxDay2.DataSource = iSchedule.getAll();
            comboBoxDay2.DisplayMember = "day"; comboBoxDay2.ValueMember = "day"; comboBoxDay2.SelectedItem = null;
            comboBoxTime1.DataSource = iSchedule.getAll();
            comboBoxTime1.DisplayMember = "startTime"; comboBoxTime1.ValueMember = "startTime"; comboBoxTime1.SelectedItem = null;
            comboBoxTime2.DataSource = iSchedule.getAll();
            comboBoxTime2.DisplayMember = "finishTime"; comboBoxTime2.ValueMember = "finishTime"; comboBoxTime2.SelectedItem = null;
            if (radioButtonDayNo.Checked)
            {
                comboBoxDay1.Enabled = false;
                comboBoxDay2.Enabled = false;
            }
            else if (radioButtonTimeNo.Checked)
            {
                comboBoxTime1.Enabled = false;
                comboBoxTime2.Enabled = false;
            }
            textBoxSearch.Text = "";
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editScheduleForm editSchedule = new editScheduleForm();
            editSchedule.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editSchedule.textBoxDay.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editSchedule.textBoxStart.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editSchedule.textBoxFinish.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            editSchedule.ShowDialog(this);
        }

        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `ischedule` WHERE CONCAT(`day`, `startTime`, `finishTime`) LIKE '%" + textBoxSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            dataGridView1.DataSource = iSchedule.getCommand(command);
            labelALL.Text = "Общая количество расписании: " + dataGridView1.Rows.Count;

        }

        private void radioButtonDayYes_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDay1.Enabled = true;
            comboBoxDay2.Enabled = true;
        }

        private void radioButtonDayNo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDay1.Enabled = false;
            comboBoxDay2.Enabled = false;
        }

        private void radioButtonTimeYes_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxTime1.Enabled = true;
            comboBoxTime2.Enabled = true;
        }

        private void radioButtonTimeNo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxTime1.Enabled = false;
            comboBoxTime2.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string query;
            if (radioButtonDayYes.Checked)
            {
                //сортировка по дате
                string day1 = comboBoxDay1.SelectedText;
                string day2 = comboBoxDay1.SelectedText;
                string time1 = comboBoxTime1.SelectedText;
                string time2 = comboBoxTime2.SelectedText;
                if (radioButtonTimeYes.Checked)
                {
                    query = "SELECT * FROM `ischedule` WHERE `day` BETWEEN '" + day1 + "' AND '" + day2 + "' AND '" + time1 + "' AND '" + time2 + "'";
                }

                else
                {
                    query = "SELECT * FROM `ischedule` WHERE `day` BETWEEN '" + day1 + "' AND '" + day2 + "'";
                }
                MySqlCommand command = new MySqlCommand(query);
                dataGridView1.DataSource = iSchedule.getCommand(command);
            }
            else
            {
                string day1 = comboBoxDay1.SelectedText;
                string day2 = comboBoxDay1.SelectedText;
                string time1 = comboBoxTime1.SelectedText;
                string time2 = comboBoxTime2.SelectedText;
                if (radioButtonDayYes.Checked)
                {
                    query = "SELECT * FROM `ischedule` WHERE `day` BETWEEN '" + day1 + "' AND '" + day2 + "' AND '" + time1 + "' AND '" + time2 + "'";
                }

                else
                {
                    query = "SELECT * FROM `ischedule` WHERE `day` BETWEEN '" + day1 + "' AND '" + day2 + "'";
                }
                MySqlCommand command = new MySqlCommand(query);
                dataGridView1.DataSource = iSchedule.getCommand(command);
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