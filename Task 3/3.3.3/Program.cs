using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "";
			string pizza = "";
			int money = 100;

			var pizzeria = new Pizzeria();
			var buyer1 = new Buyer("Jon", 150);
			var buyer2 = new Buyer("Bob", 150);
			var buyer3 = new Buyer("Luice", 150);
			var buyer4 = new Buyer("Ben", 150);

			pizzeria.Order(buyer1);
			pizzeria.Order(buyer2);
			pizzeria.Order(buyer3);
			pizzeria.Order(buyer4);

			Console.WriteLine("\nЗдравствуйте, вы хотите сделать заказ?" +
				"\n1.Да" +
				"\n2.Нет");
			if(Console.ReadLine() == "1")
			{
				Console.WriteLine("Как вас зовут?");
				while (name.Length == 0)
				{
					name = Console.ReadLine();
				}
				
				Console.WriteLine($"\nЗдравствуйте, {name}!" +
					$"\nКакую пиццу вы хотите заказать?:" +
					$"\n1.Florentini = 10.99$" +
					$"\n2.Pepperoni = 15.99$" +
					$"\n3.Hawaiian = 12.49$" +
					$"\n4.BBQ = 12.99$" +
					$"\n5.Caesar = 9.99$");

				switch (Console.ReadLine())
				{
					case "1":
						{
							pizza = "Florentini";
							break;
						}
					case "2":
						{
							pizza = "Pepperoni";
							break;
						}
					case "3":
						{
							pizza = "Hawaiian";
							break;
						}
					case "4":
						{
							pizza = "BBQ";
							break;
						}
					case "5":
						{
							pizza = "Caesar";
							break;
						}
					default:
						break;
				}

				var newBuyer = new Buyer(name, money, pizza);
				pizzeria.Order(newBuyer);

				name = "";
				pizza = "";
			}
			else
			{
				Console.WriteLine("Спасибо за визит");
			}
		}
	}
}
