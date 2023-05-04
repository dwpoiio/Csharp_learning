using System;
namespace Iterations
{
	public class ForEach
	{
		public static void Method()
		{
			var name = "John Smith";

			var numbers = new int[] {1,2,3,4 };

			foreach (var character in name)
			{
				Console.WriteLine(character);
			}

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}

