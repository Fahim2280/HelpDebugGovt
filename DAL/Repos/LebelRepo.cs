using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LebelRepos : Repo, IRepo<Label, String, Label>, IAuth
    {
        public Label Add(Label obj)
        {
            db.Labels.Add(obj);
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
            var dbLabel = Get(id);
            db.Labels.Remove(dbLabel);
            return db.SaveChanges() > 0;
        }

        public List<Label> Get()
        {
            return db.Labels.ToList();
        }

        public Label Get(string id)
        {
            return db.Labels.Find(id);
        }

        public Label Update(Label obj)
        {
            var dbUp = db.Labels.Find(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
