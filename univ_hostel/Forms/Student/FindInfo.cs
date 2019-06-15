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

namespace univ_hostel.Forms.Student
{
	public partial class FindInfo : BaseForm
	{
		public FindInfo(BaseForm parentForm) : base(parentForm)
		{
			InitializeComponent();  Init(parentForm);
			using (var db = new DefaultDbContext())
			{
				input_faculty.DataSource = db.Faculties.ToList();
				input_faculty.DisplayMember = "Name";
			}
			keyboard1.AddControl(input_lastname);
			keyboard1.AddControl(input_name);
			keyboard1.AddControl(input_patronymic);
		}


		private void input_faculty_SelectedValueChanged(object sender, EventArgs e)
		{
			using (var db = new DefaultDbContext())
			{
				input_group.DataSource = db.Groups
					.Include(g => g.Speciality)
					.Include(g => g.Speciality.Faculty)
					.Where(g => g.Speciality.Faculty.Id == ((Faculty)input_faculty.SelectedValue).Id)
					.ToList();
				input_group.DisplayMember = "Name";
			}
		}

		private void button_sendRequest_Click(object sender, EventArgs e)
		{
			var student = new Models.Student
			{
				Name = input_name.Text,
				Lastname = input_lastname.Text,
				Patronymic = input_patronymic.Text,
				GroupId = ((Group)input_group.SelectedValue).Id
			};
			using (var db = new DefaultDbContext())
			{
				var found = db.Students.Where(s =>
					s.GroupId == student.GroupId
					&& s.Name == student.Name
					&& s.Lastname == student.Lastname
					&& s.Patronymic == student.Patronymic
				).SingleOrDefault();
				if (found == null)
				{
					MessageBox.Show("Информация о студенте с такими данными не найдена");
				}
				else
				{
					new ShowInfo(this, found).Show();
					CorrectClose();
				}
			};
		}

		private void button1_Click(object sender, EventArgs e) => ToHome();
	}
}
