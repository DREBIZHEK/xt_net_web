using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3
{
	class Pizzeria
	{
		List<string> orders = new List<string>();
		private const double Florentini = 10.99,
			Pepperoni = 15.99,
			Hawaiian = 12.49,
			BBQ = 12.99,
			Caesar = 9.99;

		public Pizzeria()
		{

		}

		public void Order(Buyer buyer)
		{
			string order = buyer.OrderPizza();
			int orderID = buyer.ShowBuyerID();
			bool payment = false;

			switch (order)
			{
				case "Florentini":
					{
						payment = buyer.PayForPizza(Florentini);
						break;
					}
				case "Pepperoni":
					{

						payment = buyer.PayForPizza(Pepperoni);
						break;
					}
				case "Hawaiian":
					{
						payment = buyer.PayForPizza(Hawaiian);
						break;
					}
				case "BBQ":
					{
						payment = buyer.PayForPizza(BBQ);
						break;
					}
				case "Caesar":
					{
						payment = buyer.PayForPizza(Caesar);
						break;
					}
				default:
					return;
			}

			order = $"Заказ №{orderID} - пицца {order}";

			if (payment)
			{
				Console.WriteLine($"\n{buyer.ShowBuyerName()}, ваша пицца будет готова через 10 минут, спасибо за заказ! Номер заказа :{orderID}");
				orders.Add(order);
				ShowOrderList();
			}
			else
			{
				Console.WriteLine($"Извините, {buyer.ShowBuyerName()}, на вашем счету недостаточно средств для оплаты заказа.");
			}
		}

		private void ShowOrderList()
		{
			Console.WriteLine("\nСПИСОК ЗАКАЗОВ:");
			foreach (var item in orders)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}

	}
}
