namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgStudents = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.imgTeachers = new System.Windows.Forms.PictureBox();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.listviewTeachers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.imgRooms = new System.Windows.Forms.PictureBox();
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.listviewRooms = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.txtDrinkStock = new System.Windows.Forms.TextBox();
            this.txtDrinkPrice = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnModifyDrink = new System.Windows.Forms.Button();
            this.btnDeleteDrink = new System.Windows.Forms.Button();
            this.imgDrinks = new System.Windows.Forms.PictureBox();
            this.lbl_Drinks = new System.Windows.Forms.Label();
            this.listviewDrinks = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtIddrink = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudents)).BeginInit();
            this.pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeachers)).BeginInit();
            this.pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRooms)).BeginInit();
            this.pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(627, 0);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(311, 270);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinkSuppliesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click_1);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // drinkSuppliesToolStripMenuItem
            // 
            this.drinkSuppliesToolStripMenuItem.Name = "drinkSuppliesToolStripMenuItem";
            this.drinkSuppliesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.drinkSuppliesToolStripMenuItem.Text = "Drinks Supplies";
            this.drinkSuppliesToolStripMenuItem.Click += new System.EventHandler(this.drinkSuppliesToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(12, 27);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(938, 466);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.imgStudents);
            this.pnlStudents.Controls.Add(this.lbl_Students);
            this.pnlStudents.Location = new System.Drawing.Point(12, 27);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(938, 466);
            this.pnlStudents.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(18, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.SelectedIndexChanged += new System.EventHandler(this.listViewStudents_SelectedIndexChanged);
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // imgStudents
            // 
            this.imgStudents.Image = global::SomerenUI.Properties.Resources.someren;
            this.imgStudents.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgStudents.InitialImage")));
            this.imgStudents.Location = new System.Drawing.Point(805, 0);
            this.imgStudents.Name = "imgStudents";
            this.imgStudents.Size = new System.Drawing.Size(130, 123);
            this.imgStudents.TabIndex = 0;
            this.imgStudents.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.imgTeachers);
            this.pnlTeachers.Controls.Add(this.lbl_Teachers);
            this.pnlTeachers.Controls.Add(this.listviewTeachers);
            this.pnlTeachers.Location = new System.Drawing.Point(12, 27);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(935, 463);
            this.pnlTeachers.TabIndex = 7;
            // 
            // imgTeachers
            // 
            this.imgTeachers.Image = global::SomerenUI.Properties.Resources.someren;
            this.imgTeachers.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgTeachers.InitialImage")));
            this.imgTeachers.Location = new System.Drawing.Point(805, 0);
            this.imgTeachers.Name = "imgTeachers";
            this.imgTeachers.Size = new System.Drawing.Size(130, 123);
            this.imgTeachers.TabIndex = 8;
            this.imgTeachers.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(10, 10);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(113, 29);
            this.lbl_Teachers.TabIndex = 7;
            this.lbl_Teachers.Text = "Lecturers";
            // 
            // listviewTeachers
            // 
            this.listviewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listviewTeachers.GridLines = true;
            this.listviewTeachers.HideSelection = false;
            this.listviewTeachers.Location = new System.Drawing.Point(18, 42);
            this.listviewTeachers.Name = "listviewTeachers";
            this.listviewTeachers.Size = new System.Drawing.Size(769, 303);
            this.listviewTeachers.TabIndex = 6;
            this.listviewTeachers.UseCompatibleStateImageBehavior = false;
            this.listviewTeachers.SelectedIndexChanged += new System.EventHandler(this.listViewTeachers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Birth";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Supervisor";
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.imgRooms);
            this.pnlRooms.Controls.Add(this.lbl_Rooms);
            this.pnlRooms.Controls.Add(this.listviewRooms);
            this.pnlRooms.Location = new System.Drawing.Point(12, 27);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(935, 463);
            this.pnlRooms.TabIndex = 9;
            // 
            // imgRooms
            // 
            this.imgRooms.Image = global::SomerenUI.Properties.Resources.someren;
            this.imgRooms.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgRooms.InitialImage")));
            this.imgRooms.Location = new System.Drawing.Point(805, 0);
            this.imgRooms.Name = "imgRooms";
            this.imgRooms.Size = new System.Drawing.Size(130, 123);
            this.imgRooms.TabIndex = 8;
            this.imgRooms.TabStop = false;
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rooms.Location = new System.Drawing.Point(10, 10);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(90, 29);
            this.lbl_Rooms.TabIndex = 7;
            this.lbl_Rooms.Text = "Rooms";
            // 
            // listviewRooms
            // 
            this.listviewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listviewRooms.GridLines = true;
            this.listviewRooms.HideSelection = false;
            this.listviewRooms.Location = new System.Drawing.Point(18, 42);
            this.listviewRooms.Name = "listviewRooms";
            this.listviewRooms.Size = new System.Drawing.Size(769, 303);
            this.listviewRooms.TabIndex = 6;
            this.listviewRooms.UseCompatibleStateImageBehavior = false;
            this.listviewRooms.SelectedIndexChanged += new System.EventHandler(this.listviewRooms_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Size";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Capacity";
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.label4);
            this.pnlDrinks.Controls.Add(this.txtIddrink);
            this.pnlDrinks.Controls.Add(this.btnRefresh);
            this.pnlDrinks.Controls.Add(this.label3);
            this.pnlDrinks.Controls.Add(this.label2);
            this.pnlDrinks.Controls.Add(this.label1);
            this.pnlDrinks.Controls.Add(this.txtDrinkName);
            this.pnlDrinks.Controls.Add(this.txtDrinkStock);
            this.pnlDrinks.Controls.Add(this.txtDrinkPrice);
            this.pnlDrinks.Controls.Add(this.lblError);
            this.pnlDrinks.Controls.Add(this.btnAddDrink);
            this.pnlDrinks.Controls.Add(this.btnModifyDrink);
            this.pnlDrinks.Controls.Add(this.btnDeleteDrink);
            this.pnlDrinks.Controls.Add(this.imgDrinks);
            this.pnlDrinks.Controls.Add(this.lbl_Drinks);
            this.pnlDrinks.Controls.Add(this.listviewDrinks);
            this.pnlDrinks.Location = new System.Drawing.Point(12, 27);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(935, 463);
            this.pnlDrinks.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Drink Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Drink Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Drink Name";
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(608, 154);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(179, 20);
            this.txtDrinkName.TabIndex = 15;
            // 
            // txtDrinkStock
            // 
            this.txtDrinkStock.Location = new System.Drawing.Point(608, 180);
            this.txtDrinkStock.Name = "txtDrinkStock";
            this.txtDrinkStock.Size = new System.Drawing.Size(179, 20);
            this.txtDrinkStock.TabIndex = 14;
            // 
            // txtDrinkPrice
            // 
            this.txtDrinkPrice.Location = new System.Drawing.Point(608, 206);
            this.txtDrinkPrice.Name = "txtDrinkPrice";
            this.txtDrinkPrice.Size = new System.Drawing.Size(179, 20);
            this.txtDrinkPrice.TabIndex = 13;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 366);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(16, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "...";
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(680, 293);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(107, 23);
            this.btnAddDrink.TabIndex = 11;
            this.btnAddDrink.Text = "Add Drink";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // btnModifyDrink
            // 
            this.btnModifyDrink.Location = new System.Drawing.Point(680, 235);
            this.btnModifyDrink.Name = "btnModifyDrink";
            this.btnModifyDrink.Size = new System.Drawing.Size(107, 23);
            this.btnModifyDrink.TabIndex = 10;
            this.btnModifyDrink.Text = "Modify Drink";
            this.btnModifyDrink.UseVisualStyleBackColor = true;
            this.btnModifyDrink.Click += new System.EventHandler(this.btnModifyDrink_Click);
            // 
            // btnDeleteDrink
            // 
            this.btnDeleteDrink.Location = new System.Drawing.Point(680, 264);
            this.btnDeleteDrink.Name = "btnDeleteDrink";
            this.btnDeleteDrink.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteDrink.TabIndex = 9;
            this.btnDeleteDrink.Text = "Remove Drink";
            this.btnDeleteDrink.UseVisualStyleBackColor = true;
            this.btnDeleteDrink.Click += new System.EventHandler(this.btnDeleteDrink_Click);
            // 
            // imgDrinks
            // 
            this.imgDrinks.Image = global::SomerenUI.Properties.Resources.someren;
            this.imgDrinks.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgDrinks.InitialImage")));
            this.imgDrinks.Location = new System.Drawing.Point(805, 0);
            this.imgDrinks.Name = "imgDrinks";
            this.imgDrinks.Size = new System.Drawing.Size(130, 123);
            this.imgDrinks.TabIndex = 8;
            this.imgDrinks.TabStop = false;
            // 
            // lbl_Drinks
            // 
            this.lbl_Drinks.AutoSize = true;
            this.lbl_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drinks.Location = new System.Drawing.Point(10, 10);
            this.lbl_Drinks.Name = "lbl_Drinks";
            this.lbl_Drinks.Size = new System.Drawing.Size(182, 29);
            this.lbl_Drinks.TabIndex = 7;
            this.lbl_Drinks.Text = "Drinks Supplies";
            // 
            // listviewDrinks
            // 
            this.listviewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listviewDrinks.GridLines = true;
            this.listviewDrinks.HideSelection = false;
            this.listviewDrinks.Location = new System.Drawing.Point(18, 42);
            this.listviewDrinks.Name = "listviewDrinks";
            this.listviewDrinks.Size = new System.Drawing.Size(481, 303);
            this.listviewDrinks.TabIndex = 6;
            this.listviewDrinks.UseCompatibleStateImageBehavior = false;
            this.listviewDrinks.SelectedIndexChanged += new System.EventHandler(this.listviewDrinks_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Size";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Capacity";
            // 
            // txtIddrink
            // 
            this.txtIddrink.Location = new System.Drawing.Point(608, 128);
            this.txtIddrink.Name = "txtIddrink";
            this.txtIddrink.Size = new System.Drawing.Size(179, 20);
            this.txtIddrink.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(680, 322);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Drink ID";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlTeachers);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudents)).EndInit();
            this.pnlTeachers.ResumeLayout(false);
            this.pnlTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeachers)).EndInit();
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRooms)).EndInit();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox imgStudents;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ListView listviewTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Label lbl_Teachers;
        private System.Windows.Forms.PictureBox imgTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox imgRooms;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.ListView listviewRooms;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem drinkSuppliesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.PictureBox imgDrinks;
        private System.Windows.Forms.Label lbl_Drinks;
        private System.Windows.Forms.ListView listviewDrinks;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Button btnModifyDrink;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.TextBox txtDrinkStock;
        private System.Windows.Forms.TextBox txtDrinkPrice;
        private System.Windows.Forms.TextBox txtIddrink;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
    }
}

