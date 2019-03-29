using System;
namespace P1
{
	public class Const
	{
		public static void Main()
		{
			const double bonusPercent = 0.49;
			int sal = 7777;
			int bonus = (int)(sal * bonusPercent);
			Console.WriteLine(bonus);
		}
	}
}