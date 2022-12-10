using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RoleRepo : Repo, IRepo<Role, int, Role>
    {
        public Role Add(Role obj)
        {
            db.Roles.Add(obj);

            if(db.SaveChanges() > 0)

            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbDel = db.Roles.Find(id);

            db.Roles.Remove(dbDel); 

            return db.SaveChanges() > 0;
        }

        public List<Role> Get()
        {
            return db.Roles.ToList();
        }

        public Role Get(int id)
        {
            return db.Roles.Find(id);
        }

        public Role Update(Role obj)
        {
            var dbup = db.Roles.Find(obj.Id);
            db.Entry(dbup).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj; 

            return null;
        }
    }
}
