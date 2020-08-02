using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
	static class Control
	{
		public static void Start()
		{
			for (int i = 0; i == 0;)
			{
				Console.Clear();
				Console.WriteLine("Choos mode:" +
					"\n1 - Monitoring" +
					"\n2 - Rolling Back Changes" +
					"\n0 - Exit");

				switch (Console.ReadLine())
				{
					case "1":
						Supervision.Monitoring();
						break;
					case "2":
						RollingBackChanges.Changes();
						break;
					case "0":
						i++;
						break;
					default:
						break;
				}
			}
		}
	}
}
