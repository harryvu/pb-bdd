﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDomain
{
	public class Department
	{
		public int Id { get; set; }
		public string DepartmentName { get; set; }
		public List<Employee> Employees { get; set; }
	}
}
