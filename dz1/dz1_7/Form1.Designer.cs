namespace dz1_7
{
    partial class Form1
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
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSek = new System.Windows.Forms.RadioButton();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.radioButtonMonts = new System.Windows.Forms.RadioButton();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(173, 48);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(158, 20);
            this.textBoxEnter.TabIndex = 0;
            this.textBoxEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEnter.TextChanged += new System.EventHandler(this.textBoxEnter_TextChanged);
            this.textBoxEnter.Enter += new System.EventHandler(this.textBoxEnter_Enter);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(173, 87);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(158, 27);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "OK";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Enabled = false;
            this.textBoxRes.Location = new System.Drawing.Point(173, 136);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(158, 20);
            this.textBoxRes.TabIndex = 0;
            this.textBoxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(173, 180);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(158, 27);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSek);
            this.groupBox1.Controls.Add(this.radioButtonMin);
            this.groupBox1.Controls.Add(this.radioButtonDay);
            this.groupBox1.Controls.Add(this.radioButtonMonts);
            this.groupBox1.Controls.Add(this.radioButtonYears);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "формат вывода";
            // 
            // radioButtonSek
            // 
            this.radioButtonSek.AutoSize = true;
            this.radioButtonSek.Location = new System.Drawing.Point(20, 116);
            this.radioButtonSek.Name = "radioButtonSek";
            this.radioButtonSek.Size = new System.Drawing.Size(80, 17);
            this.radioButtonSek.TabIndex = 0;
            this.radioButtonSek.Text = "в секундах";
            this.radioButtonSek.UseVisualStyleBackColor = true;
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.AutoSize = true;
            this.radioButtonMin.Location = new System.Drawing.Point(20, 93);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(75, 17);
            this.radioButtonMin.TabIndex = 0;
            this.radioButtonMin.Text = "в минутах";
            this.radioButtonMin.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(20, 70);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDay.TabIndex = 0;
            this.radioButtonDay.Text = "в днях";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonts
            // 
            this.radioButtonMonts.AutoSize = true;
            this.radioButtonMonts.Location = new System.Drawing.Point(20, 47);
            this.radioButtonMonts.Name = "radioButtonMonts";
            this.radioButtonMonts.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMonts.TabIndex = 0;
            this.radioButtonMonts.Text = "в месяцах";
            this.radioButtonMonts.UseVisualStyleBackColor = true;
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Checked = true;
            this.radioButtonYears.Location = new System.Drawing.Point(20, 28);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(62, 17);
            this.radioButtonYears.TabIndex = 0;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "в годах";
            this.radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.textBoxEnter);
            this.Name = "Form1";
            this.Text = "До указанной даты..";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSek;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.RadioButton radioButtonMonts;
        private System.Windows.Forms.RadioButton radioButtonYears;
    }
}

