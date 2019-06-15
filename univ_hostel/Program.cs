using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using univ_hostel.Models;
using univ_hostel.Forms;

namespace univ_hostel
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			using (var db = new DefaultDbContext())
			{
				db.Database.CreateIfNotExists();
			}
			Application.Run(new Base());
		}
	}
}
