using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			MyArray<int> array = new MyArray<int>(10);
			for (int i = 0; i < 50; i++)
			{
				array.Add(i + 2);
			}
			Console.WriteLine(array[22]);
	}
}
