using Award.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entities;

namespace Users.DA.Interfaces
{
    public interface IUsersDao
    {
		void Add(UserEntities user);
        void AddAward(UserEntities user, AwardEntites award);
        void RemoveAward(UserEntities user, int awardId);
        void DeleteById(int id);
        IEnumerable<UserEntities> GetAll();

        IEnumerable<AwardEntites> GetAwards(int id);
    }
}
