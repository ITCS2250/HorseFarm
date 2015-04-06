namespace WorksOnSchoolMachines
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label timeDateLabel;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.horseFarmDataSet1 = new WorksOnSchoolMachines.HorseFarmDataSet1();
            this.vetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetsTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.VetsTableAdapter();
            this.vetsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.horseCareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseCareTableAdapter = new WorksOnSchoolMachines.HorseFarmDataSet1TableAdapters.HorseCareTableAdapter();
            timeLabel = new System.Windows.Forms.Label();
            timeDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseCareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(18, 272);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 29;
            timeLabel.Text = "Time:";
            // 
            // timeDateLabel
            // 
            timeDateLabel.AutoSize = true;
            timeDateLabel.Location = new System.Drawing.Point(18, 247);
            timeDateLabel.Name = "timeDateLabel";
            timeDateLabel.Size = new System.Drawing.Size(33, 13);
            timeDateLabel.TabIndex = 26;
            timeDateLabel.Text = "Date:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horseCareBindingSource, "Reason", true));
            this.textBox1.Location = new System.Drawing.Point(85, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horseCareBindingSource, "SickTime", true));
            this.timeTextBox.Location = new System.Drawing.Point(85, 269);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 20);
            this.timeTextBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Reason:";
            // 
            // timeDateDateTimePicker
            // 
            this.timeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horseCareBindingSource, "SickDate", true));
            this.timeDateDateTimePicker.Location = new System.Drawing.Point(85, 243);
            this.timeDateDateTimePicker.Name = "timeDateDateTimePicker";
            this.timeDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeDateDateTimePicker.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Vet Name:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vetsBindingSource1;
            this.comboBox1.DisplayMember = "LastName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "View Calendar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // horseFarmDataSet1
            // 
            this.horseFarmDataSet1.DataSetName = "HorseFarmDataSet1";
            this.horseFarmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vetsBindingSource
            // 
            this.vetsBindingSource.DataMember = "Vets";
            this.vetsBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // vetsTableAdapter
            // 
            this.vetsTableAdapter.ClearBeforeFill = true;
            // 
            // vetsBindingSource1
            // 
            this.vetsBindingSource1.DataMember = "Vets";
            this.vetsBindingSource1.DataSource = this.horseFarmDataSet1;
            // 
            // horseCareBindingSource
            // 
            this.horseCareBindingSource.DataMember = "HorseCare";
            this.horseCareBindingSource.DataSource = this.horseFarmDataSet1;
            // 
            // horseCareTableAdapter
            // 
            this.horseCareTableAdapter.ClearBeforeFill = true;
            // 
            // horseCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(timeDateLabel);
            this.Controls.Add(this.timeDateDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "horseCare";
            this.Text = "horseCare";
            this.Load += new System.EventHandler(this.horseCare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horseFarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseCareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeDateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private HorseFarmDataSet1 horseFarmDataSet1;
        private System.Windows.Forms.BindingSource vetsBindingSource;
        private HorseFarmDataSet1TableAdapters.VetsTableAdapter vetsTableAdapter;
        private System.Windows.Forms.BindingSource vetsBindingSource1;
        private System.Windows.Forms.BindingSource horseCareBindingSource;
        private HorseFarmDataSet1TableAdapters.HorseCareTableAdapter horseCareTableAdapter;
    }
}