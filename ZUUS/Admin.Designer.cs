namespace ZUUS
{
    partial class Admin
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
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNewUser = new System.Windows.Forms.Label();
            this.labelAdmins = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAccountBalance = new System.Windows.Forms.TextBox();
            this.textBoxIncrementFactor = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelIdAndUser = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDateRegister = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxNumerCard = new System.Windows.Forms.TextBox();
            this.dateTimePickerYearCard = new System.Windows.Forms.DateTimePicker();
            this.textBoxCVC = new System.Windows.Forms.TextBox();
            this.dateTimePickerPayDay = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumerAccountBank = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.comboBoxPayed = new System.Windows.Forms.ComboBox();
            this.buttonPayDay = new System.Windows.Forms.Button();
            this.buttonSetNo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(114, 32);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(242, 33);
            this.comboBoxUser.TabIndex = 0;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheck.Location = new System.Drawing.Point(362, 28);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(121, 39);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Wybierz";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ilość użytkowników:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ilość administratorów:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Najnowszy użytkownik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cała kwota w banku:";
            // 
            // labelNewUser
            // 
            this.labelNewUser.AutoSize = true;
            this.labelNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewUser.Location = new System.Drawing.Point(274, 131);
            this.labelNewUser.Name = "labelNewUser";
            this.labelNewUser.Size = new System.Drawing.Size(26, 25);
            this.labelNewUser.TabIndex = 9;
            this.labelNewUser.Text = "A";
            // 
            // labelAdmins
            // 
            this.labelAdmins.AutoSize = true;
            this.labelAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdmins.Location = new System.Drawing.Point(274, 106);
            this.labelAdmins.Name = "labelAdmins";
            this.labelAdmins.Size = new System.Drawing.Size(26, 25);
            this.labelAdmins.TabIndex = 10;
            this.labelAdmins.Text = "A";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsers.Location = new System.Drawing.Point(274, 81);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(26, 25);
            this.labelUsers.TabIndex = 11;
            this.labelUsers.Text = "A";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoney.Location = new System.Drawing.Point(274, 156);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(26, 25);
            this.labelMoney.TabIndex = 12;
            this.labelMoney.Text = "A";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(255, 243);
            this.textBoxName.MaxLength = 20;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(143, 30);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(195, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Imie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(147, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nazwisko:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(112, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rok urodzenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(192, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rola:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(180, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "E-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(137, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Stan konta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(24, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Współczynnik przyrostu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(63, 498);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Stawka miesięczna:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(47, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "INFORMACJE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(669, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Rok karty:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(645, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Numer karty:";
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(255, 315);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.ShowUpDown = true;
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(143, 30);
            this.dateTimePickerBirthDay.TabIndex = 27;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurName.Location = new System.Drawing.Point(255, 279);
            this.textBoxSurName.MaxLength = 40;
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(228, 30);
            this.textBoxSurName.TabIndex = 28;
            this.textBoxSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurName_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(255, 387);
            this.textBoxEmail.MaxLength = 75;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(228, 30);
            this.textBoxEmail.TabIndex = 30;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // textBoxAccountBalance
            // 
            this.textBoxAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAccountBalance.Location = new System.Drawing.Point(255, 423);
            this.textBoxAccountBalance.Name = "textBoxAccountBalance";
            this.textBoxAccountBalance.Size = new System.Drawing.Size(228, 30);
            this.textBoxAccountBalance.TabIndex = 31;
            this.textBoxAccountBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAccountBalance_KeyPress);
            // 
            // textBoxIncrementFactor
            // 
            this.textBoxIncrementFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIncrementFactor.Location = new System.Drawing.Point(255, 459);
            this.textBoxIncrementFactor.Name = "textBoxIncrementFactor";
            this.textBoxIncrementFactor.Size = new System.Drawing.Size(228, 30);
            this.textBoxIncrementFactor.TabIndex = 32;
            this.textBoxIncrementFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIncrementFactor_KeyPress);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRate.Location = new System.Drawing.Point(255, 495);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(143, 30);
            this.textBoxRate.TabIndex = 33;
            this.textBoxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRate_KeyPress);
            // 
            // labelIdAndUser
            // 
            this.labelIdAndUser.AutoSize = true;
            this.labelIdAndUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdAndUser.Location = new System.Drawing.Point(195, 209);
            this.labelIdAndUser.Name = "labelIdAndUser";
            this.labelIdAndUser.Size = new System.Drawing.Size(84, 25);
            this.labelIdAndUser.TabIndex = 35;
            this.labelIdAndUser.Text = "ID+User";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(103, 531);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 25);
            this.label17.TabIndex = 36;
            this.label17.Text = "Data rejestracji:";
            // 
            // textBoxDateRegister
            // 
            this.textBoxDateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDateRegister.Location = new System.Drawing.Point(255, 531);
            this.textBoxDateRegister.Name = "textBoxDateRegister";
            this.textBoxDateRegister.ReadOnly = true;
            this.textBoxDateRegister.Size = new System.Drawing.Size(143, 30);
            this.textBoxDateRegister.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(633, 356);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 25);
            this.label18.TabIndex = 39;
            this.label18.Text = "Data płatności";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(706, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 25);
            this.label19.TabIndex = 38;
            this.label19.Text = "CVC:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(523, 426);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(245, 25);
            this.label20.TabIndex = 41;
            this.label20.Text = "Czy zapłacono za miesiąc:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(533, 390);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(235, 25);
            this.label21.TabIndex = 40;
            this.label21.Text = "Numer konta bankowego:";
            // 
            // textBoxNumerCard
            // 
            this.textBoxNumerCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumerCard.Location = new System.Drawing.Point(774, 243);
            this.textBoxNumerCard.MaxLength = 16;
            this.textBoxNumerCard.Name = "textBoxNumerCard";
            this.textBoxNumerCard.Size = new System.Drawing.Size(307, 30);
            this.textBoxNumerCard.TabIndex = 42;
            this.textBoxNumerCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumerCard_KeyPress);
            // 
            // dateTimePickerYearCard
            // 
            this.dateTimePickerYearCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerYearCard.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerYearCard.Location = new System.Drawing.Point(774, 279);
            this.dateTimePickerYearCard.Name = "dateTimePickerYearCard";
            this.dateTimePickerYearCard.ShowUpDown = true;
            this.dateTimePickerYearCard.Size = new System.Drawing.Size(143, 30);
            this.dateTimePickerYearCard.TabIndex = 43;
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCVC.Location = new System.Drawing.Point(774, 315);
            this.textBoxCVC.MaxLength = 3;
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(66, 30);
            this.textBoxCVC.TabIndex = 44;
            this.textBoxCVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCVC_KeyPress);
            // 
            // dateTimePickerPayDay
            // 
            this.dateTimePickerPayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerPayDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPayDay.Location = new System.Drawing.Point(774, 354);
            this.dateTimePickerPayDay.Name = "dateTimePickerPayDay";
            this.dateTimePickerPayDay.ShowUpDown = true;
            this.dateTimePickerPayDay.Size = new System.Drawing.Size(143, 30);
            this.dateTimePickerPayDay.TabIndex = 45;
            // 
            // textBoxNumerAccountBank
            // 
            this.textBoxNumerAccountBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumerAccountBank.Location = new System.Drawing.Point(774, 390);
            this.textBoxNumerAccountBank.MaxLength = 26;
            this.textBoxNumerAccountBank.Name = "textBoxNumerAccountBank";
            this.textBoxNumerAccountBank.Size = new System.Drawing.Size(307, 30);
            this.textBoxNumerAccountBank.TabIndex = 46;
            this.textBoxNumerAccountBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumerAccountBank_KeyPress);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChange.Location = new System.Drawing.Point(774, 462);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(204, 45);
            this.buttonChange.TabIndex = 48;
            this.buttonChange.Text = "Dokonaj zmian";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPayed
            // 
            this.comboBoxPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPayed.FormattingEnabled = true;
            this.comboBoxPayed.Items.AddRange(new object[] {
            "TAK",
            "NIE"});
            this.comboBoxPayed.Location = new System.Drawing.Point(774, 423);
            this.comboBoxPayed.Name = "comboBoxPayed";
            this.comboBoxPayed.Size = new System.Drawing.Size(66, 33);
            this.comboBoxPayed.TabIndex = 49;
            // 
            // buttonPayDay
            // 
            this.buttonPayDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPayDay.Location = new System.Drawing.Point(711, 531);
            this.buttonPayDay.Name = "buttonPayDay";
            this.buttonPayDay.Size = new System.Drawing.Size(189, 67);
            this.buttonPayDay.TabIndex = 51;
            this.buttonPayDay.Text = "Wykonaj zapłatę";
            this.buttonPayDay.UseVisualStyleBackColor = false;
            this.buttonPayDay.Click += new System.EventHandler(this.buttonPayDay_Click);
            // 
            // buttonSetNo
            // 
            this.buttonSetNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetNo.Location = new System.Drawing.Point(906, 531);
            this.buttonSetNo.Name = "buttonSetNo";
            this.buttonSetNo.Size = new System.Drawing.Size(180, 67);
            this.buttonSetNo.TabIndex = 52;
            this.buttonSetNo.Text = "Ustaw wszystkim brak zapłaty";
            this.buttonSetNo.UseVisualStyleBackColor = false;
            this.buttonSetNo.Click += new System.EventHandler(this.buttonSetNo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(516, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 67);
            this.button1.TabIndex = 53;
            this.button1.Text = "Wykonaj zmianę współczynnika";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Użytkownik"});
            this.comboBoxRole.Location = new System.Drawing.Point(255, 348);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(124, 33);
            this.comboBoxRole.TabIndex = 54;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(934, 32);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 59);
            this.buttonDelete.TabIndex = 55;
            this.buttonDelete.Text = "Usuń użytkownika";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 620);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSetNo);
            this.Controls.Add(this.buttonPayDay);
            this.Controls.Add(this.comboBoxPayed);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxNumerAccountBank);
            this.Controls.Add(this.dateTimePickerPayDay);
            this.Controls.Add(this.textBoxCVC);
            this.Controls.Add(this.dateTimePickerYearCard);
            this.Controls.Add(this.textBoxNumerCard);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxDateRegister);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelIdAndUser);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.textBoxIncrementFactor);
            this.Controls.Add(this.textBoxAccountBalance);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.dateTimePickerBirthDay);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.labelAdmins);
            this.Controls.Add(this.labelNewUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.comboBoxUser);
            this.MinimumSize = new System.Drawing.Size(570, 340);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNewUser;
        private System.Windows.Forms.Label labelAdmins;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDay;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAccountBalance;
        private System.Windows.Forms.TextBox textBoxIncrementFactor;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelIdAndUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxDateRegister;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxNumerCard;
        private System.Windows.Forms.DateTimePicker dateTimePickerYearCard;
        private System.Windows.Forms.TextBox textBoxCVC;
        private System.Windows.Forms.DateTimePicker dateTimePickerPayDay;
        private System.Windows.Forms.TextBox textBoxNumerAccountBank;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ComboBox comboBoxPayed;
        private System.Windows.Forms.Button buttonPayDay;
        private System.Windows.Forms.Button buttonSetNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonDelete;
    }
}