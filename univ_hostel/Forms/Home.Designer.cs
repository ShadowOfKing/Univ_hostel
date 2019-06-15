namespace univ_hostel.Forms
{
	partial class Home
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
			this.button_admin = new System.Windows.Forms.Button();
			this.button_student = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_admin
			// 
			this.button_admin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_admin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_admin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_admin.Location = new System.Drawing.Point(12, 71);
			this.button_admin.Name = "button_admin";
			this.button_admin.Size = new System.Drawing.Size(776, 84);
			this.button_admin.TabIndex = 0;
			this.button_admin.Text = "Администратор";
			this.button_admin.UseVisualStyleBackColor = true;
			this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
			// 
			// button_student
			// 
			this.button_student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_student.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_student.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_student.Location = new System.Drawing.Point(12, 232);
			this.button_student.Name = "button_student";
			this.button_student.Size = new System.Drawing.Size(776, 84);
			this.button_student.TabIndex = 1;
			this.button_student.Text = "Студент";
			this.button_student.UseVisualStyleBackColor = true;
			this.button_student.Click += new System.EventHandler(this.button_student_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 611);
			this.Controls.Add(this.button_student);
			this.Controls.Add(this.button_admin);
			this.Name = "Home";
			this.Text = "Управление общежитием";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_admin;
		private System.Windows.Forms.Button button_student;
	}
}

