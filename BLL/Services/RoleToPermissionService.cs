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
    public class RoleToPermissionService
    {
        public static List<RoleToPermissionDTO> GetRoleToPermissions()
        {
            var data = DataAccessFactory.RoleToPermissionDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RoleToPermission, RoleToPermissionDTO>());
            var mapper = new Mapper(config);
            var RoleToPermissions = mapper.Map<List<RoleToPermissionDTO>>(data);
            return RoleToPermissions;
        }

        public static RoleToPermissionDTO Get(int id)
        {
            var data = DataAccessFactory.RoleToPermissionDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RoleToPermission, RoleToPermissionDTO>());
            var mapper = new Mapper(config);
            var RoleToPermissions = mapper.Map<RoleToPermissionDTO>(data);
            return RoleToPermissions;
        }

        public static RoleToPermissionDTO Add(RoleToPermissionDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoleToPermissionDTO, RoleToPermission>();
                cfg.CreateMap<RoleToPermission, RoleToPermissionDTO>();
            });
            var mapper = new Mapper(config);
            var RoleToPermissions = mapper.Map<RoleToPermission>(add);
            var result = DataAccessFactory.RoleToPermissionDataAccess().Add(RoleToPermissions);
            return mapper.Map<RoleToPermissionDTO>(result);
        }

        public static RoleToPermissionDTO Update(RoleToPermissionDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoleToPermissionDTO, RoleToPermission>();
                cfg.CreateMap<RoleToPermission, RoleToPermissionDTO>();
            });
            var mapper = new Mapper(config);
            var RoleToPermissions = mapper.Map<RoleToPermission>(id);
            var result = DataAccessFactory.RoleToPermissionDataAccess().Update(RoleToPermissions);
            return mapper.Map<RoleToPermissionDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.RoleToPermissionDataAccess().Delete(id);
            return result;
        }
    }
}
