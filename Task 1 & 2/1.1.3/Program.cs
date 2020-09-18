using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter N:");
			int N = 2 * int.Parse(Console.ReadLine());
			int count = 1;
			for (int i = 0; i < N; N -= 2)
			{
				for (int j = 0; j < N / 2; j++)
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
		}
	}
}
