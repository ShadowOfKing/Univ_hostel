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
using univ_hostel.Models.RequestWork;

namespace univ_hostel.Forms.Student
{
	public partial class AddRequest : BaseForm
	{
		private readonly int? studentId;
		public AddRequest(BaseForm parentForm, Models.Student student = null) : base(parentForm)
		{

			InitializeComponent();  Init(parentForm);
			using (var db = new DefaultDbContext())
			{
				input_faculty.DataSource = db.Faculties.ToList();
				input_faculty.DisplayMember = "Name";
			}
			studentId = student?.Id;
			if (studentId.HasValue)
			{
				using (var db = new DefaultDbContext())
				{
					var group = db.Groups.Where(g => g.Id == student.GroupId).Include(g => g.Speciality).Include(g => g.Speciality.Faculty).Single();
					input_faculty.SelectedItem = group.Speciality.Faculty;
					input_group.SelectedItem = group;
				}
				input_name.Text = student.Name;
				input_lastname.Text = student.Lastname;
				input_patronymic.Text = student.Patronymic;
				input_birthday.Value = student.Birthday;
				input_passportNumber.Text = student.PassportNumber;
				input_passportSeria.Text = student.PassportSeria;
				input_TIN.Text = student.TIN;
				input_address.Text = student.Address;
				input_email.Text = student.Email;
				input_phone.Text = student.PhoneNumber;
				input_isBudged.Checked = student.IsBudget;
			}
			keyboard.AddControl(input_name);
			keyboard.AddControl(input_lastname);
			keyboard.AddControl(input_patronymic);
			keyboard.AddControl(input_passportNumber);
			keyboard.AddControl(input_passportSeria);
			keyboard.AddControl(input_address);
			keyboard.AddControl(input_email);
			keyboard.AddControl(input_phone);
		}

		private void button_sendRequest_Click(object sender, EventArgs e)
		{
			try
			{
				var student = new Models.Student()
				{
					Address = input_address.Text,
					Birthday = input_birthday.Value,
					Email = input_email.Text,
					Lastname = input_lastname.Text,
					Name = input_name.Text,
					PassportNumber = input_passportNumber.Text,
					PassportSeria = input_passportSeria.Text,
					Patronymic = input_patronymic.Text,
					PhoneNumber = input_phone.Text,
					TIN = input_TIN.Text,
					IsBudget = input_isBudged.Checked
				};
				using (var db = new DefaultDbContext())
				{
					student.GroupId = ((Group)input_group.SelectedValue).Id;
					if (!studentId.HasValue)
					{
						var found = db.Students.Where(s =>
						s.GroupId == student.GroupId
						&& s.Name == student.Name
						&& s.Lastname == student.Lastname
						&& s.Patronymic == student.Patronymic
					).SingleOrDefault();
						if (found != null)
						{
							var result = MessageBox.Show("Студент с данными Ф.И.О. в данной группе уже существует. Хотите посмотреть информацию о нём?", "Ошибка. Студент уже существует.", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
							if (result == DialogResult.Yes)
							{
								new ShowInfo(this, found).Show();
								CorrectClose();
							}
							return;
						}
						else
						{
							db.Students.Add(student);
						}
					}
					else
					{
						student.Id = studentId.Value;
						db.Entry(student).State = EntityState.Modified;
						var request = new RequestResult
						{
							Date = DateTime.Now,
							Status = RequestStatus.InWork,
							StudentId = student.Id,
							Comment = $"Студент обновил данные"
						};
						db.RequestStatuses.Add(request);
					}
					db.SaveChanges();
				}
			} catch (Exception ex)
			{
				MessageBox.Show("При отправке заявки произошла ошибка. \n" + ex.Message);
			}
			MessageBox.Show("Заявка успешно отправлена");
			new Home(this).Show();
			CorrectClose();
		}

		private void input_faculty_SelectedValueChanged(object sender, EventArgs e)
		{
			using (var db = new DefaultDbContext())
			{
				var id = ((Faculty)input_faculty.SelectedValue)?.Id;
				input_group.DataSource = db.Groups
					.Include(g => g.Speciality)
					.Include(g => g.Speciality.Faculty)
					.Where(g => g.Speciality.Faculty.Id == id)
					.ToList();
				input_group.DisplayMember = "Name";
			}
		}

		private void button1_Click(object sender, EventArgs e) => ToHome();
	}
}
