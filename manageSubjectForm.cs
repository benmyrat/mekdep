using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSchool
{
    public partial class manageSubjectForm : Form
    {
        public manageSubjectForm()
        {
            InitializeComponent();
        }
        iSubjectTableDB iSubject = new iSubjectTableDB();
        int pos;
        private void manageSubjectForm_Load(object sender, EventArgs e)
        {
            reloadListBoxSubjects();
            comboBoxSubjcets.Enabled = false;
        }
        void updateEverything()
        {
            listBoxSubjects.DataSource = iSubject.getAllSubjects();
            listBoxSubjects.ValueMember = "subjectName";
            listBoxSubjects.DisplayMember = "subjectName";
            listBoxSubjects.SelectedItem = null;
            comboBoxSubjcets.Text = "";
            textBoxSname.Text = "";
            richTextBoxSdescription.Text = "";
        }
        public void reloadListBoxSubjects()
        {
            updateEverything();
            labelSub.Text = "Общая количество предметов: " + iSubject.totalSubject();
        }
        void ShowData(int index)
        {
            DataRow dr = iSubject.getAllSubjects().Rows[index];
            comboBoxSubjcets.Text = dr.ItemArray[0].ToString();
            textBoxSname.Text = dr.ItemArray[0].ToString();
            richTextBoxSdescription.Text = dr.ItemArray[1].ToString();
            listBoxSubjects.SelectedIndex = pos;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowData(pos);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                ShowData(pos);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < iSubject.getAllSubjects().Rows.Count - 1)
            {
                pos = pos + 1;
                ShowData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = iSubject.getAllSubjects().Rows.Count - 1;
            ShowData(pos);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            updateEverything();
        }
        private void listBoxSubjects_Click(object sender, EventArgs e)
        {
            try
            {
                pos = listBoxSubjects.SelectedIndex;
                ShowData(pos);
            }
            catch
            {
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string sName = textBoxSname.Text;
            string sDescription = richTextBoxSdescription.Text;
            if (sName.Trim() == "")
            {
                MessageBox.Show("Дайте названию предмета", "Выполните все нужные условие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (iSubject.checkSubjectName(sName))
            {
                if (iSubject.insertSubject(sName, sDescription))
                {
                    MessageBox.Show("Предмет добавлен в список", "Операция выполнена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxSubjects();
                }
                else
                {
                    MessageBox.Show("Предмет не добавлен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Такой предмет уже существует", "Извините операция не выполнена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                string sName = Convert.ToString(comboBoxSubjcets.Text);
                if (MessageBox.Show("Вы действительно хотите удалить выбранное?", "Потвердите ваше решение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (iSubject.deleteSubject(sName))
                    {
                        MessageBox.Show("Удаление завершена", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxSubjects();
                    }
                    else
                    {
                        MessageBox.Show("Извините где-то есть ошибки", "Операция не выполнена", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в системе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditSubject_Click(object sender, EventArgs e)
        {
            try
            {
                string name = comboBoxSubjcets.Text;
                string sName = textBoxSname.Text;
                string sDescription = richTextBoxSdescription.Text;
                if (sName.Trim() != "")
                {
                    if (!iSubject.checkSubjectName(sName))
                    {
                        MessageBox.Show("Такое название предметы уже существует, выберите другое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (iSubject.updateSubjects(name, sName, sDescription))
                    {
                        MessageBox.Show("Дисциплина успешно изменилась!", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxSubjects();
                    }
                    else
                    {
                        MessageBox.Show("Извините дисциплину не смогли изменить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { MessageBox.Show("Выберите хотя бы один предмет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            pos = 0;
        }
    }
}
