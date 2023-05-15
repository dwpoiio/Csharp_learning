using System;
namespace CSharpFundamentals
{
	public class TimeSpanclass
	{
		public static void Method()
		{
			// Creating
			var timespan = new TimeSpan(1, 2, 3);

            var timespan1 = new TimeSpan(1, 0,0);
			var timespan2 = TimeSpan.FromHours(1);

			var start = DateTime.Now;
            var endFixed = start.AddMinutes(2);
            var end = DateTime.Now.AddMinutes(2);
			var duration = endFixed - start;

			Console.WriteLine("Duration: " + duration);

			// Proeperties
			Console.WriteLine("Minutes: " + timespan.Minutes);
            Console.WriteLine("total Minutes: " + timespan.TotalMinutes);

            // Add
            Console.WriteLine("Comparative: " + timespan);
            Console.WriteLine("Add Example: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timespan.Subtract(TimeSpan.FromMinutes(2)));

			// ToString
			Console.WriteLine("ToString: " + timespan.ToString());

			// Parse
			Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
	}
} 

