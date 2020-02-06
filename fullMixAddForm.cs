using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
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
            //SELECT a.id, b. surName,b.name, b.patronymic FROM iteacher_has_subject a, iteacher b WHERE a.iTeacher_fk=b.id AND a.id=29

           // var x = (Teacher)(comboBoxTeacherSubject.SelectedValue);
            comboBoxTeacherSubject.DataSource = 
                iT_iS.getTeacher_Subject(new MySqlCommand("SELECT * FROM `iTeacher_has_subject`"));
            comboBoxTeacherSubject.ValueMember = "id";
            comboBoxTeacherSubject.DisplayMember = "id";
            comboBoxTeacherSubject.SelectedItem = null;
            comboBoxClassName.DataSource = iClass.getCommand(new MySqlCommand("SELECT * FROM `iclass`"));
            comboBoxClassName.ValueMember = "className"; 
            comboBoxClassName.DisplayMember = "className";
            comboBoxClassName.SelectedItem = null;
            comboBoxScheduleD.DataSource = 
                fullMix.getFullMixCommand(new MySqlCommand("SELECT * FROM `ischedule`"));
            comboBoxScheduleD.ValueMember = "id"; 
            comboBoxScheduleD.DisplayMember = "id";
            comboBoxScheduleD.SelectedItem = null;
        }

        private void comboBoxTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxTS.DataSource = new object();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string tS = comboBoxTeacherSubject.Text;
                string cName = comboBoxClassName.Text;
                string time = comboBoxScheduleD.Text;

                if (iSchedule.insertSchedule(tS, cName, time))
                {
                    MessageBox.Show("Расписание добавлен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
    class Teacher
    {
        int id;
        string Name;
        string SName;
        string Patronic;

    }
}