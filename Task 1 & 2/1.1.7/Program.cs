using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._7
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int maxElement = 0, minElement = int.MaxValue, swapElement;
			int[] array = new int[100];
			for (int i = 0; i < 100; i++)
			{
				array[i] = rnd.Next(1, 10000);
				if (array[i] > maxElement)
				{
					maxElement = array[i];
				}
				else if (array[i] < minElement)
				{
					minElement = array[i];
				}
			}
			for (int i = 0; i < 100; i++)
			{
				for (int j = i + 1; j < 100; j++)
				{
					if (array[i] > array[j])
					{
						swapElement = array[i];
						array[i] = array[j];
						array[j] = swapElement;
					}
				}
			}
			Console.WriteLine("Максимальное значение: {0}" +
				"\nМинимальное значение: {1}" +
				"\nОтсортированный массив:", maxElement, minElement);
			foreach (var item in array)
			{
				Console.Write($"{item } ");
			}
		}
	}
}
