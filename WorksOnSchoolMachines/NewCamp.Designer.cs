namespace HorseFarm
{
    partial class NewCamp
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewHorseSubmit = new System.Windows.Forms.Button();
            this.NewHorseNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewHorseSubmit
            // 
            this.btnNewHorseSubmit.Location = new System.Drawing.Point(98, 66);
            this.btnNewHorseSubmit.Name = "btnNewHorseSubmit";
            this.btnNewHorseSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnNewHorseSubmit.TabIndex = 6;
            this.btnNewHorseSubmit.Text = "Submit";
            this.btnNewHorseSubmit.UseVisualStyleBackColor = true;
            // 
            // NewHorseNametxt
            // 
            this.NewHorseNametxt.Location = new System.Drawing.Point(98, 29);
            this.NewHorseNametxt.Name = "NewHorseNametxt";
            this.NewHorseNametxt.Size = new System.Drawing.Size(165, 20);
            this.NewHorseNametxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Camp Name";
            // 
            // NewCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewHorseSubmit);
            this.Controls.Add(this.NewHorseNametxt);
            this.Controls.Add(this.label1);
            this.Name = "NewCamp";
            this.Text = "Add Camp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewHorseSubmit;
        private System.Windows.Forms.TextBox NewHorseNametxt;
        private System.Windows.Forms.Label label1;
    }
}