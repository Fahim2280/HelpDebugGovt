using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrganizationRepo : Repo, IRepo<Organization, int, Organization>
    {
        public Organization Add(Organization obj)
        {
            db.Organizations.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbDel = db.Organizations.Find(id);
            db.Organizations.Remove(dbDel);
            return db.SaveChanges() > 0;
        }

        public List<Organization> Get()
        {
            return db.Organizations.ToList();
        }

        public Organization Get(int id)
        {
            return db.Organizations.Find(id);
        }

        public Organization Update(Organization obj)
        {
            var dbup = db.Organizations.Find(obj.Id);
            db.Entry(dbup).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
