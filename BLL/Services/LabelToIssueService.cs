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
    public class LabelToIssueService
    {
        public static List<LabelToIssueDTO> GetLabelToIssues()
        {
            var data = DataAccessFactory.LabelToIssueDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LabelToIssue, LabelToIssueDTO>());
            var mapper = new Mapper(config);
            var LabelToIssues = mapper.Map<List<LabelToIssueDTO>>(data);
            return LabelToIssues;
        }

        public static LabelToIssueDTO Get(int id)
        {
            var data = DataAccessFactory.LabelToIssueDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LabelToIssue, LabelToIssueDTO>());
            var mapper = new Mapper(config);
            var LabelToIssues = mapper.Map<LabelToIssueDTO>(data);
            return LabelToIssues;
        }

        public static LabelToIssueDTO Add(LabelToIssueDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LabelToIssueDTO, LabelToIssue>();
                cfg.CreateMap<LabelToIssue, LabelToIssueDTO>();
            });
            var mapper = new Mapper(config);
            var LabelToIssues = mapper.Map<LabelToIssue>(add);
            var result = DataAccessFactory.LabelToIssueDataAccess().Add(LabelToIssues);
            return mapper.Map<LabelToIssueDTO>(result);
        }

        public static LabelToIssueDTO Update(LabelToIssueDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LabelToIssueDTO, LabelToIssue>();
                cfg.CreateMap<LabelToIssue, LabelToIssueDTO>();
            });
            var mapper = new Mapper(config);
            var LabelToIssues = mapper.Map<LabelToIssue>(id);
            var result = DataAccessFactory.LabelToIssueDataAccess().Update(LabelToIssues);
            return mapper.Map<LabelToIssueDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.LabelToIssueDataAccess().Delete(id);
            return result;
        }
    }
}
