using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy3
{
    class Graduate3 : Student3
    {
		public string ThesisTopic { get; set; }
		public string Supervisor { get; set; }

		public Graduate3
			(
			string last_name, string first_name, int age,
			string speciality, string group, double rating, double attendance, 
			string thesisTopic, string supervisor) : base
			(
				last_name, first_name, age, speciality, group, rating, attendance
			)
		{
			ThesisTopic = thesisTopic;
			Supervisor = supervisor;
			Console.WriteLine($"SConstructor\t:{this.GetHashCode()}");
		}

		~Graduate3()
		{
			Console.WriteLine($"SDestructor\t:{this.GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{ThesisTopic} {Supervisor} ");
		}
	}
}
