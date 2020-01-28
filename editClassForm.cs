using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
namespace eSchool
{
    public partial class editClassForm : Form
    {
        public editClassForm()
        {
            InitializeComponent();
        }
        iClassTableDB iClass = new iClassTableDB();
        bool checkEmpty()
        {
            if ((textBoxNewClassName.Text.Trim() == "") || (comboBoxClassName.Text.Trim() == "") || (numericUpDownClassRoom.Value <= 10) || (numericUpDownNumberPupil.Value <= 25))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void fillCombo()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iclass`");
            comboBoxClassName.DataSource = iClass.getCommand(command);
            comboBoxClassName.DisplayMember = "className";
            comboBoxClassName.ValueMember = "className";
            comboBoxClassName.SelectedItem = null;
            this.comboBoxClassName.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxNewClassName.Text = "";
            textBoxNewClassName.Visible = false;
        }
        private void editClassForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            textBoxNewClassName.Visible = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string nName = textBoxNewClassName.Text;
            string cName = comboBoxClassName.Text;
            int cRoom = Convert.ToInt32(numericUpDownClassRoom.Value);
            int nPupil = Convert.ToInt32(numericUpDownNumberPupil.Value);
            if (checkEmpty())
            {
                if (iClass.updateClass(nName, cName, cRoom, nPupil))
                {
                    MessageBox.Show("Данные о классе изменён", "Изменение выполнилась!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillCombo();
                }
                else
                {
                    MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxNewClassName.Text = "";
                    textBoxNewClassName.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Выполните все услновии", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNewClassName.Visible = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string cName = comboBoxClassName.Text;
                if (comboBoxClassName.Text.Trim()!="")
                {
                    if (iClass.deleteClass(cName))
                    {
                        MessageBox.Show("Выбранный класс удален из списка");
                        fillCombo();
                    }
                    else
                    {
                        MessageBox.Show("Выбранный класс удален из списка");
                    }
                }
                else
                {
                    MessageBox.Show("Чтобы удалить класс, выберите хотя бы имя класса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка в системе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
