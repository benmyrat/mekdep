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
                if (this.MdiChildren[i].Name == "addTeacherForm")
                {
                    exit = true;
                }
            }
            if (exit == false)
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

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisticTeacherForm statisticTeacher = new statisticTeacherForm();
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
                statisticTeacher.MdiParent = this;
                statisticTeacher.Show();
            }
        }

        private void управлятьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageTeacherForm manageTeacher = new manageTeacherForm();
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
                manageTeacher.MdiParent = this;
                manageTeacher.Show();
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addSubjectForm addSubject = new addSubjectForm();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "addSubjectForm")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                addSubject.MdiParent = this;
                addSubject.Show();
            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editsubjectForm editsubject = new editsubjectForm();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "editsubject")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                editsubject.MdiParent = this;
                editsubject.Show();
            }
        }

        private void управлятьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            manageSubjectForm manageSubject = new manageSubjectForm();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "manageSubjectForm")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                manageSubject.MdiParent = this;
                manageSubject.Show();
            }
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printSubjects printSubjects = new printSubjects();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "printSubjects")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                printSubjects.MdiParent = this;
                printSubjects.Show();
            }
        }

        private void дополнительноОПрепедователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iTeacherAndSubject teacherAndSubject = new iTeacherAndSubject();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "teacherAndSubject")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                teacherAndSubject.MdiParent = this;
                teacherAndSubject.Show();
            }
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addClassForm addClass = new addClassForm();
            bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "addClass")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                addClass.MdiParent = this;
                addClass.Show();
            }
        }

        private void изменитToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editClassForm editClass = new editClassForm(); bool exit = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "editClass")
                {
                    exit = true;
                }
            }
            if (exit == false)
            {
                editClass.MdiParent = this;
                editClass.Show();
            }
        }
    }
}
