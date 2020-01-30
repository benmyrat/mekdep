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
    public partial class addScheduleForm : Form
    {
        public addScheduleForm()
        {
            InitializeComponent();
        }
        iScheduleTableDB iSchedule = new iScheduleTableDB();
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxDay.Text = "";
            textBoxStart.Text = "";
            textBoxFinish.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string day = textBoxDay.Text;
                string sTime = textBoxStart.Text;
                string fTime = textBoxFinish.Text;

                if (iSchedule.insertSchedule(day, sTime, fTime))
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
}
