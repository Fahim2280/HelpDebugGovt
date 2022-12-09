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
            throw new NotImplementedException();
        }

        public User Authenticate(int ID, string password)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(string Email, string pass)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }

        User IAuth.Authenticate(string Email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
