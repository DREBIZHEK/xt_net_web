using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] words = input.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
			int[] wordsLength = new int[words.Length];
			for (int i = 0; i < words.Length; i++)
			{
				wordsLength[i] = words[i].Length;
			}
			Console.WriteLine("Средняя длина слова = {0}", Math.Round(wordsLength.Average()));

		}
	}
}
