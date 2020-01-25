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
    public partial class statisticTeacherForm : Form
    {
        public statisticTeacherForm()
        {
            InitializeComponent();
        }
       
        private void statisticTeacherForm_Load(object sender, EventArgs e)
        {//показываем кол-во учителей
            iTeacherTableDB iTeacher = new iTeacherTableDB();
            double totalTeacher = Convert.ToDouble(iTeacher.totalTeacher());
            double totalMale = Convert.ToDouble(iTeacher.totalMale());
            double totalFemale = Convert.ToDouble(iTeacher.totalFemale());

            double malePercentage = totalMale * 100 / totalMale;
            double femalePercentage = totalFemale * 100 / totalFemale;
            labelTotal.Text = "Общая количество учителей: " + totalTeacher.ToString();
            labelMale.Text = "Мужчины: " + malePercentage.ToString("0.00") + "%";
            labelFemale.Text = "Женщины: " + femalePercentage.ToString("0.00") + "%";
        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.Snow;
            labelTotal.ForeColor = Color.Black;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.Black;
            labelTotal.ForeColor = Color.Snow;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.Snow;
            labelMale.ForeColor = Color.Navy;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.Navy;
            labelMale.ForeColor = Color.Snow;
        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.Snow;
            labelFemale.ForeColor = Color.Crimson;
        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.Crimson;
            labelFemale.ForeColor = Color.Snow;
        }
    }
}
