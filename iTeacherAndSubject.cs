using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Threading.Tasks;

namespace eSchool
{
    public partial class iTeacherAndSubject : Form
    {
        public iTeacherAndSubject()
        {
            InitializeComponent();
        }
        iTeacher_iSubject iTiS = new iTeacher_iSubject();
        private void buttonReload_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iteacher_has_subject`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.DataSource = iTiS.getTeacher_Subject(command);
            dataGridView1.AllowUserToAddRows = false;
            fillTeacherKeyCombo();
            fillSubjectKeyCombo();
            fillKey(); buttonFullinfo.Text = "Развернуть";
        }
        private void iTeacherAndSubject_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iteacher_has_subject`");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = iTiS.getTeacher_Subject(command);
            dataGridView1.AllowUserToAddRows = false;
            fillTeacherKeyCombo();
            fillSubjectKeyCombo();
            fillKey();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fkT = comboBoxfkT.Text;
                string fkS = comboBoxfkS.Text;
                if (iTiS.insertTeacherSubject(fkT, fkS))
                {
                    MessageBox.Show("Новая информация о преподователья добавлен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста заполните все нужные данные", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string fkT = comboBoxfkT.Text;
                string fkS = comboBoxfkS.Text;
                int id = Convert.ToInt32(comboBoxID.Text);

                if (iTiS.updateTeacherSubject(id, fkT, fkS))
                {
                    MessageBox.Show("Данные учителя изменён", "Изменение выполнилась!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxID.Text);
                if (MessageBox.Show("Вы действительно хотите удалить эти данные?", "Удаление", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (iTiS.deleteTeacherSubject(id))
                    {
                        MessageBox.Show("Данные учителья удалён", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxID.Text = null; comboBoxfkT.Text = null; comboBoxfkS.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Такие данные не существует", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Данные учителья не удалён", "Операция отменена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Извините невозможно удалить", "Ошибка при выполнении операции", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void fillTeacherKeyCombo()
        {
            iTeacherTableDB iTeacher = new iTeacherTableDB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iteacher`");
            comboBoxfkT.DataSource = iTeacher.getTeachers(command);
            comboBoxfkT.DisplayMember = "id"; comboBoxfkT.ValueMember = "id";
            comboBoxfkT.SelectedItem = null;
            this.comboBoxfkT.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void fillSubjectKeyCombo()
        {
            iSubjectTableDB iSubject = new iSubjectTableDB();
            comboBoxfkS.DataSource = iSubject.getAllSubjects();
            comboBoxfkS.DisplayMember = "subjectName"; comboBoxfkS.ValueMember = "subjectName";
            this.comboBoxfkS.DropDownStyle = ComboBoxStyle.DropDownList; comboBoxfkS.SelectedItem = null;
        }
        void fillKey()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iteacher_has_subject`");
            comboBoxID.DataSource = iTiS.getTeacher_Subject(command);
            comboBoxID.DisplayMember = "id"; comboBoxID.ValueMember = "id";
            this.comboBoxID.DropDownStyle = ComboBoxStyle.DropDownList; comboBoxID.SelectedItem = null;
        }

        private void buttonFullinfo_Click(object sender, EventArgs e)
        {
            if (buttonFullinfo.Text == "Развернуть")
            {
                MySqlCommand command = new MySqlCommand("SELECT a.id, a.subject_fk, a.iTeacher_fk, b.name, b.patronymic, b.teacherPic FROM iteacher_has_subject a, iteacher b  WHERE a.iTeacher_fk = b.`id`");
                dataGridView1.ReadOnly = true;
                dataGridView1.RowTemplate.Height = 140;
                dataGridView1.DataSource = iTiS.fullTeacherData(command);
                dataGridView1.AllowUserToAddRows = false;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                buttonFullinfo.Text = "Свернуть";
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `iteacher_has_subject`");
                dataGridView1.ReadOnly = true; dataGridView1.RowTemplate.Height = 33;
                dataGridView1.DataSource = iTiS.getTeacher_Subject(command);
                dataGridView1.AllowUserToAddRows = false;
                fillTeacherKeyCombo();
                fillSubjectKeyCombo();
                fillKey();
                buttonFullinfo.Text = "Развернуть";
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (buttonFullinfo.Text == "Развернуть")
            {
                comboBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxfkT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBoxfkS.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                comboBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxfkT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBoxfkS.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
        void fillGrid(MySqlCommand command)
        {
            iSubjectTableDB iSubject = new iSubjectTableDB();
            dataGridView1.DataSource = iTiS.fullTeacherData(command);
        }
        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            if (buttonFullinfo.Text == "Развернуть")
            {
                string query = "SELECT * FROM `iteacher_has_subject` WHERE CONCAT(`id`,`iTeacher_fk`,`subject_fk`) LIKE '%" + textBoxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(query);
                fillGrid(command);
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

        private void buttonPrintText_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Список_учителей.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == dataGridView1.Columns.Count - 1)
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
    }
}
