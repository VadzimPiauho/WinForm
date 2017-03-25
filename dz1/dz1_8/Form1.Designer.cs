namespace dz1_8
{
    partial class BestOil
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
            this.groupBoxAvto = new System.Windows.Forms.GroupBox();
            this.comboBoxBenz = new System.Windows.Forms.ComboBox();
            this.labelCenaBenz = new System.Windows.Forms.Label();
            this.labelBenz = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelRubBenz = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBoxCenaBenz = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBoxOplataBenz = new System.Windows.Forms.GroupBox();
            this.labelItogoBenz = new System.Windows.Forms.Label();
            this.labelItogoRubBenz = new System.Windows.Forms.Label();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.labelCenaKafe = new System.Windows.Forms.Label();
            this.labelKolih = new System.Windows.Forms.Label();
            this.textBoxCoca = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxFri = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxGamb = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxDog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxCoca = new System.Windows.Forms.CheckBox();
            this.checkBoxFri = new System.Windows.Forms.CheckBox();
            this.checkBoxGamb = new System.Windows.Forms.CheckBox();
            this.checkBoxDog = new System.Windows.Forms.CheckBox();
            this.groupBoxOplataCafe = new System.Windows.Forms.GroupBox();
            this.labelItogoCafe = new System.Windows.Forms.Label();
            this.labelItogoRubCafe = new System.Windows.Forms.Label();
            this.groupBoxItogo = new System.Windows.Forms.GroupBox();
            this.labelItogo = new System.Windows.Forms.Label();
            this.labelItogoRub = new System.Windows.Forms.Label();
            this.buttonItogo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAvto.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxOplataBenz.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.groupBoxOplataCafe.SuspendLayout();
            this.groupBoxItogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAvto
            // 
            this.groupBoxAvto.Controls.Add(this.comboBoxBenz);
            this.groupBoxAvto.Controls.Add(this.labelCenaBenz);
            this.groupBoxAvto.Controls.Add(this.labelBenz);
            this.groupBoxAvto.Controls.Add(this.groupBox6);
            this.groupBoxAvto.Controls.Add(this.labelRubBenz);
            this.groupBoxAvto.Controls.Add(this.label10);
            this.groupBoxAvto.Controls.Add(this.label9);
            this.groupBoxAvto.Controls.Add(this.textBox10);
            this.groupBoxAvto.Controls.Add(this.textBoxCenaBenz);
            this.groupBoxAvto.Controls.Add(this.textBox9);
            this.groupBoxAvto.Controls.Add(this.groupBoxOplataBenz);
            this.groupBoxAvto.Location = new System.Drawing.Point(12, 32);
            this.groupBoxAvto.Name = "groupBoxAvto";
            this.groupBoxAvto.Size = new System.Drawing.Size(251, 361);
            this.groupBoxAvto.TabIndex = 0;
            this.groupBoxAvto.TabStop = false;
            this.groupBoxAvto.Text = "Автозаправка";
            // 
            // comboBoxBenz
            // 
            this.comboBoxBenz.CausesValidation = false;
            this.comboBoxBenz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBenz.FormattingEnabled = true;
            this.comboBoxBenz.Items.AddRange(new object[] {
            "АИ-92",
            "АИ-95",
            "АИ-98",
            "Газ",
            "Дизтопливо"});
            this.comboBoxBenz.Location = new System.Drawing.Point(70, 58);
            this.comboBoxBenz.Name = "comboBoxBenz";
            this.comboBoxBenz.Size = new System.Drawing.Size(134, 21);
            this.comboBoxBenz.TabIndex = 5;
            this.comboBoxBenz.SelectedIndexChanged += new System.EventHandler(this.comboBoxBenz_VisibleChanged);
            // 
            // labelCenaBenz
            // 
            this.labelCenaBenz.AutoSize = true;
            this.labelCenaBenz.Location = new System.Drawing.Point(9, 98);
            this.labelCenaBenz.Name = "labelCenaBenz";
            this.labelCenaBenz.Size = new System.Drawing.Size(33, 13);
            this.labelCenaBenz.TabIndex = 4;
            this.labelCenaBenz.Text = "Цена";
            // 
            // labelBenz
            // 
            this.labelBenz.AutoSize = true;
            this.labelBenz.Location = new System.Drawing.Point(9, 58);
            this.labelBenz.Name = "labelBenz";
            this.labelBenz.Size = new System.Drawing.Size(44, 13);
            this.labelBenz.TabIndex = 4;
            this.labelBenz.Text = "Бензин";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Location = new System.Drawing.Point(9, 148);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(125, 83);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Количество";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Сумма";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelRubBenz
            // 
            this.labelRubBenz.AutoSize = true;
            this.labelRubBenz.Location = new System.Drawing.Point(210, 98);
            this.labelRubBenz.Name = "labelRubBenz";
            this.labelRubBenz.Size = new System.Drawing.Size(27, 13);
            this.labelRubBenz.TabIndex = 0;
            this.labelRubBenz.Text = "руб.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "л.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "руб.";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(140, 200);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(64, 20);
            this.textBox10.TabIndex = 2;
            this.textBox10.Text = "0";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox10.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.textBox10.Leave += new System.EventHandler(this.textBoxDog_Leave);
            // 
            // textBoxCenaBenz
            // 
            this.textBoxCenaBenz.Location = new System.Drawing.Point(70, 98);
            this.textBoxCenaBenz.Name = "textBoxCenaBenz";
            this.textBoxCenaBenz.ReadOnly = true;
            this.textBoxCenaBenz.Size = new System.Drawing.Size(134, 20);
            this.textBoxCenaBenz.TabIndex = 2;
            this.textBoxCenaBenz.Text = "1.13";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(140, 164);
            this.textBox9.MaxLength = 3;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(64, 20);
            this.textBox9.TabIndex = 2;
            this.textBox9.Text = "0";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDog_KeyPress);
            this.textBox9.Leave += new System.EventHandler(this.textBoxDog_Leave);
            // 
            // groupBoxOplataBenz
            // 
            this.groupBoxOplataBenz.Controls.Add(this.labelItogoBenz);
            this.groupBoxOplataBenz.Controls.Add(this.labelItogoRubBenz);
            this.groupBoxOplataBenz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxOplataBenz.Location = new System.Drawing.Point(7, 244);
            this.groupBoxOplataBenz.Name = "groupBoxOplataBenz";
            this.groupBoxOplataBenz.Size = new System.Drawing.Size(238, 111);
            this.groupBoxOplataBenz.TabIndex = 0;
            this.groupBoxOplataBenz.TabStop = false;
            this.groupBoxOplataBenz.Text = "К оплате:";
            // 
            // labelItogoBenz
            // 
            this.labelItogoBenz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItogoBenz.Location = new System.Drawing.Point(5, 36);
            this.labelItogoBenz.Name = "labelItogoBenz";
            this.labelItogoBenz.Size = new System.Drawing.Size(170, 56);
            this.labelItogoBenz.TabIndex = 1;
            this.labelItogoBenz.Text = "0.00";
            this.labelItogoBenz.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelItogoRubBenz
            // 
            this.labelItogoRubBenz.AutoSize = true;
            this.labelItogoRubBenz.Location = new System.Drawing.Point(193, 79);
            this.labelItogoRubBenz.Name = "labelItogoRubBenz";
            this.labelItogoRubBenz.Size = new System.Drawing.Size(27, 13);
            this.labelItogoRubBenz.TabIndex = 0;
            this.labelItogoRubBenz.Text = "руб.";
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.labelCenaKafe);
            this.groupBoxCafe.Controls.Add(this.labelKolih);
            this.groupBoxCafe.Controls.Add(this.textBoxCoca);
            this.groupBoxCafe.Controls.Add(this.textBox4);
            this.groupBoxCafe.Controls.Add(this.textBoxFri);
            this.groupBoxCafe.Controls.Add(this.textBox3);
            this.groupBoxCafe.Controls.Add(this.textBoxGamb);
            this.groupBoxCafe.Controls.Add(this.textBox2);
            this.groupBoxCafe.Controls.Add(this.textBoxDog);
            this.groupBoxCafe.Controls.Add(this.textBox1);
            this.groupBoxCafe.Controls.Add(this.checkBoxCoca);
            this.groupBoxCafe.Controls.Add(this.checkBoxFri);
            this.groupBoxCafe.Controls.Add(this.checkBoxGamb);
            this.groupBoxCafe.Controls.Add(this.checkBoxDog);
            this.groupBoxCafe.Controls.Add(this.groupBoxOplataCafe);
            this.groupBoxCafe.Location = new System.Drawing.Point(320, 32);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(251, 361);
            this.groupBoxCafe.TabIndex = 0;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Кафе";
            // 
            // labelCenaKafe
            // 
            this.labelCenaKafe.AutoSize = true;
            this.labelCenaKafe.Location = new System.Drawing.Point(104, 28);
            this.labelCenaKafe.Name = "labelCenaKafe";
            this.labelCenaKafe.Size = new System.Drawing.Size(33, 13);
            this.labelCenaKafe.TabIndex = 3;
            this.labelCenaKafe.Text = "Цена";
            // 
            // labelKolih
            // 
            this.labelKolih.AutoSize = true;
            this.labelKolih.Location = new System.Drawing.Point(180, 28);
            this.labelKolih.Name = "labelKolih";
            this.labelKolih.Size = new System.Drawing.Size(66, 13);
            this.labelKolih.TabIndex = 3;
            this.labelKolih.Text = "Количество";
            // 
            // textBoxCoca
            // 
            this.textBoxCoca.Location = new System.Drawing.Point(180, 148);
            this.textBoxCoca.MaxLength = 3;
            this.textBoxCoca.Name = "textBoxCoca";
            this.textBoxCoca.ReadOnly = true;
            this.textBoxCoca.Size = new System.Drawing.Size(52, 20);
            this.textBoxCoca.TabIndex = 2;
            this.textBoxCoca.Text = "0";
            this.textBoxCoca.TextChanged += new System.EventHandler(this.textBoxDog_TextChanged);
            this.textBoxCoca.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBoxCoca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDog_KeyPress);
            this.textBoxCoca.Leave += new System.EventHandler(this.textBoxDog_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "4.40";
            // 
            // textBoxFri
            // 
            this.textBoxFri.Location = new System.Drawing.Point(180, 118);
            this.textBoxFri.MaxLength = 3;
            this.textBoxFri.Name = "textBoxFri";
            this.textBoxFri.ReadOnly = true;
            this.textBoxFri.Size = new System.Drawing.Size(52, 20);
            this.textBoxFri.TabIndex = 2;
            this.textBoxFri.Text = "0";
            this.textBoxFri.TextChanged += new System.EventHandler(this.textBoxDog_TextChanged);
            this.textBoxFri.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBoxFri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDog_KeyPress);
            this.textBoxFri.Leave += new System.EventHandler(this.textBoxDog_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(52, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "7.20";
            // 
            // textBoxGamb
            // 
            this.textBoxGamb.Location = new System.Drawing.Point(180, 88);
            this.textBoxGamb.MaxLength = 3;
            this.textBoxGamb.Name = "textBoxGamb";
            this.textBoxGamb.ReadOnly = true;
            this.textBoxGamb.Size = new System.Drawing.Size(52, 20);
            this.textBoxGamb.TabIndex = 2;
            this.textBoxGamb.Text = "0";
            this.textBoxGamb.TextChanged += new System.EventHandler(this.textBoxDog_TextChanged);
            this.textBoxGamb.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBoxGamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDog_KeyPress);
            this.textBoxGamb.Leave += new System.EventHandler(this.textBoxDog_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "5.40";
            // 
            // textBoxDog
            // 
            this.textBoxDog.Location = new System.Drawing.Point(180, 58);
            this.textBoxDog.MaxLength = 3;
            this.textBoxDog.Name = "textBoxDog";
            this.textBoxDog.ReadOnly = true;
            this.textBoxDog.Size = new System.Drawing.Size(52, 20);
            this.textBoxDog.TabIndex = 2;
            this.textBoxDog.Text = "0";
            this.textBoxDog.TextChanged += new System.EventHandler(this.textBoxDog_TextChanged);
            this.textBoxDog.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBoxDog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDog_KeyPress);
            this.textBoxDog.Leave += new System.EventHandler(this.textBoxDog_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "4.00";
            // 
            // checkBoxCoca
            // 
            this.checkBoxCoca.AutoSize = true;
            this.checkBoxCoca.Location = new System.Drawing.Point(6, 148);
            this.checkBoxCoca.Name = "checkBoxCoca";
            this.checkBoxCoca.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCoca.TabIndex = 1;
            this.checkBoxCoca.Text = "Кока-кола";
            this.checkBoxCoca.UseVisualStyleBackColor = true;
            this.checkBoxCoca.CheckStateChanged += new System.EventHandler(this.checkBoxDog_CheckedChanged);
            // 
            // checkBoxFri
            // 
            this.checkBoxFri.AutoSize = true;
            this.checkBoxFri.Location = new System.Drawing.Point(6, 118);
            this.checkBoxFri.Name = "checkBoxFri";
            this.checkBoxFri.Size = new System.Drawing.Size(99, 17);
            this.checkBoxFri.TabIndex = 1;
            this.checkBoxFri.Text = "Картошка-фри";
            this.checkBoxFri.UseVisualStyleBackColor = true;
            this.checkBoxFri.CheckStateChanged += new System.EventHandler(this.checkBoxDog_CheckedChanged);
            // 
            // checkBoxGamb
            // 
            this.checkBoxGamb.AutoSize = true;
            this.checkBoxGamb.Location = new System.Drawing.Point(6, 88);
            this.checkBoxGamb.Name = "checkBoxGamb";
            this.checkBoxGamb.Size = new System.Drawing.Size(80, 17);
            this.checkBoxGamb.TabIndex = 1;
            this.checkBoxGamb.Text = "Гамбургер";
            this.checkBoxGamb.UseVisualStyleBackColor = true;
            this.checkBoxGamb.CheckStateChanged += new System.EventHandler(this.checkBoxDog_CheckedChanged);
            // 
            // checkBoxDog
            // 
            this.checkBoxDog.AutoSize = true;
            this.checkBoxDog.Location = new System.Drawing.Point(6, 58);
            this.checkBoxDog.Name = "checkBoxDog";
            this.checkBoxDog.Size = new System.Drawing.Size(64, 17);
            this.checkBoxDog.TabIndex = 1;
            this.checkBoxDog.Text = "Хот-дог";
            this.checkBoxDog.UseVisualStyleBackColor = true;
            this.checkBoxDog.CheckStateChanged += new System.EventHandler(this.checkBoxDog_CheckedChanged);
            // 
            // groupBoxOplataCafe
            // 
            this.groupBoxOplataCafe.Controls.Add(this.labelItogoCafe);
            this.groupBoxOplataCafe.Controls.Add(this.labelItogoRubCafe);
            this.groupBoxOplataCafe.Location = new System.Drawing.Point(7, 244);
            this.groupBoxOplataCafe.Name = "groupBoxOplataCafe";
            this.groupBoxOplataCafe.Size = new System.Drawing.Size(238, 111);
            this.groupBoxOplataCafe.TabIndex = 0;
            this.groupBoxOplataCafe.TabStop = false;
            this.groupBoxOplataCafe.Text = "К оплате:";
            // 
            // labelItogoCafe
            // 
            this.labelItogoCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItogoCafe.Location = new System.Drawing.Point(5, 36);
            this.labelItogoCafe.Name = "labelItogoCafe";
            this.labelItogoCafe.Size = new System.Drawing.Size(170, 56);
            this.labelItogoCafe.TabIndex = 1;
            this.labelItogoCafe.Text = "0.00";
            this.labelItogoCafe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelItogoRubCafe
            // 
            this.labelItogoRubCafe.AutoSize = true;
            this.labelItogoRubCafe.Location = new System.Drawing.Point(193, 79);
            this.labelItogoRubCafe.Name = "labelItogoRubCafe";
            this.labelItogoRubCafe.Size = new System.Drawing.Size(27, 13);
            this.labelItogoRubCafe.TabIndex = 0;
            this.labelItogoRubCafe.Text = "руб.";
            // 
            // groupBoxItogo
            // 
            this.groupBoxItogo.Controls.Add(this.labelItogo);
            this.groupBoxItogo.Controls.Add(this.labelItogoRub);
            this.groupBoxItogo.Controls.Add(this.buttonItogo);
            this.groupBoxItogo.Location = new System.Drawing.Point(12, 400);
            this.groupBoxItogo.Name = "groupBoxItogo";
            this.groupBoxItogo.Size = new System.Drawing.Size(559, 114);
            this.groupBoxItogo.TabIndex = 1;
            this.groupBoxItogo.TabStop = false;
            this.groupBoxItogo.Text = "ИТОГО к оплате:";
            // 
            // labelItogo
            // 
            this.labelItogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItogo.Location = new System.Drawing.Point(371, 31);
            this.labelItogo.Name = "labelItogo";
            this.labelItogo.Size = new System.Drawing.Size(117, 56);
            this.labelItogo.TabIndex = 1;
            this.labelItogo.Text = "0.00";
            // 
            // labelItogoRub
            // 
            this.labelItogoRub.AutoSize = true;
            this.labelItogoRub.Location = new System.Drawing.Point(506, 74);
            this.labelItogoRub.Name = "labelItogoRub";
            this.labelItogoRub.Size = new System.Drawing.Size(27, 13);
            this.labelItogoRub.TabIndex = 0;
            this.labelItogoRub.Text = "руб.";
            // 
            // buttonItogo
            // 
            this.buttonItogo.Location = new System.Drawing.Point(6, 31);
            this.buttonItogo.Name = "buttonItogo";
            this.buttonItogo.Size = new System.Drawing.Size(245, 56);
            this.buttonItogo.TabIndex = 0;
            this.buttonItogo.Text = "ПОДСЧИТАТЬ";
            this.buttonItogo.UseVisualStyleBackColor = true;
            this.buttonItogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 527);
            this.Controls.Add(this.groupBoxItogo);
            this.Controls.Add(this.groupBoxCafe);
            this.Controls.Add(this.groupBoxAvto);
            this.Name = "BestOil";
            this.Text = "BestOil";
            this.groupBoxAvto.ResumeLayout(false);
            this.groupBoxAvto.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxOplataBenz.ResumeLayout(false);
            this.groupBoxOplataBenz.PerformLayout();
            this.groupBoxCafe.ResumeLayout(false);
            this.groupBoxCafe.PerformLayout();
            this.groupBoxOplataCafe.ResumeLayout(false);
            this.groupBoxOplataCafe.PerformLayout();
            this.groupBoxItogo.ResumeLayout(false);
            this.groupBoxItogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAvto;
        private System.Windows.Forms.GroupBox groupBoxOplataBenz;
        private System.Windows.Forms.Label labelItogoBenz;
        private System.Windows.Forms.Label labelItogoRubBenz;
        private System.Windows.Forms.GroupBox groupBoxCafe;
        private System.Windows.Forms.GroupBox groupBoxOplataCafe;
        private System.Windows.Forms.Label labelItogoCafe;
        private System.Windows.Forms.Label labelItogoRubCafe;
        private System.Windows.Forms.GroupBox groupBoxItogo;
        private System.Windows.Forms.Label labelItogo;
        private System.Windows.Forms.Label labelItogoRub;
        private System.Windows.Forms.Button buttonItogo;
        private System.Windows.Forms.ComboBox comboBoxBenz;
        private System.Windows.Forms.Label labelCenaBenz;
        private System.Windows.Forms.Label labelBenz;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelRubBenz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBoxCenaBenz;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label labelCenaKafe;
        private System.Windows.Forms.Label labelKolih;
        private System.Windows.Forms.TextBox textBoxCoca;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxFri;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxGamb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxDog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxCoca;
        private System.Windows.Forms.CheckBox checkBoxFri;
        private System.Windows.Forms.CheckBox checkBoxGamb;
        private System.Windows.Forms.CheckBox checkBoxDog;
        private System.Windows.Forms.Timer timer1;
    }
}

