using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
	public class Game
	{
		private int roundNumber = 0;
		private int playersCount;
		private int deletedNumber;
		List<Player> players = new List<Player>();

		public Game()
		{

		}

		public void Start()
		{
			string value;

			Console.WriteLine("Введите N: ");
			value = Console.ReadLine();

			if (int.TryParse(value, out int result))
			{
				playersCount = Convert.ToInt32(value);

			}
			else
			{
				throw new ArgumentException($"Value {value} incorrect!");
			}

			Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
			value = Console.ReadLine();

			if (int.TryParse(value, out result))
			{
				deletedNumber = Convert.ToInt32(value);

			}
			else
			{
				throw new ArgumentException($"Value {value} incorrect!");
			}

			for (int i = 0; i < playersCount; i++)
			{
				players.Add(new Player());
			}

			Console.WriteLine($"\nСгенерирован круг людей. Начинаем вычеркивать каждого {deletedNumber}\n");

			while (players.Count >= deletedNumber)
			{
				for (int i = deletedNumber - 1; i < players.Count; i+=deletedNumber)
				{
					if (i<players.Count)
					{
						roundNumber++;
						players.RemoveAt(i);
						Console.WriteLine($"Раунд {roundNumber}. Вычеркнут человек. Людей осталось: {players.Count}");
					}
					else
					{
						return;
					}
				}

			}

			Console.WriteLine("\nИгра окончена. Невозможно вычеркнуть больше людей.\n");
		}

	}
}
