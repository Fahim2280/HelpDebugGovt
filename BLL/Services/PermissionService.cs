using AutoMapper;
using BLL.DTO;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PermissionService
    {
        public static List<permissionDTO> GetPermissions()
        {
            var data = DataAccessFactory.PermissionDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Permission, permissionDTO>());
            var mapper = new Mapper(config);
            var Permissions = mapper.Map<List<permissionDTO>>(data);
            return Permissions;
        }

        public static permissionDTO Get(int id)
        {
            var data = DataAccessFactory.PermissionDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Permission, permissionDTO>());
            var mapper = new Mapper(config);
            var Permissions = mapper.Map<permissionDTO>(data);
            return Permissions;
        }

        public static permissionDTO Add(permissionDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<permissionDTO, Permission>();
                cfg.CreateMap<Permission, permissionDTO>();
            });
            var mapper = new Mapper(config);
            var Permissions = mapper.Map<Permission>(add);
            var result = DataAccessFactory.PermissionDataAccess().Add(Permissions);
            return mapper.Map<permissionDTO>(result);
        }

        public static permissionDTO Update(permissionDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<permissionDTO, Permission>();
                cfg.CreateMap<Permission, permissionDTO>();
            });
            var mapper = new Mapper(config);
            var Permissions = mapper.Map<Permission>(id);
            var result = DataAccessFactory.PermissionDataAccess().Update(Permissions);
            return mapper.Map<permissionDTO>(result);
        }   

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.PermissionDataAccess().Delete(id);
            return result;
        }
    }
}
