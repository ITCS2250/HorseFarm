namespace HorseFarm
{
    partial class MainScreen
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
            this.radFindByClientName = new System.Windows.Forms.RadioButton();
            this.radFindByHorseName = new System.Windows.Forms.RadioButton();
            this.scheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radDisplayAll = new System.Windows.Forms.RadioButton();
            this.radDisplayWorkExchange = new System.Windows.Forms.RadioButton();
            this.radDisplayServices = new System.Windows.Forms.RadioButton();
            this.radDisplayAppts = new System.Windows.Forms.RadioButton();
            this.radDisplayShows = new System.Windows.Forms.RadioButton();
            this.radDisplayLessons = new System.Windows.Forms.RadioButton();
            this.cboFindByClientName = new System.Windows.Forms.ComboBox();
            this.cboFindByHorseName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboFindByStudentName = new System.Windows.Forms.ComboBox();
            this.radFindByStudentName = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horseCareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // scheduleCalendar
            // 
            this.scheduleCalendar.Location = new System.Drawing.Point(418, 36);
            this.scheduleCalendar.Name = "scheduleCalendar";
            this.scheduleCalendar.TabIndex = 4;
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
            this.groupBox3.Size = new System.Drawing.Size(200, 205);
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
            this.radDisplayLessons.Size = new System.Drawing.Size(88, 17);
            this.radDisplayLessons.TabIndex = 0;
            this.radDisplayLessons.TabStop = true;
            this.radDisplayLessons.Text = "Lessons Only";
            this.radDisplayLessons.UseVisualStyleBackColor = true;
            // 
            // cboFindByClientName
            // 
            this.cboFindByClientName.FormattingEnabled = true;
            this.cboFindByClientName.Location = new System.Drawing.Point(6, 42);
            this.cboFindByClientName.Name = "cboFindByClientName";
            this.cboFindByClientName.Size = new System.Drawing.Size(121, 21);
            this.cboFindByClientName.TabIndex = 0;
            this.cboFindByClientName.ValueMember = "CustomerID";
            // 
            // cboFindByHorseName
            // 
            this.cboFindByHorseName.FormattingEnabled = true;
            this.cboFindByHorseName.Location = new System.Drawing.Point(6, 160);
            this.cboFindByHorseName.Name = "cboFindByHorseName";
            this.cboFindByHorseName.Size = new System.Drawing.Size(121, 21);
            this.cboFindByHorseName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.scheduleCalendar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 259);
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
            this.groupBox4.Location = new System.Drawing.Point(229, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 205);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find By Name";
            // 
            // cboFindByStudentName
            // 
            this.cboFindByStudentName.FormattingEnabled = true;
            this.cboFindByStudentName.Location = new System.Drawing.Point(6, 101);
            this.cboFindByStudentName.Name = "cboFindByStudentName";
            this.cboFindByStudentName.Size = new System.Drawing.Size(121, 21);
            this.cboFindByStudentName.TabIndex = 0;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "MainMenu";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lessonToolStripMenuItem,
            this.horseCareToolStripMenuItem});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // lessonToolStripMenuItem
            // 
            this.lessonToolStripMenuItem.Name = "lessonToolStripMenuItem";
            this.lessonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lessonToolStripMenuItem.Text = "Lesson";
            this.lessonToolStripMenuItem.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // horseCareToolStripMenuItem
            // 
            this.horseCareToolStripMenuItem.Name = "horseCareToolStripMenuItem";
            this.horseCareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horseCareToolStripMenuItem.Text = "Horse Care";
            this.horseCareToolStripMenuItem.Click += new System.EventHandler(this.btnHorse_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "Horse Farm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radFindByClientName;
        private System.Windows.Forms.RadioButton radFindByHorseName;
        private System.Windows.Forms.MonthCalendar scheduleCalendar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radDisplayAll;
        private System.Windows.Forms.RadioButton radDisplayWorkExchange;
        private System.Windows.Forms.RadioButton radDisplayServices;
        private System.Windows.Forms.RadioButton radDisplayAppts;
        private System.Windows.Forms.RadioButton radDisplayShows;
        private System.Windows.Forms.RadioButton radDisplayLessons;
        private System.Windows.Forms.ComboBox cboFindByClientName;
        private System.Windows.Forms.ComboBox cboFindByHorseName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboFindByStudentName;
        private System.Windows.Forms.RadioButton radFindByStudentName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horseCareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
    }
}

