using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._3
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;
			string input = Console.ReadLine();
			string[] words = input.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == words[i].ToLower())
				{
					counter++;
				}
			}
			Console.WriteLine("Количество слов, начинающихся с маленькой буквы = {0}", counter);
		}
	}
}
