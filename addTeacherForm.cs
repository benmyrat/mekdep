using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace eSchool
{
    public partial class addTeacherForm : Form
    {
        public addTeacherForm()
        {
            InitializeComponent();
        }

        public bool myVerif()
        {
            if ((textBoxSname.Text.Trim() == "") || (textBoxMail.Text.Trim() == "") || (textBoxMobile.Text.Trim() == "") ||
                (textBoxLogin.Text.Trim() == "") || (textBoxPassword.Text.Trim() == "") ||
                (textBoxName.Text.Trim() == "") ||
                (textBoxPname.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBoxTeacherImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            iTeacherTableDB iTeacher = new iTeacherTableDB();
            string surname = textBoxSname.Text;
            string name = textBoxName.Text;
            string patronymic = textBoxPname.Text;
            string gender = "Мужчина";
            if (radioButtonFemale.Checked)
            {
                gender = "Женщина";
            }
            DateTime birthdate = dateTimePicker1.Value;
            string address = textBoxAddress.Text;
            string mail = textBoxMail.Text;
            string mobile = textBoxMobile.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            MemoryStream teacherPic = new MemoryStream();

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 22 || (this_year - born_year) > 55)
            {
                MessageBox.Show("Учитель не может преподовать если ему нет 22 и ему больше 55 лет", "Не правильная дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (myVerif())
            {
                pictureBoxTeacherImage.Image.Save(teacherPic, pictureBoxTeacherImage.Image.RawFormat);
                if (iTeacher.insertTeacher(surname, name, patronymic, gender, birthdate, address, mail, mobile, login, password,teacherPic))
                {
                    MessageBox.Show("Учитель добавлен в нашу школу", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выполните все услновии", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonUploadPic_Click(object sender, EventArgs e)
        {
            //Здесь я загружаю выбронная изображения
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.jpeg; *.gif)|*.jpg; *.png; *.jpeg; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxTeacherImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPname.Text = ""; textBoxSname.Text = ""; textBoxName.Text = ""; radioButtonMale.Checked = true;
            pictureBoxTeacherImage.Image = null; dateTimePicker1.Value = DateTime.Now; textBoxPassword.Text = "";
            textBoxAddress.Text = ""; textBoxMobile.Text = ""; textBoxMail.Text = ""; textBoxLogin.Text = "";
        }

        private void textBoxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {//Запрет использование всё кроме чисел
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
