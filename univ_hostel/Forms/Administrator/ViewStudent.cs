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
using Word = Microsoft.Office.Interop.Word;

namespace univ_hostel.Forms.Administrator
{
	public partial class ViewStudent : BaseForm
	{
		private readonly Models.Student _student;
        private readonly string templatefilename = @"C:\Users\ISKANDER\Desktop\lab\univ_hostel\D nayma zhilogo pom.docx";
        private readonly string templatefilename1 = @"C:\Users\ISKANDER\Desktop\lab\univ_hostel\D o vozmeshtenie zatrat za kom uslugi.docx";
        public ViewStudent(BaseForm parentForm, int studentId) : base(parentForm)
		{
			InitializeComponent();
			Init(parentForm);
			input_status.DataSource = Enum.GetValues(typeof(RequestStatus)).Cast<RequestStatus>().Select(s => RequestHelper.GetStatusName(s)).ToList();
			using (var db = new DefaultDbContext()) {
				var student = db.Students.Where(s => s.Id == studentId).Single();
				var group = db.Groups.Where(g => g.Id == student.GroupId).Include(g => g.Speciality).Include(g => g.Speciality.Faculty).Single();
				Text = $"Информация о студенте {student.Lastname} {student.Name} {student.Patronymic}, группа {group.Name}";
				output_faculty.Text = group.Speciality.Faculty.Name;
				output_group.Text = group.Name;
				output_name.Text = student.Name;
				output_lastname.Text = student.Lastname;
				output_patronymic.Text = student.Patronymic;
				output_birthday.Text= student.Birthday.ToString("dd.MM.yyyy");
				output_passportNumber.Text = student.PassportNumber;
				output_passportSeria.Text = student.PassportSeria;
				output_TIN.Text = student.TIN;
				output_address.Text = student.Address;
				output_email.Text = student.Email;
				output_phone.Text = student.PhoneNumber;
				output_isBudged.Checked = student.IsBudget;
				var request = db.RequestStatuses.Where(r => r.StudentId == studentId).OrderByDescending(r => r.Date).FirstOrDefault();
				if (request != null) {
					input_comment.Text = request.Comment;
					input_status.SelectedItem =RequestHelper.GetStatusName(request.Status);
				}
				_student = student;
			}
		}

		private void button_sendRequest_Click(object sender, EventArgs e)
		{
            send_doc();
		}

		private void button1_Click(object sender, EventArgs e) => ToHome();

		private void button2_Click(object sender, EventArgs e)
		{
			var request = new RequestResult
			{
				Comment = input_comment.Text,
				Status = RequestHelper.GetStatus((string)input_status.SelectedValue),
				Date = DateTime.Now,
				StudentId = _student.Id
			};
			using (var db = new DefaultDbContext()) {
				db.RequestStatuses.Add(request);
				db.SaveChanges();
			}
			MessageBox.Show("Статус успешно установлен!");
			new RequestsList(this).Show();
			CorrectClose();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			new RequestResultHistory(this, _student.Id).ShowDialog();

		}
        private void send_doc()
        {

            var Lastname = output_lastname.Text;
            var Patronymic = output_patronymic.Text;
            var name = output_name.Text;
            var inn = output_TIN.Text;
            var PassportNumber = output_passportNumber.Text;
            var PassportSeria = output_passportSeria.Text;
            var Address = output_address.Text;


            var wordAPP = new Word.Application();
            wordAPP.Visible = false;
            try
            {
                var wordDocument = wordAPP.Documents.Open(templatefilename);
                ReplaceWordStup("{lastname}", Lastname, wordDocument);
                ReplaceWordStup("{name}", name, wordDocument);
                ReplaceWordStup("{Patronymic}", Patronymic, wordDocument);
                ReplaceWordStup("{PassportNumber}", PassportNumber, wordDocument);
                ReplaceWordStup("{PassportSeria}", PassportSeria, wordDocument);
                ReplaceWordStup("{Address}", Address, wordDocument);
                ReplaceWordStup("{inn}", inn, wordDocument);
                ReplaceWordStup("{lastname}", Lastname, wordDocument);
                ReplaceWordStup("{name}", name, wordDocument);
                ReplaceWordStup("{Patronymic}", Patronymic, wordDocument);

                wordDocument.SaveAs(@"D:\отчеты\D_nayma_zhilogo_pom.docx");
                //wordAPP.Documents.Close();

                var wordDocument1 = wordAPP.Documents.Open(templatefilename1);
                ReplaceWordStup("{lastname}", Lastname, wordDocument1);
                ReplaceWordStup("{name}", name, wordDocument1);
                ReplaceWordStup("{Patronymic}", Patronymic, wordDocument1);
                ReplaceWordStup("{PassportNumber}", PassportNumber, wordDocument1);
                ReplaceWordStup("{PassportSeria}", PassportSeria, wordDocument1);
                ReplaceWordStup("{Address}", Address, wordDocument1);
                ReplaceWordStup("{inn}", inn, wordDocument1);
                ReplaceWordStup("{lastname}", Lastname, wordDocument1);
                ReplaceWordStup("{name}", name, wordDocument1);
                ReplaceWordStup("{Patronymic}", Patronymic, wordDocument1);

                wordDocument1.SaveAs(@"D:\отчеты\D_o_vozmeshtenie_zatrat_za_kom_uslugi.docx");
                wordDocument.Close();
                wordDocument1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("end");
            }
            MessageBox.Show("Документ сформирован");

        }

        private void ReplaceWordStup(string stubToReplace, string text, Word.Document worddocument)
        {

            var range = worddocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
