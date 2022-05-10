using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    public interface IRepository<T>
    {
        bool Delete(int id);

        bool Update(T entity);

        //bool Create();


        T GetOne(int id);

        IEnumerable<T> GetAll();




    }
}
