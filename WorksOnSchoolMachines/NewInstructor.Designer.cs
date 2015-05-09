namespace HorseFarm
{
    partial class NewInstructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInstructorFirstName = new System.Windows.Forms.TextBox();
            this.txtInstructorLastName = new System.Windows.Forms.TextBox();
            this.btnInstructorSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txtInstructorFirstName
            // 
            this.txtInstructorFirstName.Location = new System.Drawing.Point(89, 19);
            this.txtInstructorFirstName.Name = "txtInstructorFirstName";
            this.txtInstructorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtInstructorFirstName.TabIndex = 2;
            // 
            // txtInstructorLastName
            // 
            this.txtInstructorLastName.Location = new System.Drawing.Point(89, 46);
            this.txtInstructorLastName.Name = "txtInstructorLastName";
            this.txtInstructorLastName.Size = new System.Drawing.Size(100, 20);
            this.txtInstructorLastName.TabIndex = 3;
            // 
            // btnInstructorSubmit
            // 
            this.btnInstructorSubmit.Location = new System.Drawing.Point(15, 100);
            this.btnInstructorSubmit.Name = "btnInstructorSubmit";
            this.btnInstructorSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnInstructorSubmit.TabIndex = 4;
            this.btnInstructorSubmit.Text = "Submit";
            this.btnInstructorSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(114, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 144);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInstructorSubmit);
            this.Controls.Add(this.txtInstructorLastName);
            this.Controls.Add(this.txtInstructorFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewInstructor";
            this.Text = "Add Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInstructorFirstName;
        private System.Windows.Forms.TextBox txtInstructorLastName;
        private System.Windows.Forms.Button btnInstructorSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}