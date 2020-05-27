using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			string input1, input2;
			Console.WriteLine("Введите первую строку:");
			input1 = Console.ReadLine();
			Console.WriteLine("Введите вторую строку:");
			input2 = Console.ReadLine();
			char[] symbols = input2.ToCharArray();
			symbols = symbols.Distinct().ToArray();
			for (int i = 0; i < symbols.Length; i++)
			{
				for (int j = 0; j < input1.Length; j++)
				{
					int symbolPosition = input1.IndexOf(symbols[i], j);
					if (symbolPosition >= 0)
					{
						input1 = input1.Insert(symbolPosition, symbols[i].ToString());
						j = symbolPosition + 1;
					}
				}
			}
			Console.WriteLine(input1);
		}
	}
}
