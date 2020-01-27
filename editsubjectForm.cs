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
    public partial class editsubjectForm : Form
    {
        public editsubjectForm()
        {
            InitializeComponent();
        }
        iSubjectTableDB iSubject = new iSubjectTableDB();
        public void fillCombo()
        {
            comboBoxSubjcets.DataSource = iSubject.getAllSubjects();
            comboBoxSubjcets.DisplayMember = "subjectName";
            comboBoxSubjcets.ValueMember = "subjectName";
        }
        private void editsubjectForm_Load(object sender, EventArgs e)
        {//заполняем название предметов в комбобокс
            fillCombo();
            this.comboBoxSubjcets.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxSubjcets_SelectedIndexChanged(object sender, EventArgs e)
        {//показ данных выбронного
            try
            {
                string sName = Convert.ToString(comboBoxSubjcets.SelectedValue);
                DataTable table = new DataTable();
                table = iSubject.getSubjectByName(sName);
                textBoxSname.Text = table.Rows[0][0].ToString();
                richTextBoxSdescription.Text = table.Rows[0][1].ToString();
            }
            catch { }
        }

        private void buttonDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                string sName = Convert.ToString(comboBoxSubjcets.SelectedValue);
                if (MessageBox.Show("Вы действительно хотите удалить выбранное?", "Потвердите ваше решение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (iSubject.deleteSubject(sName))
                    {
                        MessageBox.Show("Удаление завершена", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCombo();
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
                //изменяем
                string name = Convert.ToString(comboBoxSubjcets.SelectedValue);
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
                        fillCombo();
                    }
                    else
                    {
                        MessageBox.Show("Извините дисциплину не смогли изменить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { MessageBox.Show("Выберите хотя бы один предмет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}