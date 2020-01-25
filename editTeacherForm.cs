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
    public partial class editTeacherForm : Form
    {
        public editTeacherForm()
        {
            InitializeComponent();
        }

        iTeacherTableDB iTeacher = new iTeacherTableDB();
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
        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
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
                if (iTeacher.updateTeachers(id, surname, name, patronymic, gender, birthdate, address, mail, mobile, login, password, teacherPic))
                {
                    MessageBox.Show("Данные учителя изменён", "Обновления выполнилась!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                //запрос потверждении удалении
                if (MessageBox.Show("Вы действительно хотите удалить эти данные?", "Удаление", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (iTeacher.deleteTeacher(id))
                    {
                        MessageBox.Show("Учитель удалён", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxPname.Text = ""; textBoxSname.Text = ""; textBoxName.Text = ""; radioButtonMale.Checked = true;
                        pictureBoxTeacherImage.Image = null; dateTimePicker1.Value = DateTime.Now; textBoxPassword.Text = "";
                        textBoxAddress.Text = ""; textBoxMobile.Text = ""; textBoxMail.Text = ""; textBoxLogin.Text = ""; textBoxID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Учитель не удалён", "Операция отменена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Извините невозможно удалить", "Ошибка при выполнении операции", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                databaseConnection db = new databaseConnection();
                MySql.Data.MySqlClient.MySqlCommand command = new MySqlCommand("SELECT `id`, `surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `login`, `pass`, `teacherPic` FROM `iteacher` WHERE `id`=" + id, db.getConnection);
                DataTable table = iTeacher.getTeachers(command);
                if (table.Rows.Count > 0)
                {
                    textBoxID.Text = table.Rows[0]["id"].ToString();
                    textBoxSname.Text = table.Rows[0]["surName"].ToString();
                    textBoxName.Text = table.Rows[0]["name"].ToString();
                    textBoxPname.Text = table.Rows[0]["patronymic"].ToString();
                    //пол
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }

                    dateTimePicker1.Value = (DateTime)table.Rows[0]["birthDate"];

                    textBoxAddress.Text = table.Rows[0]["address"].ToString();
                    textBoxMail.Text = table.Rows[0]["mail"].ToString();
                    textBoxMobile.Text = table.Rows[0]["mobile"].ToString();
                    textBoxLogin.Text = table.Rows[0]["login"].ToString();
                    textBoxPassword.Text = table.Rows[0]["pass"].ToString();
                    //тут его фотка
                    byte[] pic = (byte[])table.Rows[0]["teacherPic"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxTeacherImage.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Извините но такой код в нашей базе нету", "Ошибка в поисках", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Извините но такой код в нашей базе нету", "Ошибка в поисках", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Запрет использование всё кроме чисел
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Запрет использование всё кроме чисел
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonDownloadPic_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            //при скачке авто данные
            svf.FileName = "Код_учителья: " + textBoxID.Text;
            //проверяем изображение есть или нет
            if (pictureBoxTeacherImage.Image == null)
            {
                MessageBox.Show("Невозможно скачать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxTeacherImage.Image.Save(svf.FileName + (".") + System.Drawing.Imaging.ImageFormat.Jpeg.ToString());
            }
        }
    }
}
