namespace univ_hostel.Forms.Administrator
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
			this.button_openList = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_openList
			// 
			this.button_openList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_openList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_openList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_openList.Location = new System.Drawing.Point(12, 153);
			this.button_openList.Name = "button_openList";
			this.button_openList.Size = new System.Drawing.Size(982, 58);
			this.button_openList.TabIndex = 1;
			this.button_openList.Text = "Открыть список заявок";
			this.button_openList.UseVisualStyleBackColor = true;
			this.button_openList.Click += new System.EventHandler(this.button_openList_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 249);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(982, 58);
			this.button1.TabIndex = 2;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 645);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_openList);
			this.Name = "MainMenu";
			this.Text = "Панель администратора";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_openList;
		private System.Windows.Forms.Button button1;
	}
}