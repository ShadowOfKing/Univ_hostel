using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student = univ_hostel.Forms.Student;
using Administrator = univ_hostel.Forms.Administrator;

namespace univ_hostel.Forms
{
	public partial class Home : BaseForm
	{
		public Home(BaseForm parentForm) : base(parentForm)
		{
			InitializeComponent();
			Init(parentForm);
		}

		public Home(Form baseForm) : base(baseForm)
		{
			InitializeComponent();
			CenterToScreen();
		}

		private void button_admin_Click(object sender, EventArgs e)
		{
			new Administrator.MainMenu(this).Show();
			CorrectClose();
		}

		private void button_student_Click(object sender, EventArgs e)
		{
			new Student.MainMenu(this).Show();
			CorrectClose();
		}
	}
}
