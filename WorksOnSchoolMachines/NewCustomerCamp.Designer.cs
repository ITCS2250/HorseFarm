namespace HorseFarm
{
    partial class NewCustomerCamp
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
            this.btnCampSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboCampName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStudentName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camp Name";
            // 
            // btnCampSubmit
            // 
            this.btnCampSubmit.Location = new System.Drawing.Point(15, 97);
            this.btnCampSubmit.Name = "btnCampSubmit";
            this.btnCampSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCampSubmit.TabIndex = 2;
            this.btnCampSubmit.Text = "Submit";
            this.btnCampSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(98, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboCampName
            // 
            this.cboCampName.FormattingEnabled = true;
            this.cboCampName.Location = new System.Drawing.Point(99, 18);
            this.cboCampName.Name = "cboCampName";
            this.cboCampName.Size = new System.Drawing.Size(121, 21);
            this.cboCampName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Name";
            // 
            // cboStudentName
            // 
            this.cboStudentName.FormattingEnabled = true;
            this.cboStudentName.Location = new System.Drawing.Point(99, 51);
            this.cboStudentName.Name = "cboStudentName";
            this.cboStudentName.Size = new System.Drawing.Size(121, 21);
            this.cboStudentName.TabIndex = 6;
            // 
            // NewCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 139);
            this.Controls.Add(this.cboStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCampName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCampSubmit);
            this.Controls.Add(this.label1);
            this.Name = "NewCamp";
            this.Text = "Add Camp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCampSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboCampName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStudentName;
    }
}