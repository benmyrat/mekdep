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
    public partial class manageScheduleForm : Form
    {
        public manageScheduleForm()
        {
            InitializeComponent();
        }
        iScheduleTableDB iSchedule = new iScheduleTableDB();
        private void manageScheduleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = iSchedule.getAll();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editScheduleForm editSchedule = new editScheduleForm();
            editSchedule.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editSchedule.textBoxDay.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editSchedule.textBoxStart.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editSchedule.textBoxFinish.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            editSchedule.ShowDialog(this);
        }
    }
}
