using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using univ_hostel.Models;
using univ_hostel.Forms;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Design;

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
				db.Database.Initialize(false);
			}
			Application.Run(new Base());
		}
	}
}
