namespace HorseFarm
{
    partial class horseCare
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
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label timeDateLabel;
            this.txtVetReason = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHCsubmit = new System.Windows.Forms.Button();
            this.txtHorseCareTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeDateHorseCare = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVetName = new System.Windows.Forms.ComboBox();
            this.btnHCviewCalendar = new System.Windows.Forms.Button();
            timeLabel = new System.Windows.Forms.Label();
            timeDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(22, 95);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 29;
            timeLabel.Text = "Time:";
            // 
            // timeDateLabel
            // 
            timeDateLabel.AutoSize = true;
            timeDateLabel.Location = new System.Drawing.Point(22, 70);
            timeDateLabel.Name = "timeDateLabel";
            timeDateLabel.Size = new System.Drawing.Size(33, 13);
            timeDateLabel.TabIndex = 26;
            timeDateLabel.Text = "Date:";
            // 
            // txtVetReason
            // 
            this.txtVetReason.Location = new System.Drawing.Point(89, 39);
            this.txtVetReason.Name = "txtVetReason";
            this.txtVetReason.Size = new System.Drawing.Size(200, 20);
            this.txtVetReason.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnHCsubmit
            // 
            this.btnHCsubmit.Location = new System.Drawing.Point(25, 131);
            this.btnHCsubmit.Name = "btnHCsubmit";
            this.btnHCsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnHCsubmit.TabIndex = 31;
            this.btnHCsubmit.Text = "Submit";
            this.btnHCsubmit.UseVisualStyleBackColor = true;
            // 
            // txtHorseCareTime
            // 
            this.txtHorseCareTime.Location = new System.Drawing.Point(89, 92);
            this.txtHorseCareTime.Name = "txtHorseCareTime";
            this.txtHorseCareTime.Size = new System.Drawing.Size(200, 20);
            this.txtHorseCareTime.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Reason:";
            // 
            // timeDateHorseCare
            // 
            this.timeDateHorseCare.Location = new System.Drawing.Point(89, 66);
            this.timeDateHorseCare.Name = "timeDateHorseCare";
            this.timeDateHorseCare.Size = new System.Drawing.Size(200, 20);
            this.timeDateHorseCare.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Vet Name:";
            // 
            // cboVetName
            // 
            this.cboVetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVetName.FormattingEnabled = true;
            this.cboVetName.Location = new System.Drawing.Point(89, 12);
            this.cboVetName.Name = "cboVetName";
            this.cboVetName.Size = new System.Drawing.Size(200, 21);
            this.cboVetName.TabIndex = 34;
            // 
            // btnHCviewCalendar
            // 
            this.btnHCviewCalendar.Location = new System.Drawing.Point(120, 131);
            this.btnHCviewCalendar.Name = "btnHCviewCalendar";
            this.btnHCviewCalendar.Size = new System.Drawing.Size(74, 23);
            this.btnHCviewCalendar.TabIndex = 35;
            this.btnHCviewCalendar.Text = "Calendar";
            this.btnHCviewCalendar.UseVisualStyleBackColor = true;
            this.btnHCviewCalendar.Click += new System.EventHandler(this.btnHCviewCalendar_Click);
            // 
            // horseCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 168);
            this.Controls.Add(this.btnHCviewCalendar);
            this.Controls.Add(this.cboVetName);
            this.Controls.Add(this.txtVetReason);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHCsubmit);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.txtHorseCareTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(timeDateLabel);
            this.Controls.Add(this.timeDateHorseCare);
            this.Controls.Add(this.label1);
            this.Name = "horseCare";
            this.Text = "Horse Care";
            this.Load += new System.EventHandler(this.horseCare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVetReason;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHCsubmit;
        private System.Windows.Forms.TextBox txtHorseCareTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeDateHorseCare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVetName;
        private System.Windows.Forms.Button btnHCviewCalendar;
    }
}