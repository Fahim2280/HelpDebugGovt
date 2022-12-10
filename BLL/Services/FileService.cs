using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FileService
    {
        public static List<FileDTO> GetFile()
        {
            var data = DataAccessFactory.FileDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<File, FileDTO>());
            var mapper = new Mapper(config);
            var File = mapper.Map<List<FileDTO>>(data);
            return File;
        }

        public static FileDTO Get(int id)
        {
            var data = DataAccessFactory.FileDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<File, FileDTO>());
            var mapper = new Mapper(config);
            var File = mapper.Map<FileDTO>(data);
            return File;
        }

        public static FileDTO Add(FileDTO add)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<File, FileDTO>();
                cfg.CreateMap<FileDTO, File>();
            });
            var mapper = new Mapper(config);
            var File = mapper.Map<File>(add);
            var result = DataAccessFactory.FileDataAccess().Add(File);    
            return mapper.Map<FileDTO>(result);
        }

        public static FileDTO Update(FileDTO id) 
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FileDTO, File>();
                cfg.CreateMap<File, FileDTO>();
            });
            var mapper = new Mapper(config);
            var File = mapper.Map<Role>(id);
            var result = DataAccessFactory.FileDataAccess().Update(File);
            return mapper.Map<FileDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.FileDataAccess().Delete(id);
            return result;
        }
    }
}
