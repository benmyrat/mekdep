using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSchool
{
    public partial class fullMixAddForm : Form
    {
        public fullMixAddForm()
        {
            InitializeComponent();
        }
        fullMix fullMix = new fullMix(); iClassTableDB iClass = new iClassTableDB();
        iTeacher_iSubject iT_iS = new iTeacher_iSubject(); iScheduleTableDB iSchedule = new iScheduleTableDB();
        private void fullMixAddForm_Load(object sender, EventArgs e)
        {
            comboBoxTsubject.DataSource = iT_iS.getTeacher_Subject(new MySqlCommand("SELECT * FROM `iteacher_has_subject`"));
            comboBoxTsubject.ValueMember = "id";
            comboBoxTsubject.DisplayMember = "id"; comboBoxTsubject.SelectedItem = null;
            comboBoxSchedule.DataSource = iSchedule.getCommand(new MySqlCommand("SELECT * FROM `ischedule`"));
            comboBoxSchedule.ValueMember = "id"; comboBoxSchedule.DisplayMember = "id"; comboBoxSchedule.SelectedItem = null;
            comboBoxCname.DataSource = iClass.getCommand(new MySqlCommand("SELECT * FROM `iclass`"));
            comboBoxCname.ValueMember = "className"; comboBoxCname.DisplayMember = "className"; comboBoxCname.SelectedItem = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int tSubject = Convert.ToInt32(comboBoxTsubject.SelectedValue.ToString());
            string cName = comboBoxCname.SelectedText;
            int schedule = Convert.ToInt32(comboBoxSchedule.SelectedText);
            if (fullMix.insertFULL(tSubject, cName, schedule))
            {
                MessageBox.Show("DONE");
            }
            

        }
    }
}
