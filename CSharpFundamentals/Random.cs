using System;

namespace CSharpFundamentals
{
	public class Random
	{
		public static void Method()
		{
			var random = new System.Random();

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(random.Next());
			}
			
			while (true)
			{
                Console.Write((char)random.Next(97, 122));
				Console.Write("  ");
            }
				

			
		}
	}
}

