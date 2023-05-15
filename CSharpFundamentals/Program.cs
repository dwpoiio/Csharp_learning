using CSharpFundamentals.Math;

namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "Johnn";
            john.LastName = "Smith";
            //john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(2, 3);
            //Console.WriteLine(result);

            //Array.Method();

            // En0m.EnumMethod();
            //ReferenceValueTypes.ReferenceValueTypesMethod();
            //ReferenceValueExample.ReferenceValueExampleMethod();
            //Random.Method();

            //DateTimeClass.Method();
            TimeSpanclass.Method();


        }
    }
}

