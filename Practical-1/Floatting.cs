using System;
namespace P1
{
	public class Floatting
	{
		public static void Main()
		{
			float f = 1.115431543F;
			double d = 0.11545543216778899;
			decimal dec = 124524.153515434531243513999M;	
			f = (float)d;
			Console.WriteLine("f is {0} and d is {1} and dec is {2}", f, d, dec);
		}
	}
}