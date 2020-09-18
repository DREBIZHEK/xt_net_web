using Award.Entites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Common;
using User.Entities;

namespace _7._1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rng = new Random();
			int id = rng.Next(int.MaxValue);
			var usersLogic = DependencyResolver.UserLogic;

			usersLogic.Add(new UserEntities() { Age = 20, DateOfBirth = DateTime.Now, Id = id, Name = "Boris" });

			usersLogic.AddAward(usersLogic.GetById(id), new AwardEntites { Id = 15, Title = "First in" });

			foreach (var item in usersLogic.GetAll())
			{
				Console.WriteLine($"{item.Id} {item.Name}");
			}

			Console.WriteLine($"User {usersLogic.GetById(id).Id} = {usersLogic.GetById(id).Name}");
			Console.WriteLine("Awards:");
			string[,] array = usersLogic.GetAwards(id);
			for (int i = 0; i < array.GetUpperBound(0)+1; i++)
			{
				Console.WriteLine($"id:{array[i,1]} Title: \"{array[i,0]}\"");
			}
		}
	}
}
