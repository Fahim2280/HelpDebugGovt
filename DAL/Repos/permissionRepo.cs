using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class permissionRepo : Repo, IRepo<Permission, int>
    {
        public bool Add(Permission obj)
        {
            db.Permissions.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var dbDel = Get(id);
            db.Permissions.Remove(dbDel);
            return db.SaveChanges() > 0;
        }

        public List<Permission> Get()
        {
            return db.Permissions.ToList();
        }

        public Permission Get(int id)
        {
           return db.Permissions.Find(id);
        }

        public bool Update(Permission obj)
        {
            var dbUp = Get(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0; 
        }
    }
}
