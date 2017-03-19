namespace dz1_6
{
    partial class FormDay
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
            this.buttonDayGet = new System.Windows.Forms.Button();
            this.buttonDayClear = new System.Windows.Forms.Button();
            this.textBoxDaySet = new System.Windows.Forms.TextBox();
            this.textBoxDayGet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDayGet
            // 
            this.buttonDayGet.Location = new System.Drawing.Point(117, 111);
            this.buttonDayGet.Name = "buttonDayGet";
            this.buttonDayGet.Size = new System.Drawing.Size(187, 44);
            this.buttonDayGet.TabIndex = 0;
            this.buttonDayGet.Text = "OK";
            this.buttonDayGet.UseVisualStyleBackColor = true;
            this.buttonDayGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDayClear
            // 
            this.buttonDayClear.Location = new System.Drawing.Point(117, 246);
            this.buttonDayClear.Name = "buttonDayClear";
            this.buttonDayClear.Size = new System.Drawing.Size(187, 44);
            this.buttonDayClear.TabIndex = 0;
            this.buttonDayClear.Text = "Очистить";
            this.buttonDayClear.UseVisualStyleBackColor = true;
            this.buttonDayClear.Click += new System.EventHandler(this.buttonDayClear_Click);
            // 
            // textBoxDaySet
            // 
            this.textBoxDaySet.Location = new System.Drawing.Point(117, 54);
            this.textBoxDaySet.Name = "textBoxDaySet";
            this.textBoxDaySet.Size = new System.Drawing.Size(187, 20);
            this.textBoxDaySet.TabIndex = 1;
            this.textBoxDaySet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDaySet.Enter += new System.EventHandler(this.textBoxDaySet_Enter);
            // 
            // textBoxDayGet
            // 
            this.textBoxDayGet.Enabled = false;
            this.textBoxDayGet.Location = new System.Drawing.Point(117, 185);
            this.textBoxDayGet.Name = "textBoxDayGet";
            this.textBoxDayGet.ReadOnly = true;
            this.textBoxDayGet.Size = new System.Drawing.Size(187, 20);
            this.textBoxDayGet.TabIndex = 1;
            this.textBoxDayGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 357);
            this.Controls.Add(this.textBoxDayGet);
            this.Controls.Add(this.textBoxDaySet);
            this.Controls.Add(this.buttonDayClear);
            this.Controls.Add(this.buttonDayGet);
            this.Name = "FormDay";
            this.Text = "День недели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDayGet;
        private System.Windows.Forms.Button buttonDayClear;
        private System.Windows.Forms.TextBox textBoxDaySet;
        private System.Windows.Forms.TextBox textBoxDayGet;
    }
}

