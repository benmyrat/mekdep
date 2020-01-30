using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace eSchool
{
    public partial class addStudentForm : Form
    {
        public addStudentForm()
        {
            InitializeComponent();
        }
        iStudentTableDB iStudent = new iStudentTableDB();
        void fillCombo()
        {
            iClassTableDB iClass = new iClassTableDB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iclass`");
            comboBoxCname.DataSource = iClass.getCommand(command);
            comboBoxCname.DisplayMember = "className";
            comboBoxCname.ValueMember = "className";
            comboBoxCname.SelectedItem = null;
            this.comboBoxCname.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void addStudentForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.jpeg; *.gif)|*.jpg; *.png; *.jpeg; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = ""; textBoxSurname.Text = ""; textBoxName.Text = ""; textBoxPatronymic.Text = "";
            radioButtonMale.Checked = true; textBoxMobile.Text = ""; richTextBoxAddress.Text = ""; comboBoxCname.SelectedItem = null;
            textBoxPassword.Text = ""; dateTimePicker1.Value = DateTime.Now; pictureBoxStudentImage.Image = null;
        }
        public bool myVerif()
        {
            if ((textBoxSurname.Text.Trim() == "") || (comboBoxCname.SelectedValue.ToString() == "") || (textBoxMobile.Text.Trim() == "") ||
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string sName = textBoxSurname.Text;
            string Name = textBoxName.Text;
            string pName = textBoxPatronymic.Text;
            string gender = "Мужской";
            if (radioButtonFemale.Checked)
            {
                gender = "Женский";
            }
            DateTime birthdate = dateTimePicker1.Value;
            string address = richTextBoxAddress.Text;
            string mobile = textBoxMobile.Text;
            string cName = comboBoxCname.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            MemoryStream teacherPic = new MemoryStream();
            int bDate = dateTimePicker1.Value.Year;
            int nDate = DateTime.Now.Year;
            if ((nDate - bDate) < 6 || (nDate - bDate) > 18)
            {
                MessageBox.Show("Ученик не может учиться если ему нет 6 и ему больше 18 лет", "Не правильная дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (myVerif())
            {
                pictureBoxStudentImage.Image.Save(teacherPic, pictureBoxStudentImage.Image.RawFormat);
                if (iStudent.insertStudent(sName, Name, pName, gender, birthdate, address, mobile, cName, login, password, teacherPic))
                {
                    MessageBox.Show("Ученик добавлен в нашу школу", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
