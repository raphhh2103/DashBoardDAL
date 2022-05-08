using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    internal interface IRepository<T>
    {
        bool Delete(int id);

        bool Update(int id);

        bool Create(int id);


        T GetOne(int id);

        IEnumerable<T> GetAll();




    }
}
