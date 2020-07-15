using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;

			Console.WriteLine("Введите текст:");
			string input = Console.ReadLine();
			string[] words = input.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);
			string[] cloneWords = new string[words.Length];
			int[] wordsRepeats = new int[words.Length];

			for (int i = 0; i < wordsRepeats.Length; i++)
			{
				wordsRepeats[i] = 1;
			}

			for (int i = 0; i < words.Length; i++)
			{
				cloneWords[i] = words[i].ToLower();
			}

			for (int i = 0; i < cloneWords.Length; i++)
			{
				if (cloneWords[i] != "")
				{
					for (int j = i + 1; j < cloneWords.Length; j++)
					{
						if (cloneWords[i] == cloneWords[j])
						{
							wordsRepeats[i]++;
							cloneWords[j] = "";

						}
					}
				}
			}

			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine($"Слово {words[i]} встречается {wordsRepeats[i]} раз");
			}

			counter = wordsRepeats.Max();
			for (int i = 0; i < wordsRepeats.Length; i++)
			{
				if (wordsRepeats[i] == counter)
				{
					Console.WriteLine($"\nЛюбимое слово : {words[i]} встречается {counter} раз");
				}
			}

		}
	}
}
