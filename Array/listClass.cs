using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array1
{
	public class listClass
	{
		public static void listMethod()
		{
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 6, 7, 8 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Index of 1: " +numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

           
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }


            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear();
            Console.WriteLine("Count after clear(): " + numbers.Count);
        }
	}
}

