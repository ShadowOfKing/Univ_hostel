namespace univ_hostel.Forms.Student
{
	partial class MainMenu
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
			this.button_send = new System.Windows.Forms.Button();
			this.button_find = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(982, 58);
			this.button1.TabIndex = 2;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button_send
			// 
			this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_send.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_send.Location = new System.Drawing.Point(12, 198);
			this.button_send.Name = "button_send";
			this.button_send.Size = new System.Drawing.Size(982, 58);
			this.button_send.TabIndex = 1;
			this.button_send.Text = "Отправить заявку";
			this.button_send.UseVisualStyleBackColor = true;
			this.button_send.Click += new System.EventHandler(this.button_send_Click);
			// 
			// button_find
			// 
			this.button_find.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_find.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_find.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_find.Location = new System.Drawing.Point(12, 101);
			this.button_find.Name = "button_find";
			this.button_find.Size = new System.Drawing.Size(982, 58);
			this.button_find.TabIndex = 0;
			this.button_find.Text = "Найти информацию";
			this.button_find.UseVisualStyleBackColor = true;
			this.button_find.Click += new System.EventHandler(this.button_find_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 645);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_send);
			this.Controls.Add(this.button_find);
			this.Name = "MainMenu";
			this.Text = "Панель студента";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button_send;
		private System.Windows.Forms.Button button_find;
		private System.Windows.Forms.Button button1;
	}
}