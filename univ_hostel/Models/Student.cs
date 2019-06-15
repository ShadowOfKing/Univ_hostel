using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univ_hostel.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Patronymic { get; set; }
		public DateTime Birthday {get;set;}
		public string Address {get;set;}
		public string Email { get; set; }
		public string TIN {get;set;}
		public string PassportSeria {get;set; }
		public string PassportNumber { get; set; }
		public string PhoneNumber { get; set; }
		public Group Group { get; set; }
		public int GroupId { get; set; }
	}
}
