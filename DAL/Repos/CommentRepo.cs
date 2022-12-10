using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CommentRepos : Repo, IRepo<Comment, String, Comment>, IAuth
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

        public bool Authenticate(string Email, string pass)
        {
            var data = db.Users.FirstOrDefault(x => x.Email.Equals(Email) && x.Password.Equals(pass));
            if (data != null) return true;
            return false;
        }

        public bool Delete(string id)
        {
            var dbCom = Get(id);
            db.Comments.Remove(dbCom);
            return db.SaveChanges() > 0;
        }

        public List<Comment> Get()
        {
            return db.Comments.ToList();
        }

        public Comment Get(string id)
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
