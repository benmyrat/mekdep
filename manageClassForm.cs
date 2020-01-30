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
    public partial class manageClassForm : Form
    {
        public manageClassForm()
        {
            InitializeComponent();
        }
        iClassTableDB iClass = new iClassTableDB();
        private void manageClassForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        void fillGrid()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iclass`");
            dataGridView1.DataSource = iClass.getCommand(command);
            //Показываю кол-во учителей
            labelAllClass.Text = "Общая количество учителей: " + dataGridView1.Rows.Count;
        }

        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            string query;
            if (radioButtonYES.Checked)
            {
                query = "SELECT * FROM `iclass` WHERE `classRoom` BETWEEN '" + Convert.ToInt32(numericUpDownClass1.Value) + "' AND '" + Convert.ToInt32(numericUpDownClass2.Value) +
                    "' AND WHERE CONCAT(`classRoom`) LIKE '%" + textBoxSearch.Text + "%'";
            }
            else if (radioButtonNumberPupilYES.Checked)
            {
                query = "SELECT * FROM `iclass` WHERE `numberStudents` BETWEEN '" + Convert.ToInt32(numericUpDownNumberP1.Value) + "' AND '" + Convert.ToInt32(numericUpDownNumberP1.Value) +
                    "' AND WHERE CONCAT(`numberStudents`) LIKE '%" + textBoxSearch.Text + "%'";
            }
            else if ((radioButtonNumberPupilYES.Checked) || (radioButtonYES.Checked))
            {
                query = "SELECT * FROM `iclass` WHERE `classRoom` BETWEEN '" + Convert.ToInt32(numericUpDownClass1.Value) + "' AND '" + Convert.ToInt32(numericUpDownClass2.Value) +
                   "' AND WHERE CONCAT(`classRoom`) LIKE '%" + textBoxSearch.Text + "%'";
                query = "SELECT * FROM `iclass` WHERE `numberStudents` BETWEEN '" + Convert.ToInt32(numericUpDownNumberP1.Value) + "' AND '" + Convert.ToInt32(numericUpDownNumberP1.Value) +
                    "' AND WHERE CONCAT(`numberStudents`) LIKE '%" + textBoxSearch.Text + "%'";
            }
            query = "SELECT * FROM `iclass` WHERE CONCAT(`className`, `classRoom`, `numberStudents`) LIKE '%" + textBoxSearch.Text + "%'";

            MySqlCommand command = new MySqlCommand(query);
            dataGridView1.DataSource = iClass.getCommand(command);
            labelAllClass.Text = "Общая количество учителей: " + dataGridView1.Rows.Count;
        }

        private void radioButtonNumberPupilYES_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNumberP1.Enabled = true;
            numericUpDownNumberP2.Enabled = true;
        }

        private void radioButtonNumberPupilNo_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNumberP1.Enabled = false;
            numericUpDownNumberP2.Enabled = false;
        }

        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownClass1.Enabled = true;
            numericUpDownClass2.Enabled = true;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownClass1.Enabled = false;
            numericUpDownClass2.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            fillGrid();
            radioButtonNumberPupilNo.Checked = true;
            radioButtonNo.Checked = true;
            numericUpDownNumberP1.Value = 0; numericUpDownNumberP2.Value = 0;
            numericUpDownClass1.Value = 0; numericUpDownClass2.Value = 0;
        }
        void sortRoom()
        {//сортировка по кабинетам/*
            var cRoom1 = Convert.ToInt32(numericUpDownClass1.Value);
            var cRoom2 = Convert.ToInt32(numericUpDownClass2.Value);
            string query = "SELECT * FROM `iclass` WHERE `classRoom` BETWEEN '" + cRoom1 + "' AND '" + cRoom2 + "'";
            MySqlCommand command = new MySqlCommand(query);
            dataGridView1.DataSource = iClass.getCommand(command);
            labelAllClass.Text = "Общая количество учителей: " + dataGridView1.Rows.Count;
        }
        void sortPupil()
        {//сортировка по ученикам/*
            var cPupil1 = Convert.ToInt32(numericUpDownNumberP1.Value);
            var cPupil2 = Convert.ToInt32(numericUpDownNumberP2.Value);
            string query = "SELECT * FROM `iclass` WHERE `numberStudents` BETWEEN '" + cPupil1 + "' AND '" + cPupil2 + "'";
            MySqlCommand command = new MySqlCommand(query);
            dataGridView1.DataSource = iClass.getCommand(command);
            labelAllClass.Text = "Общая количество учителей: " + dataGridView1.Rows.Count;
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (radioButtonYES.Checked)
            {
                sortRoom();
            }
            else if (radioButtonNumberPupilYES.Checked)
            {
                sortPupil();
            }
            else if ((radioButtonNumberPupilYES.Checked) || (radioButtonYES.Checked))
            {
                sortPupil(); sortRoom();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editClassForm editClass = new editClassForm();
            editClass.comboBoxClassName.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editClass.numericUpDownClassRoom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editClass.numericUpDownNumberPupil.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editClass.ShowDialog(this);
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
        private void buttonPrintWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        private void buttonPrintExcel_Click(object sender, EventArgs e)
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
