namespace dz2_2
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
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonDell = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirst
            // 
            this.labelFirst.Location = new System.Drawing.Point(15, 20);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(100, 23);
            this.labelFirst.TabIndex = 0;
            this.labelFirst.Text = "Имя";
            // 
            // labelLast
            // 
            this.labelLast.Location = new System.Drawing.Point(15, 45);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(100, 23);
            this.labelLast.TabIndex = 0;
            this.labelLast.Text = "Фамилия";
            // 
            // labelMail
            // 
            this.labelMail.Location = new System.Drawing.Point(15, 70);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(100, 23);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "E-mail";
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(15, 95);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(100, 23);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Телефон";
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 156);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(422, 173);
            this.listBox.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 125);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(125, 20);
            this.textBoxFirst.Multiline = true;
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirst.TabIndex = 3;
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(125, 45);
            this.textBoxLast.Multiline = true;
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(100, 23);
            this.textBoxLast.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(125, 95);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 23);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(125, 70);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 23);
            this.textBoxMail.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Экспорт в текстовый файл";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Импорт в текстовый файл";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Экспорт в текстовый XML";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Импорт в текстовый XML";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonDell
            // 
            this.buttonDell.Location = new System.Drawing.Point(115, 125);
            this.buttonDell.Name = "buttonDell";
            this.buttonDell.Size = new System.Drawing.Size(105, 23);
            this.buttonDell.TabIndex = 2;
            this.buttonDell.Text = "Удалить";
            this.buttonDell.UseVisualStyleBackColor = true;
            this.buttonDell.Click += new System.EventHandler(this.buttonDell_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(220, 125);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 329);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDell);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonDell;
        private System.Windows.Forms.Button buttonEdit;
    }
}

