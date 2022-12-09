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
    internal class permissionRepo : Repo, IRepo<Permission, int, Permission>
    {
        public Permission Add(Permission obj)
        {
            db.Permissions.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
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

        public Permission Update(Permission obj)
        {
            var dbup = db.Permissions.Find(obj.Id);
            db.Entry(dbup).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
