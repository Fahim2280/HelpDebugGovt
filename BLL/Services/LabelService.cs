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
    public class LabelService
    {
        public static List<LabelDTO> GetLabels()
        {
            var data = DataAccessFactory.LabelDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Label, LabelDTO>());
            var mapper = new Mapper(config);
            var Labels = mapper.Map<List<LabelDTO>>(data);
            return Labels;
        }

        public static LabelDTO Get(int id)
        {
            var data = DataAccessFactory.LabelDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Label, LabelDTO>());
            var mapper = new Mapper(config);
            var Labels = mapper.Map<LabelDTO>(data);
            return Labels;
        }

        public static LabelDTO Add(LabelDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LabelDTO, Label>();
                cfg.CreateMap<Label, LabelDTO>();
            });
            var mapper = new Mapper(config);
            var Labels = mapper.Map<Label>(add);
            var result = DataAccessFactory.LabelDataAccess().Add(Labels);
            return mapper.Map<LabelDTO>(result);
        }

        public static LabelDTO Update(LabelDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LabelDTO, Label>();
                cfg.CreateMap<Label, LabelDTO>();
            });
            var mapper = new Mapper(config);
            var Labels = mapper.Map<Label>(id);
            var result = DataAccessFactory.LabelDataAccess().Update(Labels);
            return mapper.Map<LabelDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.LabelDataAccess().Delete(id);
            return result;
        }
    }
}
