using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace eSchool
{
    public partial class fullStudentsListForm : Form
    {
        public fullStudentsListForm()
        {
            InitializeComponent();
        }
        iStudentTableDB iStudent = new iStudentTableDB();
        private void fullStudentsListForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        void fillGrid()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `istudent`");
            dataGridView1.DataSource = iStudent.getCommand(command);
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 150;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].Width = 122;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].Width = 122;
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].Width = 133;
            dataGridView1.Columns[3].HeaderText = "Отчества";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[8].HeaderText = "Класс";
            dataGridView1.Columns[8].Width = 50;
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editStudentForm editStudent = new editStudentForm();
            editStudent.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editStudent.textBoxSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editStudent.textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editStudent.textBoxPatronymic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //пол
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Женский")
            {
                editStudent.radioButtonMale.Checked = false;
                editStudent.radioButtonFemale.Checked = true;
            }
            editStudent.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            editStudent.richTextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            editStudent.textBoxMobile.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            editStudent.textBoxClassName.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            editStudent.textBoxLogin.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            editStudent.textBoxPassword.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            //тут изображение
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            editStudent.pictureBoxStudentImage.Image = Image.FromStream(picture);
            editStudent.ShowDialog(this);
        }

        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `istudent` WHERE CONCAT(`surName`, `name`, `patronymic`, `address`, `login`, `className_fk`) LIKE '%" + textBoxSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            dataGridView1.DataSource = iStudent.getCommand(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 150;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}
