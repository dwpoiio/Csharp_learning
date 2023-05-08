using System;
namespace Array1
{
	public class listClass
	{
		public static void listMethod()
		{
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(5);
            numbers.AddRange(new int[3] { 6, 7, 8 });

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
	}
}

