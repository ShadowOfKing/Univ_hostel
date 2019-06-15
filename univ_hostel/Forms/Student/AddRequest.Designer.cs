namespace univ_hostel.Forms.Student
{
	partial class AddRequest
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
			this.button_sendRequest = new System.Windows.Forms.Button();
			this.container_tabs = new System.Windows.Forms.TabControl();
			this.tab_common = new System.Windows.Forms.TabPage();
			this.input_isBudged = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.input_birthday = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.input_faculty = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.input_group = new System.Windows.Forms.ComboBox();
			this.input_patronymic = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.input_name = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.input_lastname = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tab_private = new System.Windows.Forms.TabPage();
			this.input_passportNumber = new System.Windows.Forms.MaskedTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.input_passportSeria = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.input_TIN = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tab_contact = new System.Windows.Forms.TabPage();
			this.input_email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.input_phone = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.input_address = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.keyboard = new UnivHostelKeyboardControl.Keyboard();
			this.container_tabs.SuspendLayout();
			this.tab_common.SuspendLayout();
			this.tab_private.SuspendLayout();
			this.tab_contact.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_sendRequest
			// 
			this.button_sendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_sendRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_sendRequest.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_sendRequest.Location = new System.Drawing.Point(12, 511);
			this.button_sendRequest.Name = "button_sendRequest";
			this.button_sendRequest.Size = new System.Drawing.Size(982, 58);
			this.button_sendRequest.TabIndex = 2;
			this.button_sendRequest.Text = "Отправить заявку";
			this.button_sendRequest.UseVisualStyleBackColor = true;
			this.button_sendRequest.Click += new System.EventHandler(this.button_sendRequest_Click);
			// 
			// container_tabs
			// 
			this.container_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.container_tabs.Controls.Add(this.tab_common);
			this.container_tabs.Controls.Add(this.tab_private);
			this.container_tabs.Controls.Add(this.tab_contact);
			this.container_tabs.Location = new System.Drawing.Point(1, 0);
			this.container_tabs.Name = "container_tabs";
			this.container_tabs.SelectedIndex = 0;
			this.container_tabs.Size = new System.Drawing.Size(1013, 275);
			this.container_tabs.TabIndex = 0;
			// 
			// tab_common
			// 
			this.tab_common.Controls.Add(this.input_isBudged);
			this.tab_common.Controls.Add(this.label6);
			this.tab_common.Controls.Add(this.input_birthday);
			this.tab_common.Controls.Add(this.label12);
			this.tab_common.Controls.Add(this.label11);
			this.tab_common.Controls.Add(this.input_faculty);
			this.tab_common.Controls.Add(this.label10);
			this.tab_common.Controls.Add(this.input_group);
			this.tab_common.Controls.Add(this.input_patronymic);
			this.tab_common.Controls.Add(this.label7);
			this.tab_common.Controls.Add(this.input_name);
			this.tab_common.Controls.Add(this.label8);
			this.tab_common.Controls.Add(this.input_lastname);
			this.tab_common.Controls.Add(this.label9);
			this.tab_common.Location = new System.Drawing.Point(4, 22);
			this.tab_common.Name = "tab_common";
			this.tab_common.Padding = new System.Windows.Forms.Padding(3);
			this.tab_common.Size = new System.Drawing.Size(1005, 249);
			this.tab_common.TabIndex = 0;
			this.tab_common.Text = "Общее";
			this.tab_common.UseVisualStyleBackColor = true;
			// 
			// input_isBudged
			// 
			this.input_isBudged.AutoSize = true;
			this.input_isBudged.Location = new System.Drawing.Point(212, 85);
			this.input_isBudged.Name = "input_isBudged";
			this.input_isBudged.Size = new System.Drawing.Size(15, 14);
			this.input_isBudged.TabIndex = 25;
			this.input_isBudged.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 85);
			this.label6.MinimumSize = new System.Drawing.Size(139, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "Бюджетное обучение";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_birthday
			// 
			this.input_birthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_birthday.Location = new System.Drawing.Point(212, 222);
			this.input_birthday.Name = "input_birthday";
			this.input_birthday.Size = new System.Drawing.Size(715, 20);
			this.input_birthday.TabIndex = 23;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(28, 226);
			this.label12.MinimumSize = new System.Drawing.Size(139, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(139, 13);
			this.label12.TabIndex = 22;
			this.label12.Text = "Дата рождения";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(28, 21);
			this.label11.MinimumSize = new System.Drawing.Size(139, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(139, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "Факультет";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_faculty
			// 
			this.input_faculty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_faculty.FormattingEnabled = true;
			this.input_faculty.Location = new System.Drawing.Point(212, 18);
			this.input_faculty.Name = "input_faculty";
			this.input_faculty.Size = new System.Drawing.Size(715, 21);
			this.input_faculty.TabIndex = 20;
			this.input_faculty.SelectedValueChanged += new System.EventHandler(this.input_faculty_SelectedValueChanged);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(28, 56);
			this.label10.MinimumSize = new System.Drawing.Size(139, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(139, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "Группа";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_group
			// 
			this.input_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_group.FormattingEnabled = true;
			this.input_group.Location = new System.Drawing.Point(212, 53);
			this.input_group.Name = "input_group";
			this.input_group.Size = new System.Drawing.Size(715, 21);
			this.input_group.TabIndex = 18;
			// 
			// input_patronymic
			// 
			this.input_patronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_patronymic.Location = new System.Drawing.Point(212, 186);
			this.input_patronymic.Name = "input_patronymic";
			this.input_patronymic.Size = new System.Drawing.Size(715, 20);
			this.input_patronymic.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(28, 189);
			this.label7.MinimumSize = new System.Drawing.Size(139, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Отчество";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_name
			// 
			this.input_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_name.Location = new System.Drawing.Point(212, 151);
			this.input_name.Name = "input_name";
			this.input_name.Size = new System.Drawing.Size(715, 20);
			this.input_name.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(28, 154);
			this.label8.MinimumSize = new System.Drawing.Size(139, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Имя";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_lastname
			// 
			this.input_lastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_lastname.Location = new System.Drawing.Point(212, 116);
			this.input_lastname.Name = "input_lastname";
			this.input_lastname.Size = new System.Drawing.Size(715, 20);
			this.input_lastname.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(28, 119);
			this.label9.MinimumSize = new System.Drawing.Size(139, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(139, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Фамилия";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tab_private
			// 
			this.tab_private.Controls.Add(this.input_passportNumber);
			this.tab_private.Controls.Add(this.label13);
			this.tab_private.Controls.Add(this.input_passportSeria);
			this.tab_private.Controls.Add(this.label4);
			this.tab_private.Controls.Add(this.input_TIN);
			this.tab_private.Controls.Add(this.label5);
			this.tab_private.Location = new System.Drawing.Point(4, 22);
			this.tab_private.Name = "tab_private";
			this.tab_private.Padding = new System.Windows.Forms.Padding(3);
			this.tab_private.Size = new System.Drawing.Size(1019, 269);
			this.tab_private.TabIndex = 1;
			this.tab_private.Text = "Личные данные";
			this.tab_private.UseVisualStyleBackColor = true;
			// 
			// input_passportNumber
			// 
			this.input_passportNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_passportNumber.Location = new System.Drawing.Point(212, 88);
			this.input_passportNumber.Mask = "999999";
			this.input_passportNumber.Name = "input_passportNumber";
			this.input_passportNumber.Size = new System.Drawing.Size(729, 20);
			this.input_passportNumber.TabIndex = 13;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(28, 91);
			this.label13.MinimumSize = new System.Drawing.Size(139, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(139, 13);
			this.label13.TabIndex = 12;
			this.label13.Text = "Номер паспорта";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_passportSeria
			// 
			this.input_passportSeria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_passportSeria.Location = new System.Drawing.Point(212, 53);
			this.input_passportSeria.Mask = "9999";
			this.input_passportSeria.Name = "input_passportSeria";
			this.input_passportSeria.Size = new System.Drawing.Size(729, 20);
			this.input_passportSeria.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 56);
			this.label4.MinimumSize = new System.Drawing.Size(139, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Серия паспорта";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_TIN
			// 
			this.input_TIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_TIN.Location = new System.Drawing.Point(212, 18);
			this.input_TIN.Mask = "999999999999";
			this.input_TIN.Name = "input_TIN";
			this.input_TIN.Size = new System.Drawing.Size(729, 20);
			this.input_TIN.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 21);
			this.label5.MinimumSize = new System.Drawing.Size(139, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "ИНН";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tab_contact
			// 
			this.tab_contact.Controls.Add(this.input_email);
			this.tab_contact.Controls.Add(this.label3);
			this.tab_contact.Controls.Add(this.input_phone);
			this.tab_contact.Controls.Add(this.label2);
			this.tab_contact.Controls.Add(this.input_address);
			this.tab_contact.Controls.Add(this.label1);
			this.tab_contact.Location = new System.Drawing.Point(4, 22);
			this.tab_contact.Name = "tab_contact";
			this.tab_contact.Padding = new System.Windows.Forms.Padding(3);
			this.tab_contact.Size = new System.Drawing.Size(1019, 269);
			this.tab_contact.TabIndex = 2;
			this.tab_contact.Text = "Контактные данные";
			this.tab_contact.UseVisualStyleBackColor = true;
			// 
			// input_email
			// 
			this.input_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_email.Location = new System.Drawing.Point(212, 88);
			this.input_email.Name = "input_email";
			this.input_email.Size = new System.Drawing.Size(729, 20);
			this.input_email.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 91);
			this.label3.MinimumSize = new System.Drawing.Size(139, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Адрес электронной почты";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_phone
			// 
			this.input_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_phone.Location = new System.Drawing.Point(212, 53);
			this.input_phone.Mask = "+9 (999) 000-0000";
			this.input_phone.Name = "input_phone";
			this.input_phone.Size = new System.Drawing.Size(729, 20);
			this.input_phone.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 56);
			this.label2.MinimumSize = new System.Drawing.Size(139, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Номер телефона";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_address
			// 
			this.input_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_address.Location = new System.Drawing.Point(212, 18);
			this.input_address.Name = "input_address";
			this.input_address.Size = new System.Drawing.Size(729, 20);
			this.input_address.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 21);
			this.label1.MinimumSize = new System.Drawing.Size(139, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Адрес прописки";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 575);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(982, 58);
			this.button1.TabIndex = 3;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// keyboard
			// 
			this.keyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.keyboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.keyboard.Location = new System.Drawing.Point(12, 281);
			this.keyboard.Name = "keyboard";
			this.keyboard.Size = new System.Drawing.Size(982, 224);
			this.keyboard.TabIndex = 4;
			// 
			// AddRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 645);
			this.Controls.Add(this.keyboard);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_sendRequest);
			this.Controls.Add(this.container_tabs);
			this.Name = "AddRequest";
			this.Text = "Создание заявки";
			this.container_tabs.ResumeLayout(false);
			this.tab_common.ResumeLayout(false);
			this.tab_common.PerformLayout();
			this.tab_private.ResumeLayout(false);
			this.tab_private.PerformLayout();
			this.tab_contact.ResumeLayout(false);
			this.tab_contact.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl container_tabs;
		private System.Windows.Forms.TabPage tab_common;
		private System.Windows.Forms.TabPage tab_private;
		private System.Windows.Forms.Button button_sendRequest;
		private System.Windows.Forms.TabPage tab_contact;
		private System.Windows.Forms.MaskedTextBox input_phone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox input_address;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox input_email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox input_faculty;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox input_group;
		private System.Windows.Forms.TextBox input_patronymic;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox input_name;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox input_lastname;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MaskedTextBox input_passportSeria;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox input_TIN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox input_passportNumber;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker input_birthday;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox input_isBudged;
		private System.Windows.Forms.Label label6;
		private UnivHostelKeyboardControl.Keyboard keyboard;
	}
}