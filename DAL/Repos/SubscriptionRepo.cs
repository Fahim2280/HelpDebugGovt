using System;
using DAL.EF;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SubscriptionRepo : Repo, IRepo<Subscription, int, Subscription>
    {
        public Subscription Add(Subscription obj)
        {
            db.Subscriptions.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbSub = Get(id);
            db.Subscriptions.Remove(dbSub);
            return db.SaveChanges() > 0;
        }

        public List<Subscription> Get()
        {
            return db.Subscriptions.ToList();
        }

        public Subscription Get(int id)
        {
            return db.Subscriptions.Find(id);
        }

        public Subscription Update(Subscription obj)
        {
            var dbUp = db.Subscriptions.Find(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
