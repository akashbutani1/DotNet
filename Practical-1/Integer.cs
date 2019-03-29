using System;
namespace P1
{
	class IntType
	{
		public static void Main()
		{
			sbyte sb = 33;
			short s =12 ;
			int i = 45;
			long l = 15L;

			byte b = 78;
			ushort us = 95;
			uint ui = 16U;
			ulong ul = 75UL;
			us = (ushort)ul;

			Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", sb,s,i,l,b,us,ui,ul);

		}
	}
}