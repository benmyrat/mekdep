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
    public partial class addClassForm : Form
    {
        public addClassForm()
        {
            InitializeComponent();
        }
        iClassTableDB iClass = new iClassTableDB();
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxClassName.Text = "";
            numericUpDownClassRoom.Value = 10;
            numericUpDownNumberPupil.Value = 25;
        }
        bool checkEmpty()
        {
            if ((textBoxClassName.Text.Trim() == "") || (numericUpDownClassRoom.Value <= 10) || (numericUpDownNumberPupil.Value <= 25))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string cName = textBoxClassName.Text;
                int cRoom = Convert.ToInt32(numericUpDownClassRoom.Value);
                int nPupil = Convert.ToInt32(numericUpDownNumberPupil.Value);
                if (checkEmpty())
                {
                    if (iClass.insertClass(cName, cRoom, nPupil))
                    {
                        MessageBox.Show("Класс добавлен в нашу школу", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Название класса не может быть пустым, номер класса не может быть меньше 10 и количество учеников " +
                        "в классе не может быть меньше 26", "Внимание выполните все условии!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Выберите другое название класса");
            }
        }
    }
}
