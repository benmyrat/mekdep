using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSchool
{
    public partial class editStudentForm : Form
    {
        public editStudentForm()
        {
            InitializeComponent();
        }
        iStudentTableDB iStudent = new iStudentTableDB();
        private void editStudentForm_Load(object sender, EventArgs e)
        {

        }
        public bool myVerif()
        {
            if ((textBoxSurname.Text.Trim() == "") || (textBoxClassName.Text.Trim() == "") || (textBoxMobile.Text.Trim() == "") ||
                (textBoxLogin.Text.Trim() == "") || (textBoxPassword.Text.Trim() == "") ||
                (textBoxName.Text.Trim() == "") ||
                (textBoxPatronymic.Text.Trim() == "") ||
                (richTextBoxAddress.Text.Trim() == "") ||
                (pictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string patronymic = textBoxPatronymic.Text;
            string gender = "Мужчина";
            if (radioButtonFemale.Checked)
            {
                gender = "Женщина";
            }
            DateTime birthdate = dateTimePicker1.Value;
            string address = richTextBoxAddress.Text;
            string mobile = textBoxMobile.Text;
            string cName = textBoxClassName.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            MemoryStream teacherPic = new MemoryStream();

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 6 || (this_year - born_year) > 18)
            {
                MessageBox.Show("Ученик не может учиться если ему нет 6 и ему больше 18 лет", "Не правильная дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (myVerif())
            {
                pictureBoxStudentImage.Image.Save(teacherPic, pictureBoxStudentImage.Image.RawFormat);
                if (iStudent.updateStudents(id, surname, name, patronymic, gender, birthdate, address, mobile, cName, login, password, teacherPic))
                {
                    MessageBox.Show("Данные ученика изменён", "Обновления выполнилась!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (iStudent.deleteStudent(id))
                    {
                        MessageBox.Show("Данные ученика удалён", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxPatronymic.Text = ""; textBoxSurname.Text = ""; textBoxName.Text = ""; radioButtonMale.Checked = true;
                        pictureBoxStudentImage.Image = null; dateTimePicker1.Value = DateTime.Now; textBoxPassword.Text = "";
                        richTextBoxAddress.Text = ""; textBoxMobile.Text = ""; textBoxClassName.Text = ""; textBoxLogin.Text = ""; textBoxID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Данные ученика не удалён", "Операция отменена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Извините невозможно удалить", "Ошибка при выполнении операции", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDownloadPic_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            //при скачке авто данные
            svf.FileName = "Код_Ученика: " + textBoxID.Text;
            //проверяем изображение есть или нет
            if (pictureBoxStudentImage.Image == null)
            {
                MessageBox.Show("Невозможно скачать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image.Save(svf.FileName + (".") + System.Drawing.Imaging.ImageFormat.Jpeg.ToString());
            }
        }

        private void buttonUploadPic_Click(object sender, EventArgs e)
        {
            //Здесь я загружаю выбронная изображения
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.jpeg; *.gif)|*.jpg; *.png; *.jpeg; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
