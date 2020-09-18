using Award.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entities;
using Users.BLL.Interfaces;
using Users.DA.Interfaces;

namespace Users.BLL
{
	public class UserLogic : IUserLogic
	{
		private readonly IUsersDao _usersDao;

		public UserLogic(IUsersDao usersDao)
		{
			_usersDao = usersDao;
		}

		public void Add(UserEntities user)
		{
			_usersDao.Add(user);
		}

		public void AddAward(UserEntities user, AwardEntites award)
		{
			_usersDao.AddAward(user, award);
			_usersDao.DeleteById(user.Id);
			_usersDao.Add(user);
		}

		public void DeleteById(int id)
		{
			_usersDao.DeleteById(id);
		}

		public IEnumerable<UserEntities> GetAll()
		{
			return _usersDao.GetAll();
		}

		public string[,] GetAwards(int userId)
		{
			int count = 0;
			string[,] array = new string[_usersDao.GetAwards(userId).Count(),2];

			foreach (var item in _usersDao.GetAwards(userId))
			{
				array[count,0] = item.Title;
				array[count,1] = item.Id.ToString();
			}
			return array;
		}

		public UserEntities GetById(int id)
		{
			return _usersDao.GetAll().FirstOrDefault(item => item.Id == id);
		}

		public void RemoveAward(UserEntities user, int awardId)
		{
			_usersDao.RemoveAward(user, awardId);
		}
	}
}
