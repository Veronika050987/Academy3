using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy3
{
    class Program
    {
		static readonly string delimiter = "\n----------------------------------------------\n";
		static void Main(string[] args)
		{
			Human3 human = new Human3("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);

			Student3 student = new Student3("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Info();
			Console.WriteLine(delimiter);

			Human3 tommy = new Human3("Vercetty", "Tommy", 30);
			tommy.Info();
			Console.WriteLine(delimiter);

			Student3 s_tommy = new Student3(tommy, "Theft", "Vice", 95, 98);
			s_tommy.Info();
			Console.WriteLine(delimiter);

			Graduate3 graduate = new Graduate3("Walter", "Mike", 34, "Chemistry", "JJ45", 89, 95, "Electrons in our life", "M. Smith");
			graduate.Info();
			Console.WriteLine(delimiter);

			Specialist2 specialist = new Specialist2("Solter", "Masha", 34, "Chemistry", "JJ45", 89, 95, "Stellantis");
			specialist.Info();
		}
	}
}
