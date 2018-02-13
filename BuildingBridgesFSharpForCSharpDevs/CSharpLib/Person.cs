using System;

namespace CSharpLib
{
	public class Person
	{
		public Person(string name, DateTime birthday)
		{
			Name = name;
			Birthday = birthday;
		}

		public string Name { get; }
		public DateTime Birthday { get; }

		public int Age() =>
			DateTime.Today.Subtract(Birthday).Days / 365;
	}
}
