using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    public class ContentRepository : IRepository<ContentEntity>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool Create(BoardEntity title,string txt)
        {
            ContentEntity c = new ContentEntity();
            c.TitleBoard = title;
            c.Text = txt;
            
            using(DBConnect db =  new DBConnect())
            {
                db.Content.Add(c);
                db.SaveChanges();
            }
                return true;
        }
  
        public bool Delete(int id)
        {
            using(DBConnect db = new DBConnect())
            {
                ContentEntity g = db.Content.Where(f => f.Id == id).FirstOrDefault();
                db.Remove(g);
            }
            return true;
        }

        public IEnumerable<ContentEntity> GetAll()
        {
            List<ContentEntity> t = new List<ContentEntity>();
            using (DBConnect db = new DBConnect())
            {
                t = db.Content.AsQueryable().ToList();
            }
            return t;
        }

        public ContentEntity GetOne(int id)
        {
            ContentEntity m = new ContentEntity();
            using (DBConnect db = new DBConnect())
            {
                m = db.Content.Where(p => p.Id == id).FirstOrDefault();

                return m;
            }
        }



        public bool Update(ContentEntity entity)
        {
            using(DBConnect db = new DBConnect())
            {
                db.Content.Update(entity);
                return true;
            }
        }
    }
}
