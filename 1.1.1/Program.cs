using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a:");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter b:");
			int b = int.Parse(Console.ReadLine());
			if (a > 0 & b > 0)
			{
				Console.WriteLine("Area = {0}", a * b);
			}
			else
			{
				Console.WriteLine("Invalid data");
			}

		}
	}
}
