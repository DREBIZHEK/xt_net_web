using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._10
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[,] array = new int[10, 10];
			int sum = 0;
			for (int i = 0; i < 10; i++)
				for (int j = 0; j < 10; j++)
				{
					array[i, j] = rnd.Next(1, 100);
					if ((i + j) % 2 == 0)
					{
						sum += array[i, j];
					}
				}
			Console.WriteLine("Исходный массив:");
			foreach (var item in array)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine("\nСумма элементов стоящих на четных позициях = {0}", sum);
		}
	}
}
