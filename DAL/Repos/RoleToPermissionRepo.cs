using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RoleToPermissionRepos : Repo, IRepo<RoleToPermission, int, RoleToPermission>
    {
        public RoleToPermission Add(RoleToPermission obj)
        {
            db.RoleToPermissions.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbRtP= Get(id);
            db.RoleToPermissions.Remove(dbRtP);
            return db.SaveChanges() > 0;
        }

        public List<RoleToPermission> Get()
        {
            return db.RoleToPermissions.ToList();
        }

        public RoleToPermission Get(int id)
        {
            return db.RoleToPermissions.Find(id);
        }

        public RoleToPermission Update(RoleToPermission obj)
        {
            var dbUp = db.RoleToPermissions.Find(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
