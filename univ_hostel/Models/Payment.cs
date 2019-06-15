using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univ_hostel.Models
{
	public class Payment
	{
		public int Id { get; set; }
		public int Cost { get; set; }
		public DateTime Date { get; set; }
		public Student Student { get; set; }
	}
}
