using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LebelRepos : Repo, IRepo<Label, int, Label>
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

        public bool Delete(int id)
        {
            var dbLabel = Get(id);
            db.Labels.Remove(dbLabel);
            return db.SaveChanges() > 0;
        }

        public List<Label> Get()
        {
            return db.Labels.ToList();
        }

        public Label Get(int id)
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
