using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.DAL;
using Users.DA.Interfaces;
using Users.BLL;
using Users.BLL.Interfaces;

namespace User.Common
{
    public class DependencyResolver
    {
        private static readonly IUserLogic _usersLogic;
        private static readonly IUsersDao _usersDao;

        public static IUserLogic UserLogic => _usersLogic;


        public static IUsersDao UserDao => _usersDao;

        static DependencyResolver()
        {
            _usersDao = new UserDao();
            _usersLogic = new UserLogic(_usersDao);
        }
    }
}

