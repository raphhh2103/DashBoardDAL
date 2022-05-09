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
        /// <summary>
        /// creation d'un user  
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="pseudo"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool Create(string mail, string pseudo, string pass)
        {
            UserEntity r = new UserEntity();
            r.Email = mail;
            r.Pseudo = pseudo;
            r.PssWd = pass;
            r.Teams = new List<TeamEntity>();
            r.Boards = new List<BoardEntity>();
            using (DBConnect db = new DBConnect())
            {
                db.User.Add(r);
                db.SaveChanges();
                return true;
            }

        }
        /// <summary>
        /// a modifier pour ne pas supprimer completement l'utilisateur ?
        /// pour le moment supprime un utilisateur ! 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            using (DBConnect db = new DBConnect())
            {
                var g = db.User.Where(x => x.Id == id).FirstOrDefault();

                if (g is UserEntity)
                    db.Remove(g);
            }

            return true;
        }
        /// <summary>
        /// recupere tout les users 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetAll()
        {
            List<UserEntity> r = new List<UserEntity>();
            using (DBConnect db = new DBConnect())
            {
                r = db.User.AsQueryable().ToList();
            }
            return r;
        }
        /// <summary>
        /// recupere un user selon un Id entrée en parametre 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity GetOne(int id)
        {
            UserEntity t = new UserEntity();
            using (DBConnect db = new DBConnect())
            {
                t = db.User.Where(a => a.Id == id).FirstOrDefault();
                return t;
            }
        }
        /// <summary>
        /// recherche les différencces entre le user envoyer en parametre  et le user en db avec le meme ID
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(UserEntity entity)
        {
            using (DBConnect db = new DBConnect())
            {

                db.User.Update(entity);

                //var q = db.User.Where(y => y.Id == entity.Id).FirstOrDefault();

                //if (q is UserEntity)
                //{
                //    if (q.Email != entity.Email)
                //    {
                //        q.Email = entity.Email;
                //    }
                //    if (q.Pseudo != entity.Pseudo)
                //    {
                //        q.Pseudo = entity.Pseudo;
                //    }
                //    if (q.PssWd != entity.PssWd)
                //    {
                //        q.PssWd = entity.PssWd;
                //    }
                //    if (q.Teams != entity.Teams)
                //    {
                //        foreach (var item in entity.Teams)
                //        {
                //            q.Teams.ToList().Add(item);
                //        }
                //    }
                //    if (q.Boards != entity.Boards)
                //    {
                //        foreach (var item in entity.Boards)
                //        {
                //            q.Boards.ToList().Add(item);
                //        }
                //    }
                //    //db.Add(q);
                //    db.SaveChanges();
                    return true;
                //}
            }
            
        }
    }
}
