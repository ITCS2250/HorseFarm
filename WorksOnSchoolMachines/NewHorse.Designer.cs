namespace HorseFarm
{
    partial class NewHorse
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
            this.NewHorseNametxt = new System.Windows.Forms.TextBox();
            this.btnNewHorseSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horse Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewHorseNametxt
            // 
            this.NewHorseNametxt.Location = new System.Drawing.Point(94, 28);
            this.NewHorseNametxt.Name = "NewHorseNametxt";
            this.NewHorseNametxt.Size = new System.Drawing.Size(100, 20);
            this.NewHorseNametxt.TabIndex = 1;
            this.NewHorseNametxt.TextChanged += new System.EventHandler(this.NewHorseNametxt_TextChanged);
            // 
            // btnNewHorseSubmit
            // 
            this.btnNewHorseSubmit.Location = new System.Drawing.Point(94, 82);
            this.btnNewHorseSubmit.Name = "btnNewHorseSubmit";
            this.btnNewHorseSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnNewHorseSubmit.TabIndex = 2;
            this.btnNewHorseSubmit.Text = "Submit";
            this.btnNewHorseSubmit.UseVisualStyleBackColor = true;
            this.btnNewHorseSubmit.Click += new System.EventHandler(this.btnNewHorseSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 117);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewHorseSubmit);
            this.Controls.Add(this.NewHorseNametxt);
            this.Controls.Add(this.label1);
            this.Name = "NewHorse";
            this.Text = "Add Horse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewHorseNametxt;
        private System.Windows.Forms.Button btnNewHorseSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}