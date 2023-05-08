using System;
namespace CSharpFundamentals
{
	public class Array
	{
		public static void Method()
		{
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[] { "Jack", "John", "Mary" };

            var firstName = "Guille";
            var lastName = "Larrañaga";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var formatedNames = string.Join(" - ", names);

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(formatedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var text1 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
            Console.WriteLine(text1);
        }
    }
}

