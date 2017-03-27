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
            this.buttonExportFiel = new System.Windows.Forms.Button();
            this.buttonImportFile = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonDell = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirst
            // 
            this.labelFirst.Location = new System.Drawing.Point(15, 20);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(55, 23);
            this.labelFirst.TabIndex = 0;
            this.labelFirst.Text = "Имя";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLast
            // 
            this.labelLast.Location = new System.Drawing.Point(15, 45);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(55, 23);
            this.labelLast.TabIndex = 0;
            this.labelLast.Text = "Фамилия";
            this.labelLast.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMail
            // 
            this.labelMail.Location = new System.Drawing.Point(15, 70);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(55, 23);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "E-mail";
            this.labelMail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(15, 95);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 23);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Телефон";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBox
            // 
            this.listBox.ColumnWidth = 50;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(0, 152);
            this.listBox.MultiColumn = true;
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(441, 173);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
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
            this.textBoxFirst.Location = new System.Drawing.Point(75, 20);
            this.textBoxFirst.MaxLength = 25;
            this.textBoxFirst.Multiline = true;
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(195, 23);
            this.textBoxFirst.TabIndex = 3;
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(75, 45);
            this.textBoxLast.MaxLength = 25;
            this.textBoxLast.Multiline = true;
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(195, 23);
            this.textBoxLast.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(75, 95);
            this.textBoxPhone.MaxLength = 25;
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(195, 23);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(75, 70);
            this.textBoxMail.MaxLength = 25;
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(195, 23);
            this.textBoxMail.TabIndex = 3;
            // 
            // buttonExportFiel
            // 
            this.buttonExportFiel.Location = new System.Drawing.Point(275, 20);
            this.buttonExportFiel.Name = "buttonExportFiel";
            this.buttonExportFiel.Size = new System.Drawing.Size(155, 23);
            this.buttonExportFiel.TabIndex = 2;
            this.buttonExportFiel.Text = "Экспорт в текстовый файл";
            this.buttonExportFiel.UseVisualStyleBackColor = true;
            this.buttonExportFiel.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonImportFile
            // 
            this.buttonImportFile.Location = new System.Drawing.Point(275, 45);
            this.buttonImportFile.Name = "buttonImportFile";
            this.buttonImportFile.Size = new System.Drawing.Size(155, 23);
            this.buttonImportFile.TabIndex = 2;
            this.buttonImportFile.Text = "Импорт из текстового файла";
            this.buttonImportFile.UseVisualStyleBackColor = true;
            this.buttonImportFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(275, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Экспорт в XML";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Импорт из XML";
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
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(325, 125);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 325);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonImportFile);
            this.Controls.Add(this.buttonExportFiel);
            this.Controls.Add(this.buttonClear);
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
        private System.Windows.Forms.Button buttonExportFiel;
        private System.Windows.Forms.Button buttonImportFile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonDell;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClear;
    }
}

