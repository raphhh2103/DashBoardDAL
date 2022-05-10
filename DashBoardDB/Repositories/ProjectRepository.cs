using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    public class ProjectRepository : IRepository<ProjectEntity>
    {
        public bool Create(string nameProject)
        {
            ProjectEntity p = new ProjectEntity();

            p.NameProject = nameProject;
            p.TeamsUsers = new List<UserEntity>();
            using(DBConnect db= new DBConnect())
            {
                db.Project.Add(p);
                db.SaveChanges();
                return true;
            }
        }

        public bool Delete(int id)
        {
            using (DBConnect db = new DBConnect())
            {
                var t = db.Project.Where(a => a.Id == id).FirstOrDefault();
                if (t is ProjectEntity)
                    db.Remove(t);
            }
            return true;
        }

        public IEnumerable<ProjectEntity> GetAll()
        {
            List<ProjectEntity> entities = new List<ProjectEntity>();
            using (DBConnect db = new DBConnect())
            {
                entities = db.Project.AsQueryable().ToList();
            }
            return entities;
        }

        public ProjectEntity GetOne(int id)
        {
            ProjectEntity pj = new ProjectEntity();
            using (DBConnect db = new DBConnect())
            {
                pj = db.Project.Where(p => p.Id == id).FirstOrDefault();

            }
            return pj;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(ProjectEntity entity)
        {
            using (DBConnect db = new DBConnect())
            {
                db.Project.Update(entity);
                return true;
            }
        }
    }
}
