using Award.Entites;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entities;
using Users.DA.Interfaces;

namespace User.DAL
{
	public class UserDao : IUsersDao
	{
		public void Add(UserEntities user)
		{
			using (StreamWriter sw = new StreamWriter("users.txt", true))
			{
				sw.WriteLine(JsonConvert.SerializeObject(user));
			}
		}

		public void AddAward(UserEntities user, AwardEntites award)
		{
			user.awards.Add(award);
		}

		public void DeleteById(int id)
		{
			using (StreamWriter sw = new StreamWriter("usersTemp.txt", true))
			using (StreamReader sr = new StreamReader("users.txt"))
			{
				string line;
				while (!sr.EndOfStream)
				{
					line = sr.ReadLine();
					if (!line.Contains($"\"Id\":{id}"))
					{
						sw.WriteLine(line);
					}
				}
			}
			File.Delete("users.txt");
			File.Copy("usersTemp.txt", "users.txt");
			File.WriteAllText("usersTemp.txt", "");
		}

		public IEnumerable<UserEntities> GetAll()
		{
			List<UserEntities> users = new List<UserEntities>();
			using (StreamReader sr = new StreamReader("users.txt"))
			{
				while (!sr.EndOfStream)
				{

					users.Add(JsonConvert.DeserializeObject<UserEntities>(sr.ReadLine()));
				}
			}
			return users;
		}

		public IEnumerable<AwardEntites> GetAwards(int id)
		{

			using (StreamReader sr = new StreamReader("users.txt"))
			{
				string line;
				while (!sr.EndOfStream)
				{
					line = sr.ReadLine();
					if (line.Contains($"\"Id\":{id}"))
					{
						return JsonConvert.DeserializeObject<UserEntities>(line).awards;
					}
				}
			}
			return null;
		}

		public void RemoveAward(UserEntities user, int awardId)
		{
			foreach (var item in user.awards)
			{
				if (item.Id == awardId)
				{
					user.awards.Remove(item);
				}
			}
		}
	}
}
