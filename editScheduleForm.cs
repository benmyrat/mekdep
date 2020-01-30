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
    public partial class editScheduleForm : Form
    {
        public editScheduleForm()
        {
            InitializeComponent();
        }
        iScheduleTableDB iSchedule = new iScheduleTableDB();
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            if (iSchedule.deleteSchedule(id))
            {
                MessageBox.Show("Расписание удалён", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string day = textBoxDay.Text;
            string sTime = textBoxStart.Text;
            string fTime = textBoxFinish.Text;

            if (iSchedule.updateSchedule(id, day, sTime, fTime))
            {
                MessageBox.Show("Данная расписание изменилась", "Обновления выполнилась!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Извините что-то не так", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
