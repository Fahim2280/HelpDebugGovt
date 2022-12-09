using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, int>, IAuth
    {
        public bool Add(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() < 0;
        }

        public User Authenticate(int ID, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            var upUser = Get(obj.Id);
            db.Entry(upUser).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
