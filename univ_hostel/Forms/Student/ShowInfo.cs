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

namespace univ_hostel.Forms.Student
{
	public partial class ShowInfo : BaseForm
	{
		private readonly Models.Student _student;
		public ShowInfo(BaseForm parentForm, Models.Student student) : base(parentForm)
		{
			InitializeComponent();  Init(parentForm);
			_student = student;
			using (var db = new DefaultDbContext())
			{

				var group = db.Groups.Where(g => g.Id == student.GroupId).Include(g => g.Speciality).Include(g => g.Speciality.Faculty).Single();
				Text = $"Информация о студенте {student.Lastname} {student.Name} {student.Patronymic}, группа {group.Name}";
				output_faculty.Text = group.Speciality.Faculty.Name;
				output_group.Text = group.Name;
				var requestResult = db.RequestStatuses.Where(r => r.StudentId == student.Id).OrderByDescending(r => r.Date).FirstOrDefault();
				output_status.Text = RequestHelper.GetStatusName(requestResult?.Status);
				output_comment.Text = requestResult?.Comment;
				if (requestResult?.Status != RequestStatus.Reject)
				{
					button_resend.Enabled = false;
					button_resend.BackColor = Color.LightGray;
				}
			}
			output_name.Text = student.Name;
			output_lastname.Text = student.Lastname;
			output_patronymic.Text = student.Patronymic;
		}

		private void button_sendRequest_Click(object sender, EventArgs e) => ToHome();

		private void button_resend_Click(object sender, EventArgs e)
		{
			if (button_resend.Enabled)
			{
				new AddRequest(this, _student).Show();
				CorrectClose();
			}
		}
	}
}
