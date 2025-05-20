using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy3
{
    class Specialist2 : Student3
	{
		public string Company { get; set; }

		public Specialist2
			(
			string last_name, string first_name, int age,
			string speciality, string group, double rating, double attendance,
			string company) : base
			(
				last_name, first_name, age, speciality, group, rating, attendance
			)
		{
			Company = company;
			Console.WriteLine($"SConstructor\t:{this.GetHashCode()}");
		}

		~Specialist2()
		{
			Console.WriteLine($"SDestructor\t:{this.GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Company} ");
		}
	}
}