using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy3
{
	class Student3 : Human3
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }
		public Student3
			(
			string last_name, string first_name, int age,
			string speciality, string group, double rating, double attendance
			) : base(last_name, first_name, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"SConstructor\t:{this.GetHashCode()}");
		}
		public Student3(Human3 human, string speciality, string group, double rating, double attendance) : base(human)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"SConstructor\t:{this.GetHashCode()}");
		}
		~Student3()
		{
			Console.WriteLine($"SDestructor\t:{this.GetHashCode()}");
		}
		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
		}
	}
}
