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
using univ_hostel.Models;
using univ_hostel.Helpers;

namespace univ_hostel.Forms.Administrator
{
	public partial class RequestResultHistory : BaseForm
	{
		public RequestResultHistory(BaseForm parentForm, int studentId) : base(parentForm)
		{
			InitializeComponent();
			Init(parentForm);
			using (var db = new DefaultDbContext())
			{
				var student = db.Students.Where(s => s.Id == studentId).Include(s => s.Group).Single();
				Text = $"История изменения статусов студента {student.Lastname} {student.Name} {student.Patronymic}, группа {student.Group.Name}";
				var logs = db.RequestStatuses.Where(r => r.StudentId == studentId)
					.OrderBy(r => r.Date)
					.ToList()
					.Select(r => new { 
						r.Comment,
						Date = r.Date.ToString("dd.MM.yyyy mm:hh:ss"), 
						Status = RequestHelper.GetStatusName(s.Status) 
					})
					.ToList();
				bi_logs.DataSource = logs;
				bi_logs.Columns["Date"].Name = "Дата";
				bi_logs.Columns["Comment"].Name = "Комментарий";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CorrectClose();
		}
	}
}
