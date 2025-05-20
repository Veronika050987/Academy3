using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy3
{
    class Human3
    {
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
		public Human3(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstructor:\t{this.GetHashCode()}");
			//snake_case_style - змеиный_стиль_именования_переменных
			//PascalCaseStyle
			//CamelCaseStyle
			//BigCamel
			//smallCamelCaseStyle
		}
		public Human3(Human3 other)
		{
			this.LastName = other.LastName;
			this.FirstName = other.FirstName;
			this.Age = other.Age;

			Console.WriteLine($"HCopyConstructor:\t{this.GetHashCode()}");
		}
		~Human3()
		{
			Console.WriteLine($"HDestructor:\t{this.GetHashCode()}");
		}
		public void Info()
		{
			Console.WriteLine($"{LastName} {FirstName} {Age}");
		}
	}
}