using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LabelToIssueRepo : Repo, IRepo<LabelToIssue, String, LabelToIssue>, IAuth
    {
        public LabelToIssue Add(LabelToIssue obj)
        {
            db.LabelToIssues.Add(obj);
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
            var dbLtS = Get(id);
            db.LabelToIssues.Remove(dbLtS);
            return db.SaveChanges() > 0;
        }

        public List<LabelToIssue> Get()
        {
            return db.LabelToIssues.ToList();
        }

        public LabelToIssue Get(string id)
        {
            return db.LabelToIssues.Find(id);
        }

        public LabelToIssue Update(LabelToIssue obj)
        {
            var dbUp = db.LabelToIssues.Find(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
