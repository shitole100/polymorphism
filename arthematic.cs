using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
	internal class arthematic
	{
		public void add(int num1, int num2)
		{
			int result = num1 + num2;

			Console.WriteLine("addition =" +result	);

		}

		public void add(float num1, float num2)
		{
			float result = num1 + num2;

			Console.WriteLine("float =" + result);

		}
		public void add(int num1, int num2,int num3)
		{
			int result = num1 + num2+num3;

			Console.WriteLine("addition mul =" + result);

		}





	}
}
