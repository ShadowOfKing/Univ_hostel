using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univ_hostel.Models.RequestWork
{
	public enum RequestStatus
	{
		InWork,
		Succeed,
		Reject
	}

	public class RequestResult
	{
		public int Id { get; set; }
		public string Comment { get; set; }
		public RequestStatus Status { get; set; }
		public DateTime Date { get; set; }
		public int StudentId { get; set; }
		public Student Student { get; set; }
	}
}
