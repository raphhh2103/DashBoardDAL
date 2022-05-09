using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    public class UserRepository : IRepository<UserEntity>
    {
        public bool Create(string mail,string pseudo, string pass)
        {
           UserEntity r = new UserEntity();
            r.Email = mail;
            r.Pseudo = pseudo;
            r.PssWd = pass;
            

            return true;
        }

    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
