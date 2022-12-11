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
    public class CommentService
    {
        public static List<CommentDTO> GetComments()
        {
            var data = DataAccessFactory.CommentDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentDTO>());
            var mapper = new Mapper(config);
            var Comments = mapper.Map<List<CommentDTO>>(data);
            return Comments;
        }

        public static CommentDTO Get(int id)
        {
            var data = DataAccessFactory.CommentDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentDTO>());
            var mapper = new Mapper(config);
            var Comments = mapper.Map<CommentDTO>(data);
            return Comments;
        }

        public static CommentDTO Add(CommentDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CommentDTO, Comment>();
                cfg.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(config);
            var Comments = mapper.Map<Comment>(add);
            var result = DataAccessFactory.CommentDataAccess().Add(Comments);
            return mapper.Map<CommentDTO>(result);
        }

        public static CommentDTO Update(CommentDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CommentDTO, Comment>();
                cfg.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(config);
            var Comments = mapper.Map<Comment>(id);
            var result = DataAccessFactory.CommentDataAccess().Update(Comments);
            return mapper.Map<CommentDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.CommentDataAccess().Delete(id);
            return result;
        }
    }
}
