using System;
namespace CSharpFundamentals
{
	public enum ShippingMethod
	{
		RegularAirMail = 1,
		RegisteredAirMail = 2,
		Express = 3
	}
	public class En0m
	{
		public static void EnumMethod()
		{
			var method = ShippingMethod.Express;
			Console.WriteLine((int)method);

			var methodId = 3;
			Console.WriteLine((ShippingMethod)methodId);

			Console.WriteLine(method.ToString());

			var methodName = "RegularAirMail";
			var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

			Console.WriteLine(shippingMethod);
		}
	}
}

