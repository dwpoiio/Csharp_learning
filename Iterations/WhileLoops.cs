﻿using System;
namespace Iterations
{
	public class WhileLoops
	{
		public static void Method()
		{
			while (true)
			{ 
				Console.Write("Type your name: ");
				var input = Console.ReadLine();

				if (!String.IsNullOrWhiteSpace(input))
				{
                    Console.WriteLine("@Echo: " + input);
					continue;
                }
                    

                break;   
			}
		}
	}
}

