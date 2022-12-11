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
    public class IssueService
    {
        public static List<IssueDTO> GetIssues()
        {
            var data = DataAccessFactory.IssueDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Issue, IssueDTO>());
            var mapper = new Mapper(config);
            var Issues = mapper.Map<List<IssueDTO>>(data);
            return Issues;
        }

        public static IssueDTO Get(int id)
        {
            var data = DataAccessFactory.IssueDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Issue, IssueDTO>());
            var mapper = new Mapper(config);
            var Issues = mapper.Map<IssueDTO>(data);
            return Issues;
        }

        public static IssueDTO Add(IssueDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<IssueDTO, Issue>();
                cfg.CreateMap<Issue, IssueDTO>();
            });
            var mapper = new Mapper(config);
            var Issues = mapper.Map<Issue>(add);
            var result = DataAccessFactory.IssueDataAccess().Add(Issues);
            return mapper.Map<IssueDTO>(result);
        }

        public static IssueDTO Update(IssueDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<IssueDTO, Issue>();
                cfg.CreateMap<Issue, IssueDTO>();
            });
            var mapper = new Mapper(config);
            var Issues = mapper.Map<Issue>(id);
            var result = DataAccessFactory.IssueDataAccess().Update(Issues);
            return mapper.Map<IssueDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.IssueDataAccess().Delete(id);
            return result;
        }
    }
}
