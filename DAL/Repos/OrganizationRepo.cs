using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrganizationRepo : Repo, IRepo<Organization, int>
    {
        public bool Add(Organization obj)
        {
            db.Organizations.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var dbDel = Get(id);
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

        public bool Update(Organization obj)
        {
            var dbUp = Get(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
