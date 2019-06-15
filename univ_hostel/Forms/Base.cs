using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univ_hostel.Forms
{
	public partial class Base : Form
	{
		public Base()
		{
			InitializeComponent(); 
			Hide();
			new Home(this).Show();
			new Thread(() =>
			{
				Thread.Sleep(500);
				Invoke(new MethodInvoker(delegate
				{
					Hide();
				}));
			}).Start();
			Opacity = 0;
		}
	}
}
