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
        DrinkService drinkService;
        StudentService studentService;
        ReportService reportService;
        ActivityService activityService;

        public SomerenUI()
        {
            InitializeComponent();

            drinkService = new DrinkService();
            studentService = new StudentService();
            reportService = new ReportService();
            activityService = new ActivityService();

            //make the delete button unable to use untill an item is selected and hide the label until there is an error
            btnDeleteDrink.Enabled = false;
            btnRemoveActivity.Enabled = false;
            lbl_Error.Visible = false;
            lblCaution.Visible = false;
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
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlActivity.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlActivity.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();

                    // clear the listview before filling it again
                    listViewStudents.Clear();
                    //set the view to show details
                    listViewStudents.View = View.Details;
                    //creating columnss for items
                    listViewStudents.Columns.Add("Student ID");
                    listViewStudents.Columns.Add("First Name");
                    listViewStudents.Columns.Add("Last Name");
                    listViewStudents.Columns.Add("Date Of Birth");

                    foreach (Student s in studentList)
                    {
                        ListViewItem li1 = new ListViewItem(new String[] { s.Number.ToString(), s.FirstName, s.LastName, s.BirthDate.ToString("dd/MM/yyyy") });//creating the items we need
                        listViewStudents.Items.Add(li1);
                    }
                    listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Auto resize headers to fit
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message); //error messages are showed in a separate window
                }
            }
            else if (panelName == "Lecturers")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlActivity.Hide();

                // show teachers
                pnlTeachers.Show();

                try
                {
                    // fill the teachers listview within the teachers panel with a list of teachers
                    TeacherService teacherService = new TeacherService();
                    List<Teacher> teacherList = teacherService.GetTeachers();

                    // clear the listview before filling it again
                    listviewTeachers.Clear();
                    listviewTeachers.View = View.Details; // Enable rows
                    listviewTeachers.Columns.Add("Teacher ID"); // Add colums
                    listviewTeachers.Columns.Add("First Name");
                    listviewTeachers.Columns.Add("Last Name");
                    listviewTeachers.Columns.Add("Supervisor");

                    foreach (Teacher t in teacherList)
                    {
                        ListViewItem li2 = new ListViewItem(new String[] { t.Number.ToString(), t.FirstName, t.LastName, t.Supervisor });
                        listviewTeachers.Items.Add(li2);
                    }
                    listviewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listviewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlActivity.Hide();

                // show rooms
                pnlRooms.Show();

                try
                {
                    // fill the rooms listview within the rooms panel with a list of rooms
                    RoomService roomService = new RoomService();
                    List<Room> roomList = roomService.GetRooms();

                    // clear the listview before filling it again
                    listviewRooms.Clear();
                    listviewRooms.View = View.Details; // Enable rows
                    listviewRooms.Columns.Add("Room ID"); // Add colums
                    listviewRooms.Columns.Add("Room Type");
                    listviewRooms.Columns.Add("Number of beds");

                    foreach (Room r in roomList)
                    {
                        ListViewItem li3 = new ListViewItem(new String[] { r.Number.ToString(), r.Type, r.Capacity.ToString() });
                        listviewRooms.Items.Add(li3);
                    }
                    listviewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listviewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }
            else if (panelName == "Drinks Supplies")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlActivity.Hide();

                // show drinks
                pnlDrinks.Show();

                try
                {
                    // fill the drinks listview within the drinks panel with a list of drinks
                    List<Drink> drinkList = drinkService.GetDrinks();

                    // clear the listview before filling it again
                    listviewDrinks.Clear();
                    listviewDrinks.View = View.Details; // Enable rows
                    listviewDrinks.Columns.Add("Drink ID"); // Add colums
                    listviewDrinks.Columns.Add("Drink Name");
                    listviewDrinks.Columns.Add("Drink Price");
                    listviewDrinks.Columns.Add("Drink Stock");
                    listviewDrinks.Columns.Add(""); //column for showing Stock nearly deleted or Stock Sufficient

                    listviewDrinks.FullRowSelect = true; //Select the item and subitems when selection is made. 

                    foreach (Drink d in drinkList)
                    {
                        ListViewItem li4 = new ListViewItem(new String[] { d.Id.ToString(), d.Name, d.Price.ToString(), d.Stock.ToString(), d.StockInfo.ToString() });
                        listviewDrinks.Items.Add(li4);
                        li4.Tag = d;
                    }
                    listviewDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listviewDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
                }
            }
            else if (panelName == "Cash register")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlReport.Hide();
                pnlActivity.Hide();

                // show cash register
                pnlCashRegister.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();

                    // clear the listview before filling it again
                    listViewCashRegisterStudents.Clear();
                    //set the view to show details
                    listViewCashRegisterStudents.View = View.Details;
                    //creating columnss for items
                    listViewCashRegisterStudents.Columns.Add("Student ID");
                    listViewCashRegisterStudents.Columns.Add("First Name");
                    listViewCashRegisterStudents.FullRowSelect = true; //Select the item and subitems when selection is made. 

                    foreach (Student s in studentList)
                    {
                        ListViewItem li5 = new ListViewItem(new String[] { s.Number.ToString(), s.FirstName });//creating the items we need
                        li5.Tag = s;
                        listViewCashRegisterStudents.Items.Add(li5);
                    }
                    listViewCashRegisterStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listViewCashRegisterStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Auto resize headers to fit

                    // fill the drinks listview within the drinks panel with a list of drinks
                    List<Drink> drinkList = drinkService.GetDrinks();

                    // clear the listview before filling it again
                    listViewCashRegisterDrinks.Clear();
                    listViewCashRegisterDrinks.View = View.Details; // Enable rows
                    listViewCashRegisterDrinks.Columns.Add("Drink ID"); // Add colums
                    listViewCashRegisterDrinks.Columns.Add("Drink Name");
                    listViewCashRegisterDrinks.Columns.Add("Drink Price");
                    listViewCashRegisterDrinks.Columns.Add("Drink Stock");

                    listViewCashRegisterDrinks.FullRowSelect = true; //Select the item and subitems when selection is made. 

                    foreach (Drink d in drinkList)
                    {
                        ListViewItem li6 = new ListViewItem(new String[] { d.Id.ToString(), d.Name, d.Price.ToString(), d.Stock.ToString() });
                        listViewCashRegisterDrinks.Items.Add(li6);
                        li6.Tag = d;
                    }
                    listViewCashRegisterDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listViewCashRegisterDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit

                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the cash register: " + e.Message);
                }
            }
            else if (panelName == "Revenue Report")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlActivity.Hide();

                //show revenue report
                pnlReport.Show();

                try
                {
                    List<Report> reportList = reportService.GetAllReports();

                    // clear the listview before filling it again
                    listViewReport.Clear();
                    listViewReport.View = View.Details; // Enable rows
                    listViewReport.Columns.Add("Sales"); // Add colums
                    listViewReport.Columns.Add("Turnover", 80);
                    listViewReport.Columns.Add("Nr. of customers");

                    listViewReport.FullRowSelect = true; //Select the item and subitems when selection is made. 

                    listViewReport.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listViewReport.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the revenue report: " + e.Message);
                }
            }
            else if (panelName == "Activities")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();

                //show revenue report
                pnlActivity.Show();

                try
                {
                    // fill the activities listview within the activities panel with a list of activities
                    List<Activity> activityList = activityService.GetActivities();

                    // clear the listview before filling it again
                    listViewActivity.Clear();
                    listViewActivity.View = View.Details; // Enable rows
                    listViewActivity.Columns.Add("Activity ID"); // Add colums
                    listViewActivity.Columns.Add("Description");
                    listViewActivity.Columns.Add("Start Time");
                    listViewActivity.Columns.Add("End Time");

                    listViewActivity.FullRowSelect = true; //Select the item and subitems when selection is made. 

                    foreach (Activity a in activityList)
                    {
                        ListViewItem li = new ListViewItem(new String[] { a.ID.ToString(), a.Description, a.StartTime.ToString("dd/MM/yyyy HH:mm"), a.EndTime.ToString("dd/MM/yyyy HH:mm") });
                        listViewActivity.Items.Add(li);
                        li.Tag = a;
                    }
                    listViewActivity.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
                    listViewActivity.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);    // Make sure headers fit
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Lecturers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void drinkSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks Supplies");
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash register");
        }

        private void revenueReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Revenue Report");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }
        //actions for listview drinks
        private void listviewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make the button deletedrink available only if an item was selected
            btnDeleteDrink.Enabled = listviewDrinks.SelectedItems.Count >= 0;

            if (listviewDrinks.SelectedItems.Count == 1) //if 1 item is selected
            {
                Drink drink = (Drink)listviewDrinks.SelectedItems[0].Tag;  //return the item as an object

                txtDrinkName.Text = drink.Name;                //fill the textboxes with the object name, stock and price
                txtDrinkStock.Text = drink.Stock.ToString();
                txtDrinkPrice.Text = drink.Price.ToString();
            }
        }
        //remove a drink
        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            lbl_Error.Visible = false; //hide the error label
            if (listviewDrinks.SelectedItems.Count == 1)
            {
                Drink drink = (Drink)listviewDrinks.SelectedItems[0].Tag;
                try
                {
                    drinkService.RemoveDrink(drink);
                }
                catch (Exception exp) //if theres any error show in the label
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "Error occured: " + exp.Message;
                }
                //refreshing the list with drinks 
                listviewDrinks.Items.Clear();
                List<Drink> drinkList = drinkService.GetDrinks(); //just drinkService.GetDrinks(); wasnt working so i clearead the items and added again
                foreach (Drink d in drinkList)
                {
                    ListViewItem li4 = new ListViewItem(new String[] { d.Id.ToString(), d.Name, d.Price.ToString(), d.Stock.ToString(), d.StockInfo.ToString() });
                    listviewDrinks.Items.Add(li4);
                    li4.Tag = d;
                }
            }
        }
        //modify/update a drink
        private void btnModifyDrink_Click(object sender, EventArgs e)
        {
            if (listviewDrinks.SelectedItems.Count < 0)
                return;
            if (listviewDrinks.SelectedItems.Count == 1)
            {
                Drink drink = (Drink)listviewDrinks.SelectedItems[0].Tag;

                drink.Name = txtDrinkName.Text.ToString();
                drink.Stock = int.Parse(txtDrinkStock.Text);
                drink.Price = int.Parse(txtDrinkPrice.Text);
                try
                {
                    drinkService.UpdateDrink(drink);
                }
                catch (Exception exp) //if theres any error show in the label
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "Error occured: " + exp.Message;
                }
            }
            //refreshing the list with drinks 
            listviewDrinks.Items.Clear();
            List<Drink> drinkList = drinkService.GetDrinks(); //just drinkService.GetDrinks(); wasnt working so i clearead the items and added again
            foreach (Drink d in drinkList)
            {
                ListViewItem li4 = new ListViewItem(new String[] { d.Id.ToString(), d.Name, d.Price.ToString(), d.Stock.ToString(), d.StockInfo.ToString() });
                listviewDrinks.Items.Add(li4);
                li4.Tag = d;
            }
        }
        //button Add Drink
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink(); //create a new object

            drink.Name = txtDrinkName.Text.ToString();  //assign objects parameters from text boxes
            drink.Stock = int.Parse(txtDrinkStock.Text);
            drink.Price = int.Parse(txtDrinkPrice.Text);
            try
            {
                drinkService.AddDrink(drink);
            }
            catch (Exception exp) //if theres any error show in the label
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "Error occured: " + exp.Message;
            }
            //refreshing the list with drinks 
            listviewDrinks.Items.Clear();
            List<Drink> drinkList = drinkService.GetDrinks(); //just drinkService.GetDrinks(); wasnt working so i clearead the items and added again
            foreach (Drink d in drinkList)
            {
                ListViewItem li4 = new ListViewItem(new String[] { d.Id.ToString(), d.Name, d.Price.ToString(), d.Stock.ToString(), d.StockInfo.ToString() });
                listviewDrinks.Items.Add(li4);
                li4.Tag = d;
            }
        }
        //btn checkout
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CashRegisterService service = new CashRegisterService();

            ListViewItem item = listViewCashRegisterDrinks.SelectedItems[0];
            Drink drink = (Drink)item.Tag;

            ListViewItem item2 = listViewCashRegisterStudents.SelectedItems[0];
            Student student = (Student)item2.Tag;

            service.AddStudentDrink(student, drink);

            MessageBox.Show($"{student.FirstName} got {drink.Name} for {drink.Price} tokens. \nThe sales line was written to database.", "Checkout Info", MessageBoxButtons.OK);

            //refreshing the list with students 
            listViewCashRegisterStudents.Items.Clear();
            List<Student> studList = studentService.GetStudents(); //just drinkService.GetDrinks(); wasnt working so i clearead the items and added again
            foreach (Student s in studList)
            {
                ListViewItem li = new ListViewItem(new String[] { s.Number.ToString(), s.FirstName });
                listViewCashRegisterStudents.Items.Add(li);
                li.Tag = s;
            }
            //refreshing the list with drinks 
            listViewCashRegisterDrinks.Items.Clear();
            List<Drink> drinkList = drinkService.GetDrinks(); //just drinkService.GetDrinks(); wasnt working so i clearead the items and added again
            foreach (Drink d in drinkList)
            {
                ListViewItem li = new ListViewItem(new String[] { d.Id.ToString(), d.Name, d.Price.ToString(), d.Stock.ToString(), d.StockInfo.ToString() });
                listViewCashRegisterDrinks.Items.Add(li);
                li.Tag = d;
            }
        }
        //btn report
        private void btnReport_Click(object sender, EventArgs e)
        {
            listViewReport.Items.Clear();
            List<Report> reportList = reportService.GetAllReports();
            foreach (Report r in reportList)
            {
                int total = r.Sales * r.Turnover;
                ListViewItem li = new ListViewItem(new String[] { r.Sales.ToString() + " drinks sold", total.ToString() + " tokens", r.Customers.ToString() });
                listViewReport.Items.Add(li);
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string StartDate = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
            string EndDate = monthCalendar1.SelectionRange.End.ToString("dd/MM/yyyy");
            label1.Text = StartDate + "-" + EndDate;
        }

        //Assignment 4 Variant A: Activities
        private void listViewActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make the Remove activity button unclickable untill an activity is selected
            btnRemoveActivity.Enabled = listViewActivity.SelectedItems.Count >= 0;

            if (listViewActivity.SelectedItems.Count == 1) //if an activity is selected
            {
                //return the activity as an object
                Activity activity = (Activity)listViewActivity.SelectedItems[0].Tag;
                //fill the textbox with the activity description amd the datetimepicker with the dates of activity
                txtDescription.Text = activity.Description;
                monthStart.Value = activity.StartTime;
                monthEnd.Value = activity.EndTime;
            }
        }
        //button for remove an activity
        private void btnRemoveActivity_Click(object sender, EventArgs e)
        {
            if (listViewActivity.SelectedItems.Count == 1)
            {
                Activity activity = (Activity)listViewActivity.SelectedItems[0].Tag;
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you wish to remove this activity ({activity.Description}) ?", "Remove Activity", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        activityService.RemoveActivity(activity);
                    }
                    else
                        return;
                }
                catch (Exception exp) //if theres any error show in the label
                {
                    lblCaution.Visible = true;
                    lblCaution.Text = "Error occured: " + exp.Message;
                }
                //refreshing the list with activities
                listViewActivity.Items.Clear();
                List<Activity> activityList = activityService.GetActivities();
                foreach (Activity a in activityList)
                {
                    ListViewItem li = new ListViewItem(new String[] { a.ID.ToString(), a.Description, a.StartTime.ToString("dd/MM/yyyy HH:mm"), a.EndTime.ToString("dd/MM/yyyy HH:mm") });
                    listViewActivity.Items.Add(li);
                    li.Tag = a;
                }
            }
        }
        //button for modifying an activity
        private void btnModifyActivity_Click(object sender, EventArgs e)
        {
            if (listViewActivity.SelectedItems.Count < 0)
                return;
            if (listViewActivity.SelectedItems.Count == 1)
            {
                Activity activity = (Activity)listViewActivity.SelectedItems[0].Tag;

                activity.Description = txtDescription.Text.ToString();
                activity.StartTime = monthStart.Value;
                activity.EndTime = monthEnd.Value;

                try
                {
                    activityService.ModifyActivity(activity);
                }
                catch (Exception exp) //if theres any error show in the label
                {
                    lblCaution.Visible = true;
                    lblCaution.Text = "Error occured: " + exp.Message;
                }
                //refreshing the list with activities
                listViewActivity.Items.Clear();
                List<Activity> activityList = activityService.GetActivities();
                foreach (Activity a in activityList)
                {
                    ListViewItem li = new ListViewItem(new String[] { a.ID.ToString(), a.Description, a.StartTime.ToString("dd/MM/yyyy HH:mm"), a.EndTime.ToString("dd/MM/yyyy HH:mm") });
                    listViewActivity.Items.Add(li);
                    li.Tag = a;
                }
            }
        }
        //button for adding a new activity
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            List<Activity> activityl = activityService.GetActivities();
            Activity activity = new Activity(); //create a new object
            List<string> list = new List<string>(); //create a list of strings 
            foreach(Activity a in activityl)//add activities to the string list
            {
                list.Add(a.Description);
            }
            //assign objects parameters from text boxes
            activity.Description = txtDescription.Text.ToString();
            activity.StartTime = monthStart.Value;
            activity.EndTime = monthEnd.Value;
            try
            {
                if(!list.Contains(activity.Description))//if the list dont contains the activity add it, otherwise show the message box
                {
                    activityService.AddActivity(activity);
                }
                else
                {
                    MessageBox.Show("Activity already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp) //if theres any error show in the label
            {
                lblCaution.Visible = true;
                lblCaution.Text = "Error occured: " + exp.Message;
            }
            //refreshing the list with activities
            listViewActivity.Items.Clear();
            List<Activity> activityList = activityService.GetActivities();
            foreach (Activity a in activityList)
            {
                ListViewItem li = new ListViewItem(new String[] { a.ID.ToString(), a.Description, a.StartTime.ToString("dd/MM/yyyy HH:mm"), a.EndTime.ToString("dd/MM/yyyy HH:mm") });
                listViewActivity.Items.Add(li);
                li.Tag = a;
            }
        }
    }
}
