namespace HorseFarm
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
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label instructionLabel;
            System.Windows.Forms.Label timeDateLabel;
            System.Windows.Forms.Label kindLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewLessonSubmit = new System.Windows.Forms.Button();
            this.txtNewLessonClass = new System.Windows.Forms.TextBox();
            this.dateNewLessonDate = new System.Windows.Forms.DateTimePicker();
            this.txtTypeOfClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewLessonTime = new System.Windows.Forms.TextBox();
            this.btnPrintReciept = new System.Windows.Forms.Button();
            this.cboNewLessonInstructor = new System.Windows.Forms.ComboBox();
            classLabel = new System.Windows.Forms.Label();
            instructionLabel = new System.Windows.Forms.Label();
            timeDateLabel = new System.Windows.Forms.Label();
            kindLabel = new System.Windows.Forms.Label();
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
            // kindLabel
            // 
            kindLabel.AutoSize = true;
            kindLabel.Location = new System.Drawing.Point(29, 164);
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
            this.cboClientName.FormattingEnabled = true;
            this.cboClientName.Location = new System.Drawing.Point(144, 20);
            this.cboClientName.Name = "cboClientName";
            this.cboClientName.Size = new System.Drawing.Size(200, 21);
            this.cboClientName.TabIndex = 58;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 187);
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
            this.btnNewLessonSubmit.Location = new System.Drawing.Point(34, 187);
            this.btnNewLessonSubmit.Name = "btnNewLessonSubmit";
            this.btnNewLessonSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnNewLessonSubmit.TabIndex = 56;
            this.btnNewLessonSubmit.Text = "Submit";
            this.btnNewLessonSubmit.UseVisualStyleBackColor = true;
            // 
            // txtNewLessonClass
            // 
            this.txtNewLessonClass.Location = new System.Drawing.Point(144, 47);
            this.txtNewLessonClass.Name = "txtNewLessonClass";
            this.txtNewLessonClass.Size = new System.Drawing.Size(200, 20);
            this.txtNewLessonClass.TabIndex = 41;
            // 
            // dateNewLessonDate
            // 
            this.dateNewLessonDate.Location = new System.Drawing.Point(144, 99);
            this.dateNewLessonDate.Name = "dateNewLessonDate";
            this.dateNewLessonDate.Size = new System.Drawing.Size(200, 20);
            this.dateNewLessonDate.TabIndex = 45;
            // 
            // txtTypeOfClass
            // 
            this.txtTypeOfClass.Location = new System.Drawing.Point(144, 161);
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
            this.txtNewLessonTime.Location = new System.Drawing.Point(144, 131);
            this.txtNewLessonTime.Name = "txtNewLessonTime";
            this.txtNewLessonTime.Size = new System.Drawing.Size(200, 20);
            this.txtNewLessonTime.TabIndex = 61;
            // 
            // btnPrintReciept
            // 
            this.btnPrintReciept.Location = new System.Drawing.Point(134, 187);
            this.btnPrintReciept.Name = "btnPrintReciept";
            this.btnPrintReciept.Size = new System.Drawing.Size(79, 23);
            this.btnPrintReciept.TabIndex = 62;
            this.btnPrintReciept.Text = "Print Reciept";
            this.btnPrintReciept.UseVisualStyleBackColor = true;
            // 
            // cboNewLessonInstructor
            // 
            this.cboNewLessonInstructor.FormattingEnabled = true;
            this.cboNewLessonInstructor.Location = new System.Drawing.Point(144, 72);
            this.cboNewLessonInstructor.Name = "cboNewLessonInstructor";
            this.cboNewLessonInstructor.Size = new System.Drawing.Size(200, 21);
            this.cboNewLessonInstructor.TabIndex = 63;
            // 
            // newLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 227);
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
            this.Controls.Add(kindLabel);
            this.Controls.Add(this.txtTypeOfClass);
            this.Name = "newLesson";
            this.Text = "New Lesson";
            this.Load += new System.EventHandler(this.newLesson_Load);
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
        private System.Windows.Forms.TextBox txtTypeOfClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewLessonTime;
        private System.Windows.Forms.Button btnPrintReciept;
        private System.Windows.Forms.ComboBox cboNewLessonInstructor;
        private System.Windows.Forms.ComboBox cboNewLessonStudent;
    }
}