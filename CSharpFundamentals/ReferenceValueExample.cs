using System;
namespace CSharpFundamentals
{
	public class Persona
	{
		public int Age;
	}
	public class ReferenceValueExample
	{
		public static void ReferenceValueExampleMethod()
		{
			var number = 1;
			Console.WriteLine(number);

			var person = new Persona() { Age = 20 };
			MakeOld(person);
			Console.WriteLine(person.Age);
		}
		public static void Increment(int number)
		{
			number += 10;
		}
		public static void MakeOld(Persona person)
		{
			person.Age += 10;

		}
	}
}

