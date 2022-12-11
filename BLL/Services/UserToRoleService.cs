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
    public class UserToRoleService
    {
        public static List<UserToRoleDTO> GetUserToRoles()
        {
            var data = DataAccessFactory.UserToRoleDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserToRole, UserToRoleDTO>());
            var mapper = new Mapper(config);
            var UserToRoles = mapper.Map<List<UserToRoleDTO>>(data);
            return UserToRoles;
        }

        public static UserToRoleDTO Get(int id)
        {
            var data = DataAccessFactory.UserToRoleDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserToRole, UserToRoleDTO>());
            var mapper = new Mapper(config);
            var UserToRoles = mapper.Map<UserToRoleDTO>(data);
            return UserToRoles;
        }

        public static UserToRoleDTO Add(UserToRoleDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserToRoleDTO, UserToRole>();
                cfg.CreateMap<UserToRole, UserToRoleDTO>();
            });
            var mapper = new Mapper(config);
            var UserToRoles = mapper.Map<UserToRole>(add);
            var result = DataAccessFactory.UserToRoleDataAccess().Add(UserToRoles);
            return mapper.Map<UserToRoleDTO>(result);
        }

        public static UserToRoleDTO Update(UserToRoleDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserToRoleDTO, UserToRole>();
                cfg.CreateMap<UserToRole, UserToRoleDTO>();
            });
            var mapper = new Mapper(config);
            var UserToRoles = mapper.Map<UserToRole>(id);
            var result = DataAccessFactory.UserToRoleDataAccess().Update(UserToRoles);
            return mapper.Map<UserToRoleDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.UserToRoleDataAccess().Delete(id);
            return result;
        }
    }
}
