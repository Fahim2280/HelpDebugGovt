using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FileRepos : Repo, IRepo<File, int, File>
    {
        public File Add(File obj)
        {
            db.Files.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
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

        public File Update(File obj)
        {
            var dbup = db.Files.Find(obj.Id);
            db.Entry(dbup).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
