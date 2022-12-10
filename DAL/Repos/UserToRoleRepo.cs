using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserToRoleRepos : Repo, IRepo<UserToRole, int, UserToRole>
    {
        public UserToRole Add(UserToRole obj)
        {
            db.UserToRoles.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbDel = Get(id);
            db.UserToRoles.Remove(dbDel);
            return db.SaveChanges() > 0;
        }

        public List<UserToRole> Get()
        {
            return db.UserToRoles.ToList();
        }

        public UserToRole Get(int id)
        {
            return db.UserToRoles.Find(id);
        }

        public UserToRole Update(UserToRole obj)
        {
            var dbUp = db.UserToRoles.Find(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
