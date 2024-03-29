﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void enabled_menu()
        {
            btn_login .Text = "Logout";
            btn_students .Enabled = true;
            btn_students.Text= "Manage Students";
            btn_students.Visible = true;
            btn_course .Enabled = true;
            btn_course.Text= "Manage Courses";
            btn_course.Visible = true;
            btn_grades .Enabled = true;
            btn_grades.Text= "Manage Grades";
            btn_grades.Visible = true;
            btn_curriculumn .Enabled = true;
            btn_curriculumn.Text= "Manage Curriculumn";
            btn_curriculumn.Visible = true;
            btn_users .Enabled = true;
            btn_users.Text = "Manage Users";
            btn_users.Visible = true;
            btn_reports .Enabled = true;
            btn_reports.Text = "Generate Reports (ISSUE PRESENT!)";
            btn_reports.Visible = true;
            btn_find .Enabled = true;
            btn_find.Text = "Find Students";
            btn_find.Visible = true;
            btn_prerequisite.Enabled = true;
            btn_prerequisite.Text = "Manage Pre-Requisites";
            btn_prerequisite.Visible = true;
        }

        public void disabled_menu()
        {
            btn_login.Text = "Login";
            btn_students.Text = "";
            btn_course.Text = "";
            btn_grades.Text = "";
            btn_curriculumn.Text = "";
            btn_users.Text = "";
            btn_reports.Text = "";
            btn_find.Text = "";
            btn_prerequisite.Text = "";
            btn_students.Enabled = false;
            btn_course.Enabled = false;
            btn_grades.Enabled = false;
            btn_curriculumn.Enabled = false;
            btn_users.Enabled = false;
            btn_reports.Enabled = false;
            btn_find.Enabled = false;
            btn_prerequisite.Enabled = false ;
            btn_students.Visible = false;
            btn_course.Visible = false;
            btn_grades.Visible = false;
            btn_curriculumn.Visible = false;
            btn_users.Visible = false;
            btn_reports.Visible = false;
            btn_find.Visible = false;
            btn_prerequisite.Visible = false;
        }


        private void closefrm()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Close();

            }
        }
        private void showfrm(Form frm,Button btn)
        {
            lblmenu.Left = btn.Left;
            lblmenu.Height = btn.Height;
            lblmenu.Location = btn.Location;

            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();


        }

        private void hover(Button btn,EventArgs e)
        {
            btn.BackColor = Color.Red;
        }

        private void leave(Button btn, EventArgs e)
        {
            btn.BackColor = Color.Transparent ;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();
        }
 

        private void btn_students_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmStudent(), btn_students);
              
        }

        private void btn_grades_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmGrades (), btn_grades);
        }

        private void btn_curriculumn_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmSubjects(),btn_curriculumn);
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmCourse (),btn_course);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmUsers (),btn_users);
        }

        private void btn_prerequisite_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmPreRequisite (),btn_prerequisite);
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmReports (),btn_reports);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmFinstudents (),btn_find);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (btn_login.Text == "Login")
            {
                closefrm();
            }
            else
            {
                disabled_menu();
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Form1")
                        Application.OpenForms[i].Close();
                }
            }
            showfrm(new frmLogin(this), btn_login);
        }

        private void btn_students_MouseHover(object sender, EventArgs e)
        {
            hover(btn_students, e);
        }

        private void btn_students_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_students, e);
        }

        private void btn_grades_MouseHover(object sender, EventArgs e)
        {
            hover(btn_grades, e);
        }

        private void btn_grades_MouseLeave(object sender, EventArgs e)
        {
            leave (btn_grades , e);
        }

        private void btn_curriculumn_MouseHover(object sender, EventArgs e)
        {
            hover(btn_curriculumn, e);
        }

        private void btn_curriculumn_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_curriculumn, e);
        }

        private void btn_course_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_course, e);
        }
 

        private void btn_users_MouseHover(object sender, EventArgs e)
        {
            hover(btn_users, e);
        }

        private void btn_users_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_users, e);
        }

        private void btn_prerequisite_MouseHover(object sender, EventArgs e)
        {
            hover(btn_prerequisite, e);
        }

        private void btn_prerequisite_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_prerequisite, e);
        }

        private void btn_reports_MouseHover(object sender, EventArgs e)
        {
            hover(btn_reports, e);
        }

        private void btn_reports_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_reports, e);
        }

        private void btn_find_MouseHover(object sender, EventArgs e)
        {
            hover(btn_find, e);
        }

        private void btn_find_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_find, e);
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            hover(btn_login, e);
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            leave(btn_login, e);

        }

        private void btn_course_MouseHover(object sender, EventArgs e)
        {
            hover (btn_course, e);
        }
    } 
}
