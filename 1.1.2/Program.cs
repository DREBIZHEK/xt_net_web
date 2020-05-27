using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter N");
			int N = int.Parse(Console.ReadLine());
			if (N > 0)
			{
				for (int i = 1; i <= N; i++)
				{
					for (int j = 0; j < i; j++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
			}
		}
	}
}
