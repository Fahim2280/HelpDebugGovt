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
    public class RoleService
    {
        public static List<RoleDTO> GetRoles()
        {
            var data = DataAccessFactory.RoleDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Role, RoleDTO>());
            var mapper = new Mapper(config);
            var Roles = mapper.Map<List<RoleDTO>>(data);
            return Roles;
        }

        public static RoleDTO Get(int id)
        {
            var data = DataAccessFactory.RoleDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Role, RoleDTO>());
            var mapper = new Mapper(config);
            var Roles = mapper.Map<RoleDTO>(data);
            return Roles;
        }

        public static RoleDTO Add(RoleDTO add) 
        {
            var config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<RoleDTO, Role>();
                cfg.CreateMap<Role, RoleDTO>();
            });
            var mapper = new Mapper(config);
            var Roles = mapper.Map<Role>(add);
            var result = DataAccessFactory.RoleDataAccess().Add(Roles);
            return mapper.Map<RoleDTO>(result);
        }

        public static RoleDTO Update(RoleDTO id) 
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoleDTO, Role>();
                cfg.CreateMap<Role, RoleDTO>();
            });
            var mapper = new Mapper(config);
            var Roles = mapper.Map<Role>(id);
            var result = DataAccessFactory.RoleDataAccess().Update(Roles);
            return mapper.Map<RoleDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.RoleDataAccess().Delete(id);
            return result;
        }
    }
}
