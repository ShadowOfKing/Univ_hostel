using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univ_hostel.Models
{
	public class Inhabitancy
	{
		public int Id { get; set; }
		public int Room { get; set; }
		public DateTime Begin { get; set; }
		public DateTime? End { get; set; }
		public Student Student { get; set; }
	}
}
