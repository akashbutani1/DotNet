using System;
namespace P1
{
	public class Vector
	{
		public int value;
	}
	public class DataTypes
	{
		public static void Main()
		{
			int i;
			int j;
			i = 07;
			j = i;

			Console.WriteLine("i is {0} and j is {1}", i, j);
			j = 15;
			Console.WriteLine("i is {0} and j is {1}", i, j);

			Vector x,y;
			x = new Vector();
			x.value = 25;
			y = x;
			Console.WriteLine("x is {0} and y is {1}", x.value, y.value);
			y.value = 24;
			Console.WriteLine("x is {0} and y is {1}", x.value, y.value);

		}
	}
}