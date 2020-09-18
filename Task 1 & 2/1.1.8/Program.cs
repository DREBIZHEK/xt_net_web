using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._8
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[,,] array = new int[10, 10, 10];
			for (int i = 0; i < 10; i++)
				for (int j = 0; j < 10; j++)
					for (int z = 0; z < 10; z++)
					{
						array[i, j, z] = rnd.Next(-1000, 1000);
					}
			Console.WriteLine("Исходный массив: ");
			foreach (var item in array)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------\nИзмененный массив:");
			for (int i = 0; i < 10; i++)
				for (int j = 0; j < 10; j++)
					for (int z = 0; z < 10; z++)
					{
						if (array[i, j, z] > 0)
						{
							array[i, j, z] = 0;
							Console.Write($"{array[i, j, z]} ");
						}
						else
						{
							Console.Write($"{array[i, j, z]} ");
						}
					}


		}
	}
}
