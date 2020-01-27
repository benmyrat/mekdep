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
    public partial class addSubjectForm : Form
    {
        public addSubjectForm()
        {
            InitializeComponent();
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            string sName = textBoxSubjectName.Text;
            string sDescription = richTextBoxSubjcetDescription.Text;

            iSubjectTableDB iSubject = new iSubjectTableDB();
            if (textBoxSubjectName.Text == "")
            {
                MessageBox.Show("Добавьте название предмета", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (iSubject.checkSubjectName(sName))
            {
                if (iSubject.insertSubject(sName, sDescription))
                {
                    MessageBox.Show("Дисциплина успешно добавилась!", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Извините дисциплину не смогли добавить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Такой предмет уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
