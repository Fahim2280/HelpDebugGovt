using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CommentRepos : Repo, IRepo<Comment, int, Comment>
    {
        public Comment Add(Comment obj)
        {
            db.Comments.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbCom = Get(id);
            db.Comments.Remove(dbCom);
            return db.SaveChanges() > 0;
        }

        public List<Comment> Get()
        {
            return db.Comments.ToList();
        }

        public Comment Get(int id)
        {
            return db.Comments.Find(id);
        }

        public Comment Update(Comment obj)
        {
            var dbUp = db.Comments.Find(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
