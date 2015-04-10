namespace HorseFarm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radFindByClientName = new System.Windows.Forms.RadioButton();
            this.radFindByHorseName = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radDisplayAll = new System.Windows.Forms.RadioButton();
            this.radDisplayWorkExchange = new System.Windows.Forms.RadioButton();
            this.radDisplayServices = new System.Windows.Forms.RadioButton();
            this.radDisplayAppts = new System.Windows.Forms.RadioButton();
            this.radDisplayShows = new System.Windows.Forms.RadioButton();
            this.radDisplayLessons = new System.Windows.Forms.RadioButton();
            this.BtnClient = new System.Windows.Forms.Button();
            this.cboFindByClientName = new System.Windows.Forms.ComboBox();
            this.vCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseFarmDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseFarmDataSet1 = new WorksOnSchoolMachines.HorseFarmDataSet1();
            this.btnHorse = new System.Windows.Forms.Button();
            this.cboFindByHorseName = new System.Windows.Forms.ComboBox();
            this.horsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboFindByStudentName = new System.Windows.Forms.ComboBox();
            this.dependentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radFindByStudentName = new System.Windows.Forms.RadioButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLesson = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.horsesTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.HorsesTableAdapter();
            this.dependentsTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.DependentsTableAdapter();
            this.vCustomersTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.vCustomersTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horsesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // radFindByClientName
            // 
            this.radFindByClientName.AutoSize = true;
            this.radFindByClientName.Location = new System.Drawing.Point(6, 19);
            this.radFindByClientName.Name = "radFindByClientName";
            this.radFindByClientName.Size = new System.Drawing.Size(85, 17);
            this.radFindByClientName.TabIndex = 1;
            this.radFindByClientName.TabStop = true;
            this.radFindByClientName.Text = "Client Name:";
            this.radFindByClientName.UseVisualStyleBackColor = true;
            // 
            // radFindByHorseName
            // 
            this.radFindByHorseName.AutoSize = true;
            this.radFindByHorseName.Location = new System.Drawing.Point(6, 137);
            this.radFindByHorseName.Name = "radFindByHorseName";
            this.radFindByHorseName.Size = new System.Drawing.Size(87, 17);
            this.radFindByHorseName.TabIndex = 1;
            this.radFindByHorseName.TabStop = true;
            this.radFindByHorseName.Text = "Horse Name:";
            this.radFindByHorseName.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(250, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radDisplayAll);
            this.groupBox3.Controls.Add(this.radDisplayWorkExchange);
            this.groupBox3.Controls.Add(this.radDisplayServices);
            this.groupBox3.Controls.Add(this.radDisplayAppts);
            this.groupBox3.Controls.Add(this.radDisplayShows);
            this.groupBox3.Controls.Add(this.radDisplayLessons);
            this.groupBox3.Location = new System.Drawing.Point(23, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 169);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display:";
            // 
            // radDisplayAll
            // 
            this.radDisplayAll.AutoSize = true;
            this.radDisplayAll.Location = new System.Drawing.Point(16, 135);
            this.radDisplayAll.Name = "radDisplayAll";
            this.radDisplayAll.Size = new System.Drawing.Size(73, 17);
            this.radDisplayAll.TabIndex = 0;
            this.radDisplayAll.TabStop = true;
            this.radDisplayAll.Text = "Display All";
            this.radDisplayAll.UseVisualStyleBackColor = true;
            // 
            // radDisplayWorkExchange
            // 
            this.radDisplayWorkExchange.AutoSize = true;
            this.radDisplayWorkExchange.Location = new System.Drawing.Point(16, 89);
            this.radDisplayWorkExchange.Name = "radDisplayWorkExchange";
            this.radDisplayWorkExchange.Size = new System.Drawing.Size(102, 17);
            this.radDisplayWorkExchange.TabIndex = 0;
            this.radDisplayWorkExchange.TabStop = true;
            this.radDisplayWorkExchange.Text = "Work Exchange";
            this.radDisplayWorkExchange.UseVisualStyleBackColor = true;
            // 
            // radDisplayServices
            // 
            this.radDisplayServices.AutoSize = true;
            this.radDisplayServices.Location = new System.Drawing.Point(16, 43);
            this.radDisplayServices.Name = "radDisplayServices";
            this.radDisplayServices.Size = new System.Drawing.Size(90, 17);
            this.radDisplayServices.TabIndex = 0;
            this.radDisplayServices.TabStop = true;
            this.radDisplayServices.Text = "Services Only";
            this.radDisplayServices.UseVisualStyleBackColor = true;
            // 
            // radDisplayAppts
            // 
            this.radDisplayAppts.AutoSize = true;
            this.radDisplayAppts.Location = new System.Drawing.Point(16, 112);
            this.radDisplayAppts.Name = "radDisplayAppts";
            this.radDisplayAppts.Size = new System.Drawing.Size(147, 17);
            this.radDisplayAppts.TabIndex = 0;
            this.radDisplayAppts.TabStop = true;
            this.radDisplayAppts.Text = "Appointments/Horse Care";
            this.radDisplayAppts.UseVisualStyleBackColor = true;
            // 
            // radDisplayShows
            // 
            this.radDisplayShows.AutoSize = true;
            this.radDisplayShows.Location = new System.Drawing.Point(16, 66);
            this.radDisplayShows.Name = "radDisplayShows";
            this.radDisplayShows.Size = new System.Drawing.Size(81, 17);
            this.radDisplayShows.TabIndex = 0;
            this.radDisplayShows.TabStop = true;
            this.radDisplayShows.Text = "Shows Only";
            this.radDisplayShows.UseVisualStyleBackColor = true;
            // 
            // radDisplayLessons
            // 
            this.radDisplayLessons.AutoSize = true;
            this.radDisplayLessons.Location = new System.Drawing.Point(16, 20);
            this.radDisplayLessons.Name = "radDisplayLessons";
            this.radDisplayLessons.Size = new System.Drawing.Size(85, 17);
            this.radDisplayLessons.TabIndex = 0;
            this.radDisplayLessons.TabStop = true;
            this.radDisplayLessons.Text = "LessonsOnly";
            this.radDisplayLessons.UseVisualStyleBackColor = true;
            // 
            // BtnClient
            // 
            this.BtnClient.Location = new System.Drawing.Point(57, 312);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(75, 23);
            this.BtnClient.TabIndex = 7;
            this.BtnClient.Text = "New Client";
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // cboFindByClientName
            // 
            this.cboFindByClientName.DataSource = this.vCustomersBindingSource;
            this.cboFindByClientName.DisplayMember = "FullName";
            this.cboFindByClientName.FormattingEnabled = true;
            this.cboFindByClientName.Location = new System.Drawing.Point(6, 42);
            this.cboFindByClientName.Name = "cboFindByClientName";
            this.cboFindByClientName.Size = new System.Drawing.Size(121, 21);
            this.cboFindByClientName.TabIndex = 0;
            this.cboFindByClientName.ValueMember = "CustomerID";
            // 
            // vCustomersBindingSource
            // 
            this.vCustomersBindingSource.DataMember = "vCustomers";
            this.vCustomersBindingSource.DataSource = this.horseFarmDataSet1BindingSource;
            // 
            // horseFarmDataSet1BindingSource
            // 
            this.horseFarmDataSet1BindingSource.DataSource = this.horseFarmDataSet1;
            this.horseFarmDataSet1BindingSource.Position = 0;
            // 
            // horseFarmDataSet1
            // 
            this.horseFarmDataSet1.DataSetName = "HorseFarmDataSet1";
            this.horseFarmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHorse
            // 
            this.btnHorse.Location = new System.Drawing.Point(111, 19);
            this.btnHorse.Name = "btnHorse";
            this.btnHorse.Size = new System.Drawing.Size(75, 23);
            this.btnHorse.TabIndex = 9;
            this.btnHorse.Text = "Horse Care";
            this.btnHorse.UseVisualStyleBackColor = true;
            this.btnHorse.Click += new System.EventHandler(this.btnHorse_Click);
            // 
            // cboFindByHorseName
            // 
            this.cboFindByHorseName.DataSource = this.horsesBindingSource;
            this.cboFindByHorseName.DisplayMember = "HorseName";
            this.cboFindByHorseName.FormattingEnabled = true;
            this.cboFindByHorseName.Location = new System.Drawing.Point(6, 160);
            this.cboFindByHorseName.Name = "cboFindByHorseName";
            this.cboFindByHorseName.Size = new System.Drawing.Size(121, 21);
            this.cboFindByHorseName.TabIndex = 0;
            // 
            // horsesBindingSource
            // 
            this.horsesBindingSource.DataMember = "Horses";
            this.horsesBindingSource.DataSource = this.horseFarmDataSet1BindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 247);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lesson Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radFindByClientName);
            this.groupBox4.Controls.Add(this.radFindByHorseName);
            this.groupBox4.Controls.Add(this.cboFindByClientName);
            this.groupBox4.Controls.Add(this.cboFindByHorseName);
            this.groupBox4.Controls.Add(this.cboFindByStudentName);
            this.groupBox4.Controls.Add(this.radFindByStudentName);
            this.groupBox4.Location = new System.Drawing.Point(489, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 198);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find By Name";
            // 
            // cboFindByStudentName
            // 
            this.cboFindByStudentName.DataSource = this.dependentsBindingSource;
            this.cboFindByStudentName.DisplayMember = "FirstName";
            this.cboFindByStudentName.FormattingEnabled = true;
            this.cboFindByStudentName.Location = new System.Drawing.Point(6, 101);
            this.cboFindByStudentName.Name = "cboFindByStudentName";
            this.cboFindByStudentName.Size = new System.Drawing.Size(121, 21);
            this.cboFindByStudentName.TabIndex = 0;
            // 
            // dependentsBindingSource
            // 
            this.dependentsBindingSource.DataMember = "Dependents";
            this.dependentsBindingSource.DataSource = this.horseFarmDataSet1BindingSource;
            // 
            // radFindByStudentName
            // 
            this.radFindByStudentName.AutoSize = true;
            this.radFindByStudentName.Location = new System.Drawing.Point(6, 78);
            this.radFindByStudentName.Name = "radFindByStudentName";
            this.radFindByStudentName.Size = new System.Drawing.Size(96, 17);
            this.radFindByStudentName.TabIndex = 1;
            this.radFindByStudentName.TabStop = true;
            this.radFindByStudentName.Text = "Student Name:";
            this.radFindByStudentName.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(722, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLesson
            // 
            this.btnLesson.Location = new System.Drawing.Point(17, 19);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(75, 23);
            this.btnLesson.TabIndex = 8;
            this.btnLesson.Text = "New Lesson";
            this.btnLesson.UseVisualStyleBackColor = true;
            this.btnLesson.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLesson);
            this.groupBox5.Controls.Add(this.btnHorse);
            this.groupBox5.Location = new System.Drawing.Point(167, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 57);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add to schedule";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(380, 293);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(316, 57);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "View Calendars";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Horse Care";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lessons";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.horseFarmDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // horsesTableAdapter
            // 
            this.horsesTableAdapter.ClearBeforeFill = true;
            // 
            // dependentsTableAdapter
            // 
            this.dependentsTableAdapter.ClearBeforeFill = true;
            // 
            // vCustomersTableAdapter
            // 
            this.vCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 374);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Form1";
            this.Text = "Horse Farm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horsesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radFindByClientName;
        private System.Windows.Forms.RadioButton radFindByHorseName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radDisplayAll;
        private System.Windows.Forms.RadioButton radDisplayWorkExchange;
        private System.Windows.Forms.RadioButton radDisplayServices;
        private System.Windows.Forms.RadioButton radDisplayAppts;
        private System.Windows.Forms.RadioButton radDisplayShows;
        private System.Windows.Forms.RadioButton radDisplayLessons;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.ComboBox cboFindByClientName;
        private System.Windows.Forms.Button btnHorse;
        private System.Windows.Forms.ComboBox cboFindByHorseName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboFindByStudentName;
        private System.Windows.Forms.RadioButton radFindByStudentName;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnLesson;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource horseFarmDataSet1BindingSource;
        private HorseFarmDataSet1 horseFarmDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource horsesBindingSource;
        private HorseFarmDataSet1TableAdapters.HorsesTableAdapter horsesTableAdapter;
        private System.Windows.Forms.BindingSource dependentsBindingSource;
        private HorseFarmDataSet1TableAdapters.DependentsTableAdapter dependentsTableAdapter;
        private System.Windows.Forms.BindingSource vCustomersBindingSource;
        private HorseFarmDataSet1TableAdapters.vCustomersTableAdapter vCustomersTableAdapter;
    }
}

