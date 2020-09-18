using Award.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entities;

namespace Users.BLL.Interfaces
{
    public interface IUserLogic
    {
        void Add(UserEntities user);

        void AddAward(UserEntities user, AwardEntites award);

        void RemoveAward(UserEntities user, int awardId);

        void DeleteById(int id);

        IEnumerable<UserEntities> GetAll();

        UserEntities GetById(int id);

        string[,] GetAwards(int id);
    }
}
