using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace eSchool
{
    public partial class listTeacherForm : Form
    {
        public listTeacherForm()
        {
            InitializeComponent();
        }
        iTeacherTableDB iTeacher = new iTeacherTableDB();
        private void listTeacherForm_Load(object sender, EventArgs e)
        {
            //тут список учителей будет
            MySqlCommand command = new MySqlCommand("SELECT * FROM `iteacher`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 150;
            dataGridView1.DataSource = iTeacher.getTeachers(command);
            //11 колонка для изображения
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editTeacherForm editTeacher = new editTeacherForm();
            editTeacher.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editTeacher.textBoxSname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editTeacher.textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editTeacher.textBoxPname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //пол
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Женский")
            {
                editTeacher.radioButtonFemale.Checked = true;
            }
            editTeacher.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            editTeacher.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            editTeacher.textBoxMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            editTeacher.textBoxMobile.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            editTeacher.textBoxLogin.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            editTeacher.textBoxPassword.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            //тут изображение
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            editTeacher.pictureBoxTeacherImage.Image = Image.FromStream(picture);
            editTeacher.ShowDialog(this);
        }
    }
}
