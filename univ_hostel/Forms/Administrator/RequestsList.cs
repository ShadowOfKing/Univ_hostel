using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univ_hostel.Helpers;
using univ_hostel.Models;
using univ_hostel.Models.RequestWork;

namespace univ_hostel.Forms.Administrator
{
	public partial class RequestsList : BaseForm
	{
		public RequestsList(BaseForm parentForm) : base(parentForm)
		{
			InitializeComponent();
			Init(parentForm);
			using (var db = new DefaultDbContext())
			{
				var requests = db.Students
					.Include(s => s.Group)
					.Include(s => s.Group.Speciality)
					.Include(s => s.Group.Speciality.Faculty)
					.Select(s => new
					{
						s.Id,
						Faculty = s.Group.Speciality.Faculty.Name,
						Group = s.Group.Name,
						s.IsBudget,
						s.Name,
						s.Lastname,
						s.Patronymic,
						s.PhoneNumber,
						s.TIN,
						s.PassportSeria,
						s.PassportNumber,
						s.Address,
						s.Birthday,
						StatusId = (db.RequestStatuses.Where(r => r.Student.Id == s.Id).OrderByDescending(r => r.Date).Select(r => new { r.Status }).FirstOrDefault() ?? new { Status = RequestStatus.InWork }).Status
					}).ToList()
					.Select(s => new
					{
						s.Id,
						s.Faculty,
						s.Group,
						s.IsBudget,
						s.Name,
						s.Lastname,
						s.Patronymic,
						s.PhoneNumber,
						s.TIN,
						s.PassportSeria,
						s.PassportNumber,
						s.Address,
						s.Birthday,
						Status = RequestHelper.GetStatusName(s.StatusId)
					});
				bid_students.DataSource = requests.ToList();
				bid_students.Columns["Id"].Visible = false;
			}
		}

		private void button1_Click(object sender, EventArgs e) => ToHome();

		private void button2_Click(object sender, EventArgs e)
		{
			var row = bid_students.SelectedRows[0];
			var id = (int)row.Cells["Id"].Value;
			new ViewStudent(this, id).Show();
			CorrectClose();
		}
	}
}
