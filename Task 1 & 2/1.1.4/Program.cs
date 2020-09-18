using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter N:");
			int N = 2 * int.Parse(Console.ReadLine());
			int a;
			int b = N / 2 - 2;
			int count = 1;
			for (int z = 2; z <= N; z += 2)
			{
				a = z;
				count = 1;
				for (int i = 0; i < a; a -= 2)
				{
					for (int j = 0; j < a / 2 + b; j++)
					{
						Console.Write(" ");
					}
					for (int j = 0; j < count; j++)
					{
						Console.Write("*");
					}
					count += 2;
					Console.WriteLine();
				}
				b--;
			}
		}
	}
}
