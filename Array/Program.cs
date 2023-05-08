using System;

namespace Array1
{
    public class Program
    {   
        public static void Main()
        {
            // arrayMethod();
            listClass.listMethod();
        }

        private static void arrayMethod()
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("IndexOf 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear(): ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy(): ");
            foreach (var num in another)
            {
                Console.WriteLine(num);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort(): ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse(): ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
