using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univ_hostel.Forms.Student
{
	public partial class MainMenu : BaseForm
	{
		public MainMenu(BaseForm parentForm) : base(parentForm)
		{
			InitializeComponent();  Init(parentForm);
		}

		private void button_find_Click(object sender, EventArgs e)
		{
			new FindInfo(this).Show();
			CorrectClose();
		}

		private void button_send_Click(object sender, EventArgs e)
		{
			new AddRequest(this).Show();
			CorrectClose();
		}

		private void button1_Click(object sender, EventArgs e) => ToHome();
	}
}
