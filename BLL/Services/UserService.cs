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
    public class UserService
    {
        public static List<UserDTO> GetUsers()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var Users = mapper.Map<List<UserDTO>>(data);
            return Users;
        }

        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var Users = mapper.Map<UserDTO>(data);
            return Users;
        }

        public static UserDTO Add(UserDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var Users = mapper.Map<User>(add);
            var result = DataAccessFactory.UserDataAccess().Add(Users);
            return mapper.Map<UserDTO>(result);
        }

        public static UserDTO Update(UserDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var Users = mapper.Map<User>(id);
            var result = DataAccessFactory.UserDataAccess().Update(Users);
            return mapper.Map<UserDTO>(result);
        }

        public static bool Delete(string id)
        {
            var result = DataAccessFactory.UserDataAccess().Delete(id);
            return result;
        }
    }
}
