namespace WorksOnSchoolMachines
{
    partial class newLesson
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
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label instructionLabel;
            System.Windows.Forms.Label timeDateLabel;
            System.Windows.Forms.Label studentLabel;
            System.Windows.Forms.Label lessPriorLabel;
            System.Windows.Forms.Label expereanceOfClassLabel;
            System.Windows.Forms.Label kindLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.cboFindByClientName = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.timeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lessPriorTextBox = new System.Windows.Forms.TextBox();
            this.expereanceOfClassTextBox = new System.Windows.Forms.TextBox();
            this.kindTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.horseFarmDataSet1 = new WorksOnSchoolMachines.HorseFarmDataSet1();
            this.vCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCustomersTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.vCustomersTableAdapter();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonsTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.LessonsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorsTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.InstructorsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dependentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependentsTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.DependentsTableAdapter();
            this.experienceLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.experienceLevelsTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.ExperienceLevelsTableAdapter();
            classLabel = new System.Windows.Forms.Label();
            instructionLabel = new System.Windows.Forms.Label();
            timeDateLabel = new System.Windows.Forms.Label();
            studentLabel = new System.Windows.Forms.Label();
            lessPriorLabel = new System.Windows.Forms.Label();
            expereanceOfClassLabel = new System.Windows.Forms.Label();
            kindLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceLevelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(29, 50);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(35, 13);
            classLabel.TabIndex = 40;
            classLabel.Text = "Class:";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new System.Drawing.Point(29, 76);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new System.Drawing.Size(54, 13);
            instructionLabel.TabIndex = 42;
            instructionLabel.Text = "Instructor:";
            // 
            // timeDateLabel
            // 
            timeDateLabel.AutoSize = true;
            timeDateLabel.Location = new System.Drawing.Point(29, 103);
            timeDateLabel.Name = "timeDateLabel";
            timeDateLabel.Size = new System.Drawing.Size(33, 13);
            timeDateLabel.TabIndex = 44;
            timeDateLabel.Text = "Date:";
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new System.Drawing.Point(29, 162);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(47, 13);
            studentLabel.TabIndex = 46;
            studentLabel.Text = "Student:";
            // 
            // lessPriorLabel
            // 
            lessPriorLabel.AutoSize = true;
            lessPriorLabel.Location = new System.Drawing.Point(29, 188);
            lessPriorLabel.Name = "lessPriorLabel";
            lessPriorLabel.Size = new System.Drawing.Size(68, 13);
            lessPriorLabel.TabIndex = 48;
            lessPriorLabel.Text = "Lesson Prior:";
            // 
            // expereanceOfClassLabel
            // 
            expereanceOfClassLabel.AutoSize = true;
            expereanceOfClassLabel.Location = new System.Drawing.Point(29, 214);
            expereanceOfClassLabel.Name = "expereanceOfClassLabel";
            expereanceOfClassLabel.Size = new System.Drawing.Size(105, 13);
            expereanceOfClassLabel.TabIndex = 50;
            expereanceOfClassLabel.Text = "Experience Of Class:";
            // 
            // kindLabel
            // 
            kindLabel.AutoSize = true;
            kindLabel.Location = new System.Drawing.Point(29, 240);
            kindLabel.Name = "kindLabel";
            kindLabel.Size = new System.Drawing.Size(74, 13);
            kindLabel.TabIndex = 54;
            kindLabel.Text = "Type of Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Client:";
            // 
            // cboFindByClientName
            // 
            this.cboFindByClientName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vCustomersBindingSource, "FullName", true));
            this.cboFindByClientName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vCustomersBindingSource, "CustomerID", true));
            this.cboFindByClientName.DataSource = this.vCustomersBindingSource;
            this.cboFindByClientName.DisplayMember = "FullName";
            this.cboFindByClientName.FormattingEnabled = true;
            this.cboFindByClientName.Location = new System.Drawing.Point(144, 20);
            this.cboFindByClientName.Name = "cboFindByClientName";
            this.cboFindByClientName.Size = new System.Drawing.Size(200, 21);
            this.cboFindByClientName.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // classTextBox
            // 
            this.classTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Class", true));
            this.classTextBox.Location = new System.Drawing.Point(144, 47);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(200, 20);
            this.classTextBox.TabIndex = 41;
            // 
            // timeDateDateTimePicker
            // 
            this.timeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "LessonDate", true));
            this.timeDateDateTimePicker.Location = new System.Drawing.Point(144, 99);
            this.timeDateDateTimePicker.Name = "timeDateDateTimePicker";
            this.timeDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeDateDateTimePicker.TabIndex = 45;
            // 
            // lessPriorTextBox
            // 
            this.lessPriorTextBox.Location = new System.Drawing.Point(144, 185);
            this.lessPriorTextBox.Name = "lessPriorTextBox";
            this.lessPriorTextBox.Size = new System.Drawing.Size(200, 20);
            this.lessPriorTextBox.TabIndex = 49;
            // 
            // expereanceOfClassTextBox
            // 
            this.expereanceOfClassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.experienceLevelsBindingSource, "ExperienceLevel", true));
            this.expereanceOfClassTextBox.Location = new System.Drawing.Point(144, 211);
            this.expereanceOfClassTextBox.Name = "expereanceOfClassTextBox";
            this.expereanceOfClassTextBox.Size = new System.Drawing.Size(200, 20);
            this.expereanceOfClassTextBox.TabIndex = 51;
            // 
            // kindTextBox
            // 
            this.kindTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "TypeOfLesson", true));
            this.kindTextBox.Location = new System.Drawing.Point(144, 237);
            this.kindTextBox.Name = "kindTextBox";
            this.kindTextBox.Size = new System.Drawing.Size(200, 20);
            this.kindTextBox.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Time:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "LessonTime", true));
            this.textBox1.Location = new System.Drawing.Point(144, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 61;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 62;
            this.button3.Text = "Print Reciept";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // horseFarmDataSet1
            // 
            this.horseFarmDataSet1.DataSetName = "HorseFarmDataSet1";
            this.horseFarmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vCustomersBindingSource
            // 
            this.vCustomersBindingSource.DataMember = "vCustomers";
            this.vCustomersBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // vCustomersTableAdapter
            // 
            this.vCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.instructorsBindingSource, "LastName", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instructorsBindingSource, "InstructorID", true));
            this.comboBox1.DataSource = this.lessonsBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // instructorsBindingSource
            // 
            this.instructorsBindingSource.DataMember = "Instructors";
            this.instructorsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dependentsBindingSource, "DependentID", true));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dependentsBindingSource, "FirstName", true));
            this.comboBox2.DataSource = this.dependentsBindingSource;
            this.comboBox2.DisplayMember = "FirstName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 64;
            // 
            // dependentsBindingSource
            // 
            this.dependentsBindingSource.DataMember = "Dependents";
            this.dependentsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // dependentsTableAdapter
            // 
            this.dependentsTableAdapter.ClearBeforeFill = true;
            // 
            // experienceLevelsBindingSource
            // 
            this.experienceLevelsBindingSource.DataMember = "ExperienceLevels";
            this.experienceLevelsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // experienceLevelsTableAdapter
            // 
            this.experienceLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // newLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 324);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFindByClientName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(instructionLabel);
            this.Controls.Add(timeDateLabel);
            this.Controls.Add(this.timeDateDateTimePicker);
            this.Controls.Add(studentLabel);
            this.Controls.Add(lessPriorLabel);
            this.Controls.Add(this.lessPriorTextBox);
            this.Controls.Add(expereanceOfClassLabel);
            this.Controls.Add(this.expereanceOfClassTextBox);
            this.Controls.Add(kindLabel);
            this.Controls.Add(this.kindTextBox);
            this.Name = "newLesson";
            this.Text = "newLesson";
            this.Load += new System.EventHandler(this.newLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceLevelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFindByClientName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.DateTimePicker timeDateDateTimePicker;
        private System.Windows.Forms.TextBox lessPriorTextBox;
        private System.Windows.Forms.TextBox expereanceOfClassTextBox;
        private System.Windows.Forms.TextBox kindTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private HorseFarmDataSet1 horseFarmDataSet1;
        private System.Windows.Forms.BindingSource vCustomersBindingSource;
        private HorseFarmDataSet1TableAdapters.vCustomersTableAdapter vCustomersTableAdapter;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private HorseFarmDataSet1TableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource instructorsBindingSource;
        private HorseFarmDataSet1TableAdapters.InstructorsTableAdapter instructorsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource dependentsBindingSource;
        private HorseFarmDataSet1TableAdapters.DependentsTableAdapter dependentsTableAdapter;
        private System.Windows.Forms.BindingSource experienceLevelsBindingSource;
        private HorseFarmDataSet1TableAdapters.ExperienceLevelsTableAdapter experienceLevelsTableAdapter;
    }
}