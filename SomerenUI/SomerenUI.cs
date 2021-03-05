using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); 
                    List<Student> studentList = studService.GetStudents(); 

                    // clear the listview before filling it again
                    listViewStudents.Clear();
                    listViewStudents.View = View.Details; // Enable rows
                    listViewStudents.Columns.Add("Student ID"); // Add colums
                    listViewStudents.Columns.Add("First Name");
                    listViewStudents.Columns.Add("Last Name");
                    listViewStudents.Columns.Add("Date Of Birth");

                    foreach (Student s in studentList)
                    {
                        ListViewItem li1 = new ListViewItem(new String[] { s.Number.ToString(), s.FirstName, s.LastName, s.BirthDate.ToString() });
                        listViewStudents.Items.Add(li1);
                    }
                    listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void listviewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
