using System;
namespace String1
{
	public class String_unit
	{
		public static void Method()
		{
			var fullName = "Guillermo Larranaga ";
			Console.WriteLine("Trim: '{0}'", fullName.Trim());
			Console.WriteLine("toUpper: '{0}'", fullName.Trim().ToUpper());
			Console.WriteLine("toLower: '{0}'", fullName.Trim().ToLower());

			var index = fullName.IndexOf(' ');
			var firstName = fullName.Substring(0, index);
			var lastName = fullName.Substring(index + 1);

			Console.WriteLine("FirstName: "+ firstName);
			Console.WriteLine("LastName: "+ lastName);

			var names = fullName.Split(' ');
			Console.WriteLine("FirstName.Split(): " + names[0]);
			Console.WriteLine("LastName.Split(): " + names[1]);

			Console.WriteLine("FullName.Replace(): " + fullName.Replace("Guillermo", "Guille"));

			if (String.IsNullOrWhiteSpace(" "))
				Console.WriteLine("Invalid"); 

			var str = "25";
			var age = Convert.ToByte(str);
			Console.WriteLine(age);

			float price = 29.99f;
			Console.WriteLine(price.ToString("C0"));
		}
	}
}

