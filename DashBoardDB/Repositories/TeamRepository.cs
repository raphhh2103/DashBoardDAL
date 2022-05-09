using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    internal class TeamRepository : IRepository<TeamEntity>
    {
        public bool Create()
        {



            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TeamEntity GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
