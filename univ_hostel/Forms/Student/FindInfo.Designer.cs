namespace univ_hostel.Forms.Student
{
	partial class FindInfo
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
			this.button_sendRequest = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(24, 18);
			this.label11.MinimumSize = new System.Drawing.Size(139, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(139, 13);
			this.label11.TabIndex = 32;
			this.label11.Text = "Факультет";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_faculty
			// 
			this.input_faculty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_faculty.FormattingEnabled = true;
			this.input_faculty.Location = new System.Drawing.Point(208, 15);
			this.input_faculty.Name = "input_faculty";
			this.input_faculty.Size = new System.Drawing.Size(509, 21);
			this.input_faculty.TabIndex = 31;
			this.input_faculty.SelectedIndexChanged += new System.EventHandler(this.input_faculty_SelectedValueChanged);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(24, 53);
			this.label10.MinimumSize = new System.Drawing.Size(139, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(139, 13);
			this.label10.TabIndex = 30;
			this.label10.Text = "Группа";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_group
			// 
			this.input_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_group.FormattingEnabled = true;
			this.input_group.Location = new System.Drawing.Point(208, 50);
			this.input_group.Name = "input_group";
			this.input_group.Size = new System.Drawing.Size(509, 21);
			this.input_group.TabIndex = 29;
			// 
			// input_patronymic
			// 
			this.input_patronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_patronymic.Location = new System.Drawing.Point(208, 155);
			this.input_patronymic.Name = "input_patronymic";
			this.input_patronymic.Size = new System.Drawing.Size(509, 20);
			this.input_patronymic.TabIndex = 28;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 158);
			this.label7.MinimumSize = new System.Drawing.Size(139, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 13);
			this.label7.TabIndex = 27;
			this.label7.Text = "Отчество";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_name
			// 
			this.input_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_name.Location = new System.Drawing.Point(208, 120);
			this.input_name.Name = "input_name";
			this.input_name.Size = new System.Drawing.Size(509, 20);
			this.input_name.TabIndex = 26;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(24, 123);
			this.label8.MinimumSize = new System.Drawing.Size(139, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Имя";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_lastname
			// 
			this.input_lastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input_lastname.Location = new System.Drawing.Point(208, 85);
			this.input_lastname.Name = "input_lastname";
			this.input_lastname.Size = new System.Drawing.Size(509, 20);
			this.input_lastname.TabIndex = 24;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(24, 88);
			this.label9.MinimumSize = new System.Drawing.Size(139, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(139, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Фамилия";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button_sendRequest
			// 
			this.button_sendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_sendRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_sendRequest.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_sendRequest.Location = new System.Drawing.Point(12, 289);
			this.button_sendRequest.Name = "button_sendRequest";
			this.button_sendRequest.Size = new System.Drawing.Size(776, 58);
			this.button_sendRequest.TabIndex = 22;
			this.button_sendRequest.Text = "Найти информацию";
			this.button_sendRequest.UseVisualStyleBackColor = true;
			this.button_sendRequest.Click += new System.EventHandler(this.button_sendRequest_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 369);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(776, 58);
			this.button1.TabIndex = 33;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FindInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.input_faculty);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.input_group);
			this.Controls.Add(this.input_patronymic);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.input_name);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.input_lastname);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.button_sendRequest);
			this.Name = "FindInfo";
			this.Text = "Поиск информации о студенте";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.Button button_sendRequest;
		private System.Windows.Forms.Button button1;
	}
}