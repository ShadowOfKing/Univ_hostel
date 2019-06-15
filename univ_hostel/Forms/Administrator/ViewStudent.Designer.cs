namespace univ_hostel.Forms.Administrator
{
	partial class ViewStudent
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
			this.button1 = new System.Windows.Forms.Button();
			this.button_sendRequest = new System.Windows.Forms.Button();
			this.container_tabs = new System.Windows.Forms.TabControl();
			this.tab_common = new System.Windows.Forms.TabPage();
			this.output_isBudged = new System.Windows.Forms.CheckBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.output_birthday = new System.Windows.Forms.TextBox();
			this.output_patronymic = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.output_name = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.output_faculty = new System.Windows.Forms.TextBox();
			this.output_group = new System.Windows.Forms.TextBox();
			this.output_lastname = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tab_private = new System.Windows.Forms.TabPage();
			this.output_passportNumber = new System.Windows.Forms.MaskedTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.output_passportSeria = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.output_TIN = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tab_contact = new System.Windows.Forms.TabPage();
			this.output_email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.output_phone = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.output_address = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.input_status = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.input_comment = new System.Windows.Forms.RichTextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.tab_status = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.Panel();
			this.keyboard1 = new UnivHostelKeyboardControl.Keyboard();
			this.container_tabs.SuspendLayout();
			this.tab_common.SuspendLayout();
			this.tab_private.SuspendLayout();
			this.tab_contact.SuspendLayout();
			this.tab_status.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(8, 581);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(982, 58);
			this.button1.TabIndex = 6;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button_sendRequest
			// 
			this.button_sendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_sendRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_sendRequest.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_sendRequest.Location = new System.Drawing.Point(8, 517);
			this.button_sendRequest.Name = "button_sendRequest";
			this.button_sendRequest.Size = new System.Drawing.Size(982, 58);
			this.button_sendRequest.TabIndex = 5;
			this.button_sendRequest.Text = "Получить документ";
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
			this.container_tabs.Controls.Add(this.tab_status);
			this.container_tabs.Location = new System.Drawing.Point(-3, 6);
			this.container_tabs.Name = "container_tabs";
			this.container_tabs.SelectedIndex = 0;
			this.container_tabs.Size = new System.Drawing.Size(1013, 505);
			this.container_tabs.TabIndex = 4;
			// 
			// tab_common
			// 
			this.tab_common.Controls.Add(this.output_isBudged);
			this.tab_common.Controls.Add(this.label15);
			this.tab_common.Controls.Add(this.label12);
			this.tab_common.Controls.Add(this.label11);
			this.tab_common.Controls.Add(this.label10);
			this.tab_common.Controls.Add(this.output_birthday);
			this.tab_common.Controls.Add(this.output_patronymic);
			this.tab_common.Controls.Add(this.label7);
			this.tab_common.Controls.Add(this.output_name);
			this.tab_common.Controls.Add(this.label8);
			this.tab_common.Controls.Add(this.output_faculty);
			this.tab_common.Controls.Add(this.output_group);
			this.tab_common.Controls.Add(this.output_lastname);
			this.tab_common.Controls.Add(this.label9);
			this.tab_common.Location = new System.Drawing.Point(4, 22);
			this.tab_common.Name = "tab_common";
			this.tab_common.Padding = new System.Windows.Forms.Padding(3);
			this.tab_common.Size = new System.Drawing.Size(1005, 293);
			this.tab_common.TabIndex = 0;
			this.tab_common.Text = "Общее";
			this.tab_common.UseVisualStyleBackColor = true;
			// 
			// output_isBudged
			// 
			this.output_isBudged.AutoSize = true;
			this.output_isBudged.Enabled = false;
			this.output_isBudged.Location = new System.Drawing.Point(212, 230);
			this.output_isBudged.Name = "output_isBudged";
			this.output_isBudged.Size = new System.Drawing.Size(15, 14);
			this.output_isBudged.TabIndex = 29;
			this.output_isBudged.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(28, 230);
			this.label15.MinimumSize = new System.Drawing.Size(139, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(139, 13);
			this.label15.TabIndex = 28;
			this.label15.Text = "Бюджетное обучение";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(28, 198);
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
			// output_birthday
			// 
			this.output_birthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_birthday.Location = new System.Drawing.Point(212, 195);
			this.output_birthday.Name = "output_birthday";
			this.output_birthday.ReadOnly = true;
			this.output_birthday.Size = new System.Drawing.Size(715, 20);
			this.output_birthday.TabIndex = 17;
			// 
			// output_patronymic
			// 
			this.output_patronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_patronymic.Location = new System.Drawing.Point(212, 158);
			this.output_patronymic.Name = "output_patronymic";
			this.output_patronymic.ReadOnly = true;
			this.output_patronymic.Size = new System.Drawing.Size(715, 20);
			this.output_patronymic.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(28, 161);
			this.label7.MinimumSize = new System.Drawing.Size(139, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Отчество";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// output_name
			// 
			this.output_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_name.Location = new System.Drawing.Point(212, 123);
			this.output_name.Name = "output_name";
			this.output_name.ReadOnly = true;
			this.output_name.Size = new System.Drawing.Size(715, 20);
			this.output_name.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(28, 126);
			this.label8.MinimumSize = new System.Drawing.Size(139, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Имя";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// output_faculty
			// 
			this.output_faculty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_faculty.Location = new System.Drawing.Point(212, 21);
			this.output_faculty.Name = "output_faculty";
			this.output_faculty.ReadOnly = true;
			this.output_faculty.Size = new System.Drawing.Size(715, 20);
			this.output_faculty.TabIndex = 13;
			// 
			// output_group
			// 
			this.output_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_group.Location = new System.Drawing.Point(212, 55);
			this.output_group.Name = "output_group";
			this.output_group.ReadOnly = true;
			this.output_group.Size = new System.Drawing.Size(715, 20);
			this.output_group.TabIndex = 13;
			// 
			// output_lastname
			// 
			this.output_lastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_lastname.Location = new System.Drawing.Point(212, 88);
			this.output_lastname.Name = "output_lastname";
			this.output_lastname.ReadOnly = true;
			this.output_lastname.Size = new System.Drawing.Size(715, 20);
			this.output_lastname.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(28, 91);
			this.label9.MinimumSize = new System.Drawing.Size(139, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(139, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Фамилия";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tab_private
			// 
			this.tab_private.Controls.Add(this.output_passportNumber);
			this.tab_private.Controls.Add(this.label13);
			this.tab_private.Controls.Add(this.output_passportSeria);
			this.tab_private.Controls.Add(this.label4);
			this.tab_private.Controls.Add(this.output_TIN);
			this.tab_private.Controls.Add(this.label5);
			this.tab_private.Location = new System.Drawing.Point(4, 22);
			this.tab_private.Name = "tab_private";
			this.tab_private.Padding = new System.Windows.Forms.Padding(3);
			this.tab_private.Size = new System.Drawing.Size(1005, 293);
			this.tab_private.TabIndex = 1;
			this.tab_private.Text = "Личные данные";
			this.tab_private.UseVisualStyleBackColor = true;
			// 
			// output_passportNumber
			// 
			this.output_passportNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_passportNumber.Location = new System.Drawing.Point(212, 88);
			this.output_passportNumber.Mask = "999999";
			this.output_passportNumber.Name = "output_passportNumber";
			this.output_passportNumber.ReadOnly = true;
			this.output_passportNumber.Size = new System.Drawing.Size(715, 20);
			this.output_passportNumber.TabIndex = 13;
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
			// output_passportSeria
			// 
			this.output_passportSeria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_passportSeria.Location = new System.Drawing.Point(212, 53);
			this.output_passportSeria.Mask = "9999";
			this.output_passportSeria.Name = "output_passportSeria";
			this.output_passportSeria.ReadOnly = true;
			this.output_passportSeria.Size = new System.Drawing.Size(715, 20);
			this.output_passportSeria.TabIndex = 11;
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
			// output_TIN
			// 
			this.output_TIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_TIN.Location = new System.Drawing.Point(212, 18);
			this.output_TIN.Mask = "999999999999";
			this.output_TIN.Name = "output_TIN";
			this.output_TIN.ReadOnly = true;
			this.output_TIN.Size = new System.Drawing.Size(715, 20);
			this.output_TIN.TabIndex = 9;
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
			this.tab_contact.Controls.Add(this.output_email);
			this.tab_contact.Controls.Add(this.label3);
			this.tab_contact.Controls.Add(this.output_phone);
			this.tab_contact.Controls.Add(this.label2);
			this.tab_contact.Controls.Add(this.output_address);
			this.tab_contact.Controls.Add(this.label1);
			this.tab_contact.Location = new System.Drawing.Point(4, 22);
			this.tab_contact.Name = "tab_contact";
			this.tab_contact.Padding = new System.Windows.Forms.Padding(3);
			this.tab_contact.Size = new System.Drawing.Size(1005, 479);
			this.tab_contact.TabIndex = 2;
			this.tab_contact.Text = "Контактные данные";
			this.tab_contact.UseVisualStyleBackColor = true;
			// 
			// output_email
			// 
			this.output_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_email.Location = new System.Drawing.Point(212, 88);
			this.output_email.Name = "output_email";
			this.output_email.ReadOnly = true;
			this.output_email.Size = new System.Drawing.Size(715, 20);
			this.output_email.TabIndex = 5;
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
			// output_phone
			// 
			this.output_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_phone.Location = new System.Drawing.Point(212, 53);
			this.output_phone.Mask = "+9 (999) 000-0000";
			this.output_phone.Name = "output_phone";
			this.output_phone.ReadOnly = true;
			this.output_phone.Size = new System.Drawing.Size(715, 20);
			this.output_phone.TabIndex = 3;
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
			// output_address
			// 
			this.output_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.output_address.Location = new System.Drawing.Point(212, 18);
			this.output_address.Name = "output_address";
			this.output_address.ReadOnly = true;
			this.output_address.Size = new System.Drawing.Size(715, 20);
			this.output_address.TabIndex = 1;
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
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(8, 404);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(982, 58);
			this.button2.TabIndex = 7;
			this.button2.Text = "Установить статус";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// input_status
			// 
			this.input_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_status.FormattingEnabled = true;
			this.input_status.Location = new System.Drawing.Point(193, 18);
			this.input_status.Name = "input_status";
			this.input_status.Size = new System.Drawing.Size(633, 21);
			this.input_status.TabIndex = 24;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 21);
			this.label6.MinimumSize = new System.Drawing.Size(139, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "Статус";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(9, 53);
			this.label14.MinimumSize = new System.Drawing.Size(139, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(139, 13);
			this.label14.TabIndex = 25;
			this.label14.Text = "Комментарий";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_comment
			// 
			this.input_comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_comment.Location = new System.Drawing.Point(193, 53);
			this.input_comment.Name = "input_comment";
			this.input_comment.Size = new System.Drawing.Size(633, 78);
			this.input_comment.TabIndex = 26;
			this.input_comment.Text = "";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(832, 15);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(138, 116);
			this.button3.TabIndex = 27;
			this.button3.Text = "Посмотреть историю изменения статуса";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tab_status
			// 
			this.tab_status.Controls.Add(this.keyboard1);
			this.tab_status.Controls.Add(this.groupBox1);
			this.tab_status.Controls.Add(this.button2);
			this.tab_status.Location = new System.Drawing.Point(4, 22);
			this.tab_status.Name = "tab_status";
			this.tab_status.Padding = new System.Windows.Forms.Padding(3);
			this.tab_status.Size = new System.Drawing.Size(1005, 479);
			this.tab_status.TabIndex = 3;
			this.tab_status.Text = "Статус";
			this.tab_status.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.input_comment);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.input_status);
			this.groupBox1.Location = new System.Drawing.Point(15, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(978, 144);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			// 
			// keyboard1
			// 
			this.keyboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.keyboard1.Location = new System.Drawing.Point(15, 155);
			this.keyboard1.Name = "keyboard1";
			this.keyboard1.Size = new System.Drawing.Size(970, 232);
			this.keyboard1.TabIndex = 29;
			// 
			// ViewStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 645);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_sendRequest);
			this.Controls.Add(this.container_tabs);
			this.Name = "ViewStudent";
			this.Text = "Просмотр информации о студенте";
			this.container_tabs.ResumeLayout(false);
			this.tab_common.ResumeLayout(false);
			this.tab_common.PerformLayout();
			this.tab_private.ResumeLayout(false);
			this.tab_private.PerformLayout();
			this.tab_contact.ResumeLayout(false);
			this.tab_contact.PerformLayout();
			this.tab_status.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button_sendRequest;
		private System.Windows.Forms.TabControl container_tabs;
		private System.Windows.Forms.TabPage tab_common;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox output_patronymic;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox output_name;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox output_lastname;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage tab_private;
		private System.Windows.Forms.MaskedTextBox output_passportNumber;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.MaskedTextBox output_passportSeria;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox output_TIN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabPage tab_contact;
		private System.Windows.Forms.TextBox output_email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox output_phone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox output_address;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox input_status;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox output_birthday;
		private System.Windows.Forms.TextBox output_faculty;
		private System.Windows.Forms.TextBox output_group;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RichTextBox input_comment;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox output_isBudged;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TabPage tab_status;
		private UnivHostelKeyboardControl.Keyboard keyboard1;
		private System.Windows.Forms.Panel groupBox1;
	}
}