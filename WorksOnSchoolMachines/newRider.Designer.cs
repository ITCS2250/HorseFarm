namespace HorseFarm
{
    partial class newRider
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
            System.Windows.Forms.Label horseLabel;
            System.Windows.Forms.Label arrivedLabel;
            System.Windows.Forms.Label schoolLabel;
            System.Windows.Forms.Label showsLabel;
            System.Windows.Forms.Label hackLabel;
            System.Windows.Forms.Label campLabel;
            System.Windows.Forms.Label hSCHLLabel;
            System.Windows.Forms.Label argPerDayLabel;
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseFarmDataSet1 = new HorseFarm.HorseFarmDataSet1();
            this.txtNewStudentHorse = new System.Windows.Forms.TextBox();
            this.horsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNewStudentSchool = new System.Windows.Forms.TextBox();
            this.txtNewStudentShows = new System.Windows.Forms.TextBox();
            this.txtNewStudentHack = new System.Windows.Forms.TextBox();
            this.txtNewStudentCamp = new System.Windows.Forms.TextBox();
            this.txtNewStudentHSCHL = new System.Windows.Forms.TextBox();
            this.txtNewStudentArgPerDay = new System.Windows.Forms.TextBox();
            this.txtNewStudentLastName = new System.Windows.Forms.TextBox();
            this.dependentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNewStudentFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimeArrived = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewRiderSubmit = new System.Windows.Forms.Button();
            this.customersTableAdapter = new HorseFarm.HorseFarmDataSet1TableAdapters.CustomersTableAdapter();
            this.dependentsTableAdapter = new HorseFarm.HorseFarmDataSet1TableAdapters.DependentsTableAdapter();
            this.horsesTableAdapter = new HorseFarm.HorseFarmDataSet1TableAdapters.HorsesTableAdapter();
            this.parentLabel = new System.Windows.Forms.Label();
            this.parentComboBox = new System.Windows.Forms.ComboBox();
            this.isMinorCheckBox = new System.Windows.Forms.CheckBox();
            horseLabel = new System.Windows.Forms.Label();
            arrivedLabel = new System.Windows.Forms.Label();
            schoolLabel = new System.Windows.Forms.Label();
            showsLabel = new System.Windows.Forms.Label();
            hackLabel = new System.Windows.Forms.Label();
            campLabel = new System.Windows.Forms.Label();
            hSCHLLabel = new System.Windows.Forms.Label();
            argPerDayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horsesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // horseLabel
            // 
            horseLabel.AutoSize = true;
            horseLabel.Location = new System.Drawing.Point(6, 110);
            horseLabel.Name = "horseLabel";
            horseLabel.Size = new System.Drawing.Size(38, 13);
            horseLabel.TabIndex = 42;
            horseLabel.Text = "Horse:";
            // 
            // arrivedLabel
            // 
            arrivedLabel.AutoSize = true;
            arrivedLabel.Location = new System.Drawing.Point(5, 136);
            arrivedLabel.Name = "arrivedLabel";
            arrivedLabel.Size = new System.Drawing.Size(43, 13);
            arrivedLabel.TabIndex = 44;
            arrivedLabel.Text = "Arrived:";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.Location = new System.Drawing.Point(5, 162);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new System.Drawing.Size(43, 13);
            schoolLabel.TabIndex = 46;
            schoolLabel.Text = "School:";
            // 
            // showsLabel
            // 
            showsLabel.AutoSize = true;
            showsLabel.Location = new System.Drawing.Point(5, 188);
            showsLabel.Name = "showsLabel";
            showsLabel.Size = new System.Drawing.Size(42, 13);
            showsLabel.TabIndex = 48;
            showsLabel.Text = "Shows:";
            // 
            // hackLabel
            // 
            hackLabel.AutoSize = true;
            hackLabel.Location = new System.Drawing.Point(287, 136);
            hackLabel.Name = "hackLabel";
            hackLabel.Size = new System.Drawing.Size(36, 13);
            hackLabel.TabIndex = 50;
            hackLabel.Text = "Hack:";
            // 
            // campLabel
            // 
            campLabel.AutoSize = true;
            campLabel.Location = new System.Drawing.Point(286, 55);
            campLabel.Name = "campLabel";
            campLabel.Size = new System.Drawing.Size(37, 13);
            campLabel.TabIndex = 52;
            campLabel.Text = "Camp:";
            // 
            // hSCHLLabel
            // 
            hSCHLLabel.AutoSize = true;
            hSCHLLabel.Location = new System.Drawing.Point(286, 81);
            hSCHLLabel.Name = "hSCHLLabel";
            hSCHLLabel.Size = new System.Drawing.Size(46, 13);
            hSCHLLabel.TabIndex = 54;
            hSCHLLabel.Text = "HSCHL:";
            // 
            // argPerDayLabel
            // 
            argPerDayLabel.AutoSize = true;
            argPerDayLabel.Location = new System.Drawing.Point(286, 107);
            argPerDayLabel.Name = "argPerDayLabel";
            argPerDayLabel.Size = new System.Drawing.Size(67, 13);
            argPerDayLabel.TabIndex = 56;
            argPerDayLabel.Text = "Arg Per Day:";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // horseFarmDataSet1
            // 
            this.horseFarmDataSet1.DataSetName = "HorseFarmDataSet1";
            this.horseFarmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNewStudentHorse
            // 
            this.txtNewStudentHorse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horsesBindingSource, "HorseName", true));
            this.txtNewStudentHorse.Location = new System.Drawing.Point(71, 107);
            this.txtNewStudentHorse.Name = "txtNewStudentHorse";
            this.txtNewStudentHorse.Size = new System.Drawing.Size(200, 20);
            this.txtNewStudentHorse.TabIndex = 43;
            // 
            // horsesBindingSource
            // 
            this.horsesBindingSource.DataMember = "Horses";
            this.horsesBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // txtNewStudentSchool
            // 
            this.txtNewStudentSchool.Location = new System.Drawing.Point(71, 159);
            this.txtNewStudentSchool.Name = "txtNewStudentSchool";
            this.txtNewStudentSchool.Size = new System.Drawing.Size(200, 20);
            this.txtNewStudentSchool.TabIndex = 47;
            // 
            // txtNewStudentShows
            // 
            this.txtNewStudentShows.Location = new System.Drawing.Point(71, 185);
            this.txtNewStudentShows.Name = "txtNewStudentShows";
            this.txtNewStudentShows.Size = new System.Drawing.Size(200, 20);
            this.txtNewStudentShows.TabIndex = 49;
            // 
            // txtNewStudentHack
            // 
            this.txtNewStudentHack.Location = new System.Drawing.Point(359, 136);
            this.txtNewStudentHack.Name = "txtNewStudentHack";
            this.txtNewStudentHack.Size = new System.Drawing.Size(212, 20);
            this.txtNewStudentHack.TabIndex = 51;
            // 
            // txtNewStudentCamp
            // 
            this.txtNewStudentCamp.Location = new System.Drawing.Point(359, 52);
            this.txtNewStudentCamp.Name = "txtNewStudentCamp";
            this.txtNewStudentCamp.Size = new System.Drawing.Size(212, 20);
            this.txtNewStudentCamp.TabIndex = 53;
            // 
            // txtNewStudentHSCHL
            // 
            this.txtNewStudentHSCHL.Location = new System.Drawing.Point(359, 78);
            this.txtNewStudentHSCHL.Name = "txtNewStudentHSCHL";
            this.txtNewStudentHSCHL.Size = new System.Drawing.Size(212, 20);
            this.txtNewStudentHSCHL.TabIndex = 55;
            // 
            // txtNewStudentArgPerDay
            // 
            this.txtNewStudentArgPerDay.Location = new System.Drawing.Point(359, 104);
            this.txtNewStudentArgPerDay.Name = "txtNewStudentArgPerDay";
            this.txtNewStudentArgPerDay.Size = new System.Drawing.Size(212, 20);
            this.txtNewStudentArgPerDay.TabIndex = 57;
            // 
            // txtNewStudentLastName
            // 
            this.txtNewStudentLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependentsBindingSource, "LastName", true));
            this.txtNewStudentLastName.Location = new System.Drawing.Point(71, 77);
            this.txtNewStudentLastName.Name = "txtNewStudentLastName";
            this.txtNewStudentLastName.Size = new System.Drawing.Size(200, 20);
            this.txtNewStudentLastName.TabIndex = 33;
            // 
            // dependentsBindingSource
            // 
            this.dependentsBindingSource.DataMember = "Dependents";
            this.dependentsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // txtNewStudentFirstName
            // 
            this.txtNewStudentFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependentsBindingSource, "FirstName", true));
            this.txtNewStudentFirstName.Location = new System.Drawing.Point(71, 52);
            this.txtNewStudentFirstName.Name = "txtNewStudentFirstName";
            this.txtNewStudentFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtNewStudentFirstName.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "First Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Last Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isMinorCheckBox);
            this.groupBox2.Controls.Add(this.parentComboBox);
            this.groupBox2.Controls.Add(this.parentLabel);
            this.groupBox2.Controls.Add(this.dateTimeArrived);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(horseLabel);
            this.groupBox2.Controls.Add(this.btnNewRiderSubmit);
            this.groupBox2.Controls.Add(this.txtNewStudentHorse);
            this.groupBox2.Controls.Add(arrivedLabel);
            this.groupBox2.Controls.Add(schoolLabel);
            this.groupBox2.Controls.Add(this.txtNewStudentSchool);
            this.groupBox2.Controls.Add(showsLabel);
            this.groupBox2.Controls.Add(this.txtNewStudentShows);
            this.groupBox2.Controls.Add(hackLabel);
            this.groupBox2.Controls.Add(this.txtNewStudentHack);
            this.groupBox2.Controls.Add(campLabel);
            this.groupBox2.Controls.Add(this.txtNewStudentCamp);
            this.groupBox2.Controls.Add(hSCHLLabel);
            this.groupBox2.Controls.Add(this.txtNewStudentHSCHL);
            this.groupBox2.Controls.Add(argPerDayLabel);
            this.groupBox2.Controls.Add(this.txtNewStudentArgPerDay);
            this.groupBox2.Controls.Add(this.txtNewStudentLastName);
            this.groupBox2.Controls.Add(this.txtNewStudentFirstName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 220);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Information";
            // 
            // dateTimeArrived
            // 
            this.dateTimeArrived.Location = new System.Drawing.Point(71, 133);
            this.dateTimeArrived.Name = "dateTimeArrived";
            this.dateTimeArrived.Size = new System.Drawing.Size(200, 20);
            this.dateTimeArrived.TabIndex = 58;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(492, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewRiderSubmit
            // 
            this.btnNewRiderSubmit.Location = new System.Drawing.Point(411, 182);
            this.btnNewRiderSubmit.Name = "btnNewRiderSubmit";
            this.btnNewRiderSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnNewRiderSubmit.TabIndex = 9;
            this.btnNewRiderSubmit.Text = "Submit";
            this.btnNewRiderSubmit.UseVisualStyleBackColor = true;
            this.btnNewRiderSubmit.Click += new System.EventHandler(this.btnNewRiderSubmit_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // dependentsTableAdapter
            // 
            this.dependentsTableAdapter.ClearBeforeFill = true;
            // 
            // horsesTableAdapter
            // 
            this.horsesTableAdapter.ClearBeforeFill = true;
            // 
            // parentLabel
            // 
            this.parentLabel.AutoSize = true;
            this.parentLabel.Location = new System.Drawing.Point(6, 28);
            this.parentLabel.Name = "parentLabel";
            this.parentLabel.Size = new System.Drawing.Size(38, 13);
            this.parentLabel.TabIndex = 59;
            this.parentLabel.Text = "Parent";
            // 
            // parentComboBox
            // 
            this.parentComboBox.FormattingEnabled = true;
            this.parentComboBox.Location = new System.Drawing.Point(71, 25);
            this.parentComboBox.Name = "parentComboBox";
            this.parentComboBox.Size = new System.Drawing.Size(200, 21);
            this.parentComboBox.TabIndex = 60;
            // 
            // isMinorCheckBox
            // 
            this.isMinorCheckBox.AutoSize = true;
            this.isMinorCheckBox.Checked = true;
            this.isMinorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isMinorCheckBox.Location = new System.Drawing.Point(290, 27);
            this.isMinorCheckBox.Name = "isMinorCheckBox";
            this.isMinorCheckBox.Size = new System.Drawing.Size(63, 17);
            this.isMinorCheckBox.TabIndex = 62;
            this.isMinorCheckBox.Text = "Is Minor";
            this.isMinorCheckBox.UseVisualStyleBackColor = true;
            this.isMinorCheckBox.CheckedChanged += new System.EventHandler(this.isMinorCheckBox_CheckedChanged);
            // 
            // newRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 247);
            this.Controls.Add(this.groupBox2);
            this.Name = "newRider";
            this.Text = "New Rider";
            this.Load += new System.EventHandler(this.newRider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horsesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewStudentHorse;
        private System.Windows.Forms.TextBox txtNewStudentSchool;
        private System.Windows.Forms.TextBox txtNewStudentShows;
        private System.Windows.Forms.TextBox txtNewStudentHack;
        private System.Windows.Forms.TextBox txtNewStudentCamp;
        private System.Windows.Forms.TextBox txtNewStudentHSCHL;
        private System.Windows.Forms.TextBox txtNewStudentArgPerDay;
        private System.Windows.Forms.TextBox txtNewStudentLastName;
        private System.Windows.Forms.TextBox txtNewStudentFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewRiderSubmit;
        private HorseFarmDataSet1 horseFarmDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private HorseFarmDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource dependentsBindingSource;
        private HorseFarmDataSet1TableAdapters.DependentsTableAdapter dependentsTableAdapter;
        private System.Windows.Forms.BindingSource horsesBindingSource;
        private HorseFarmDataSet1TableAdapters.HorsesTableAdapter horsesTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeArrived;
        private System.Windows.Forms.CheckBox isMinorCheckBox;
        private System.Windows.Forms.ComboBox parentComboBox;
        private System.Windows.Forms.Label parentLabel;
    }
}