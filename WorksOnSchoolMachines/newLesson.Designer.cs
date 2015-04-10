﻿namespace HorseFarm
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
            this.cboClientName = new System.Windows.Forms.ComboBox();
            this.vCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseFarmDataSet1 =new HorseFarm.HorseFarmDataSet1();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewLessonSubmit = new System.Windows.Forms.Button();
            this.txtNewLessonClass = new System.Windows.Forms.TextBox();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateNewLessonDate = new System.Windows.Forms.DateTimePicker();
            this.txtLessonPrior = new System.Windows.Forms.TextBox();
            this.txtExperienceOfClass = new System.Windows.Forms.TextBox();
            this.experienceLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTypeOfClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewLessonTime = new System.Windows.Forms.TextBox();
            this.btnPrintReciept = new System.Windows.Forms.Button();
            this.vCustomersTableAdapter =new HorseFarm.HorseFarmDataSet1TableAdapters.vCustomersTableAdapter();
            this.lessonsTableAdapter =new HorseFarm.HorseFarmDataSet1TableAdapters.LessonsTableAdapter();
            this.cboNewLessonInstructor = new System.Windows.Forms.ComboBox();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorsTableAdapter =new HorseFarm.HorseFarmDataSet1TableAdapters.InstructorsTableAdapter();
            this.cboNewLessonStudent = new System.Windows.Forms.ComboBox();
            this.dependentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependentsTableAdapter =new HorseFarm.HorseFarmDataSet1TableAdapters.DependentsTableAdapter();
            this.experienceLevelsTableAdapter =new HorseFarm.HorseFarmDataSet1TableAdapters.ExperienceLevelsTableAdapter();
            classLabel = new System.Windows.Forms.Label();
            instructionLabel = new System.Windows.Forms.Label();
            timeDateLabel = new System.Windows.Forms.Label();
            studentLabel = new System.Windows.Forms.Label();
            lessPriorLabel = new System.Windows.Forms.Label();
            expereanceOfClassLabel = new System.Windows.Forms.Label();
            kindLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceLevelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).BeginInit();
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
            // cboClientName
            // 
            this.cboClientName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vCustomersBindingSource, "FullName", true));
            this.cboClientName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vCustomersBindingSource, "CustomerID", true));
            this.cboClientName.DataSource = this.vCustomersBindingSource;
            this.cboClientName.DisplayMember = "FullName";
            this.cboClientName.FormattingEnabled = true;
            this.cboClientName.Location = new System.Drawing.Point(144, 20);
            this.cboClientName.Name = "cboClientName";
            this.cboClientName.Size = new System.Drawing.Size(200, 21);
            this.cboClientName.TabIndex = 58;
            // 
            // vCustomersBindingSource
            // 
            this.vCustomersBindingSource.DataMember = "vCustomers";
            this.vCustomersBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // horseFarmDataSet1
            // 
            this.horseFarmDataSet1.DataSetName = "HorseFarmDataSet1";
            this.horseFarmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewLessonSubmit
            // 
            this.btnNewLessonSubmit.Location = new System.Drawing.Point(32, 283);
            this.btnNewLessonSubmit.Name = "btnNewLessonSubmit";
            this.btnNewLessonSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnNewLessonSubmit.TabIndex = 56;
            this.btnNewLessonSubmit.Text = "Submit";
            this.btnNewLessonSubmit.UseVisualStyleBackColor = true;
            // 
            // txtNewLessonClass
            // 
            this.txtNewLessonClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "Class", true));
            this.txtNewLessonClass.Location = new System.Drawing.Point(144, 47);
            this.txtNewLessonClass.Name = "txtNewLessonClass";
            this.txtNewLessonClass.Size = new System.Drawing.Size(200, 20);
            this.txtNewLessonClass.TabIndex = 41;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // dateNewLessonDate
            // 
            this.dateNewLessonDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "LessonDate", true));
            this.dateNewLessonDate.Location = new System.Drawing.Point(144, 99);
            this.dateNewLessonDate.Name = "dateNewLessonDate";
            this.dateNewLessonDate.Size = new System.Drawing.Size(200, 20);
            this.dateNewLessonDate.TabIndex = 45;
            // 
            // txtLessonPrior
            // 
            this.txtLessonPrior.Location = new System.Drawing.Point(144, 185);
            this.txtLessonPrior.Name = "txtLessonPrior";
            this.txtLessonPrior.Size = new System.Drawing.Size(200, 20);
            this.txtLessonPrior.TabIndex = 49;
            // 
            // txtExperienceOfClass
            // 
            this.txtExperienceOfClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.experienceLevelsBindingSource, "ExperienceLevel", true));
            this.txtExperienceOfClass.Location = new System.Drawing.Point(144, 211);
            this.txtExperienceOfClass.Name = "txtExperienceOfClass";
            this.txtExperienceOfClass.Size = new System.Drawing.Size(200, 20);
            this.txtExperienceOfClass.TabIndex = 51;
            // 
            // experienceLevelsBindingSource
            // 
            this.experienceLevelsBindingSource.DataMember = "ExperienceLevels";
            this.experienceLevelsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // txtTypeOfClass
            // 
            this.txtTypeOfClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "TypeOfLesson", true));
            this.txtTypeOfClass.Location = new System.Drawing.Point(144, 237);
            this.txtTypeOfClass.Name = "txtTypeOfClass";
            this.txtTypeOfClass.Size = new System.Drawing.Size(200, 20);
            this.txtTypeOfClass.TabIndex = 55;
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
            // txtNewLessonTime
            // 
            this.txtNewLessonTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lessonsBindingSource, "LessonTime", true));
            this.txtNewLessonTime.Location = new System.Drawing.Point(144, 131);
            this.txtNewLessonTime.Name = "txtNewLessonTime";
            this.txtNewLessonTime.Size = new System.Drawing.Size(200, 20);
            this.txtNewLessonTime.TabIndex = 61;
            // 
            // btnPrintReciept
            // 
            this.btnPrintReciept.Location = new System.Drawing.Point(132, 283);
            this.btnPrintReciept.Name = "btnPrintReciept";
            this.btnPrintReciept.Size = new System.Drawing.Size(79, 23);
            this.btnPrintReciept.TabIndex = 62;
            this.btnPrintReciept.Text = "Print Reciept";
            this.btnPrintReciept.UseVisualStyleBackColor = true;
            // 
            // vCustomersTableAdapter
            // 
            this.vCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // cboNewLessonInstructor
            // 
            this.cboNewLessonInstructor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.instructorsBindingSource, "LastName", true));
            this.cboNewLessonInstructor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instructorsBindingSource, "InstructorID", true));
            this.cboNewLessonInstructor.DataSource = this.lessonsBindingSource;
            this.cboNewLessonInstructor.FormattingEnabled = true;
            this.cboNewLessonInstructor.Location = new System.Drawing.Point(144, 72);
            this.cboNewLessonInstructor.Name = "cboNewLessonInstructor";
            this.cboNewLessonInstructor.Size = new System.Drawing.Size(200, 21);
            this.cboNewLessonInstructor.TabIndex = 63;
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
            // cboNewLessonStudent
            // 
            this.cboNewLessonStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dependentsBindingSource, "DependentID", true));
            this.cboNewLessonStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dependentsBindingSource, "FirstName", true));
            this.cboNewLessonStudent.DataSource = this.dependentsBindingSource;
            this.cboNewLessonStudent.DisplayMember = "FirstName";
            this.cboNewLessonStudent.FormattingEnabled = true;
            this.cboNewLessonStudent.Location = new System.Drawing.Point(144, 157);
            this.cboNewLessonStudent.Name = "cboNewLessonStudent";
            this.cboNewLessonStudent.Size = new System.Drawing.Size(200, 21);
            this.cboNewLessonStudent.TabIndex = 64;
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
            // experienceLevelsTableAdapter
            // 
            this.experienceLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // newLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 324);
            this.Controls.Add(this.cboNewLessonStudent);
            this.Controls.Add(this.cboNewLessonInstructor);
            this.Controls.Add(this.btnPrintReciept);
            this.Controls.Add(this.txtNewLessonTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClientName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewLessonSubmit);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.txtNewLessonClass);
            this.Controls.Add(instructionLabel);
            this.Controls.Add(timeDateLabel);
            this.Controls.Add(this.dateNewLessonDate);
            this.Controls.Add(studentLabel);
            this.Controls.Add(lessPriorLabel);
            this.Controls.Add(this.txtLessonPrior);
            this.Controls.Add(expereanceOfClassLabel);
            this.Controls.Add(this.txtExperienceOfClass);
            this.Controls.Add(kindLabel);
            this.Controls.Add(this.txtTypeOfClass);
            this.Name = "newLesson";
            this.Text = "New Lesson";
            this.Load += new System.EventHandler(this.newLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceLevelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClientName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewLessonSubmit;
        private System.Windows.Forms.TextBox txtNewLessonClass;
        private System.Windows.Forms.DateTimePicker dateNewLessonDate;
        private System.Windows.Forms.TextBox txtLessonPrior;
        private System.Windows.Forms.TextBox txtExperienceOfClass;
        private System.Windows.Forms.TextBox txtTypeOfClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewLessonTime;
        private System.Windows.Forms.Button btnPrintReciept;
        private HorseFarmDataSet1 horseFarmDataSet1;
        private System.Windows.Forms.BindingSource vCustomersBindingSource;
        private HorseFarmDataSet1TableAdapters.vCustomersTableAdapter vCustomersTableAdapter;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private HorseFarmDataSet1TableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private System.Windows.Forms.ComboBox cboNewLessonInstructor;
        private System.Windows.Forms.BindingSource instructorsBindingSource;
        private HorseFarmDataSet1TableAdapters.InstructorsTableAdapter instructorsTableAdapter;
        private System.Windows.Forms.ComboBox cboNewLessonStudent;
        private System.Windows.Forms.BindingSource dependentsBindingSource;
        private HorseFarmDataSet1TableAdapters.DependentsTableAdapter dependentsTableAdapter;
        private System.Windows.Forms.BindingSource experienceLevelsBindingSource;
        private HorseFarmDataSet1TableAdapters.ExperienceLevelsTableAdapter experienceLevelsTableAdapter;
    }
}