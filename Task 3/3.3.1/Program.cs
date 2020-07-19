using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] array = new double[] { 1, 2, 3, 6, 7, 8 ,8 };
			array = array.Modify(n => n*n).ToArray();
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("\n Sum {0}", array.SumOfElements());

			Console.WriteLine("Avarage {0}", Math.Round(array.AvarageOfElements(),2));

			Console.WriteLine("\n Repeated {0}", array.RepeatedElement());
		}
	}
}
