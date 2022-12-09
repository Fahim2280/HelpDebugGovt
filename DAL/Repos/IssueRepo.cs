using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class IssueRepos : Repo, IRepo<Issue, int>
    {
        public bool Add(Issue obj)
        {
            db.Issues.Add(obj);
            return db.SaveChanges() > 0;
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

        public bool Update(Issue obj)
        {
            var dbUp = Get(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(dbUp);
            return db.SaveChanges() > 0;
        }
    }
}
