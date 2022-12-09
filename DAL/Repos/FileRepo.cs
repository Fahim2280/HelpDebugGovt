using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FileRepos : Repo, IRepo<File, int>
    {
        public bool Add(File obj)
        {
            db.Files.Add(obj);  
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var dbDel = Get(id);
            db.Files.Remove(dbDel);
            return db.SaveChanges() > 0;
        }

        public List<File> Get()
        {
            return db.Files.ToList();
        }

        public File Get(int id)
        {
            return db.Files.Find(id);
        }

        public bool Update(File obj)
        {
            var dbUp = Get(obj.Id);
            db.Entry(dbUp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
