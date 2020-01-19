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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTeacherForm addTeacher = new addTeacherForm();
            //addTeacher.ShowDialog();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name== "addTeacherForm")
                {
                    exit = true;
                }
            }
            if (exit==false)
            {
                addTeacher.MdiParent = this;
                addTeacher.Show();
            }
        }

        private void посмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listTeacherForm listTeacher = new listTeacherForm();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "addTeacherForm")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                listTeacher.MdiParent = this;
                listTeacher.Show();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editTeacherForm editTeacher = new editTeacherForm();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "addTeacherForm")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                editTeacher.MdiParent = this;
                editTeacher.Show();
            }
        }
    }
}
