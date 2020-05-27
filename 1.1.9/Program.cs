using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._9
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			Random rnd = new Random();
			int[] array = new int[100];
			for (int i = 0; i < 100; i++)
			{
				array[i] = rnd.Next(-100, 100);
				if (array[i] > 0)
				{
					sum += array[i];
				}
			}
			Console.WriteLine("Массив");
			foreach (var item in array)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine("\nСумма положительных элементов = {0}", sum);
		}
	}
}
