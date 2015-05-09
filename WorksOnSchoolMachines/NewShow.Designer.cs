namespace HorseFarm
{
    partial class NewShow
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
            this.btnAddShowSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNewShowCustName = new System.Windows.Forms.ComboBox();
            this.cboNewShowHorseName = new System.Windows.Forms.ComboBox();
            this.txtShowName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAddShowSubmit
            // 
            this.btnAddShowSubmit.Location = new System.Drawing.Point(24, 171);
            this.btnAddShowSubmit.Name = "btnAddShowSubmit";
            this.btnAddShowSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnAddShowSubmit.TabIndex = 0;
            this.btnAddShowSubmit.Text = "Submit";
            this.btnAddShowSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(123, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horse Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Show Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Show Name";
            // 
            // cboNewShowCustName
            // 
            this.cboNewShowCustName.FormattingEnabled = true;
            this.cboNewShowCustName.Location = new System.Drawing.Point(123, 19);
            this.cboNewShowCustName.Name = "cboNewShowCustName";
            this.cboNewShowCustName.Size = new System.Drawing.Size(121, 21);
            this.cboNewShowCustName.TabIndex = 6;
            // 
            // cboNewShowHorseName
            // 
            this.cboNewShowHorseName.FormattingEnabled = true;
            this.cboNewShowHorseName.Location = new System.Drawing.Point(123, 54);
            this.cboNewShowHorseName.Name = "cboNewShowHorseName";
            this.cboNewShowHorseName.Size = new System.Drawing.Size(121, 21);
            this.cboNewShowHorseName.TabIndex = 7;
            // 
            // txtShowName
            // 
            this.txtShowName.Location = new System.Drawing.Point(123, 89);
            this.txtShowName.Name = "txtShowName";
            this.txtShowName.Size = new System.Drawing.Size(100, 20);
            this.txtShowName.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // NewShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 219);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtShowName);
            this.Controls.Add(this.cboNewShowHorseName);
            this.Controls.Add(this.cboNewShowCustName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddShowSubmit);
            this.Name = "NewShow";
            this.Text = "Add Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddShowSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNewShowCustName;
        private System.Windows.Forms.ComboBox cboNewShowHorseName;
        private System.Windows.Forms.TextBox txtShowName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}