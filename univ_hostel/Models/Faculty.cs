﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univ_hostel.Models
{
	public class Faculty
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Speciality> Specialities { get; set; }
	}
}
