using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class IssueRepos : Repo, IRepo<Issue, int, Issue>
    {
        public Issue Add(Issue obj)
        {
            db.Issues.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbDel = Get(id);
            db.Issues.Remove(dbDel);
            return db.SaveChanges() > 0;
        }

        public List<Issue> Get()
        {
            return db.Issues.ToList();
        }

        public Issue Get(int id)
        {
            return db.Issues.Find(id);
        }

        public Issue Update(Issue obj)
        {
            var dbup = db.Issues.Find(obj.Id);
            db.Entry(dbup).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
