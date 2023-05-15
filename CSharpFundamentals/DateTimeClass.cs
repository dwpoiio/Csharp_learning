using System;
namespace CSharpFundamentals
{
	public class DateTimeClass
	{
        public static void Method()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine(dateTime);
            //Console.WriteLine(now);
            //Console.WriteLine(today);

            //Console.WriteLine("Hour: "+ now.Hour);

            var tomorrow = now.AddDays(1);
            var yeterday = now.AddDays(-1);

            //Console.WriteLine(tomorrow);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


        }
    }
}

