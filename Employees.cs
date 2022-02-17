using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    class Employees
    {
		public string Name { get; set; }
		public int Hours { get; set; }
		public double ValuePerHours { get; set; }

		public Employees(string name, int hours, double valuePerHours)
		{
			Name = name;
			Hours = hours;
			ValuePerHours = valuePerHours;
		}

		public virtual double PayMent()
		{ return Hours * ValuePerHours; }
	}
}
}
