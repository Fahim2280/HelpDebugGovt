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
    public class OrganizationService
    {
        public static List<OrganizationDTO> GetOrganizations()
        {
            var data = DataAccessFactory.OrgDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>());
            var mapper = new Mapper(config);
            var Organizations = mapper.Map<List<OrganizationDTO>>(data);
            return Organizations;
        }

        public static OrganizationDTO Get(int id)
        {
            var data = DataAccessFactory.OrgDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>());
            var mapper = new Mapper(config);
            var Organizations = mapper.Map<OrganizationDTO>(data);
            return Organizations;
        }

        public static OrganizationDTO Add(OrganizationDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrganizationDTO, Organization>();
                cfg.CreateMap<Organization, OrganizationDTO>();
            });
            var mapper = new Mapper(config);
            var Organizations = mapper.Map<Organization>(add);
            var result = DataAccessFactory.OrgDataAccess().Add(Organizations);
            return mapper.Map<OrganizationDTO>(result);
        }

        public static OrganizationDTO Update(OrganizationDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrganizationDTO, Organization>();
                cfg.CreateMap<Organization, OrganizationDTO>();
            });
            var mapper = new Mapper(config);
            var Organizations = mapper.Map<Organization>(id);
            var result = DataAccessFactory.OrgDataAccess().Update(Organizations);
            return mapper.Map<OrganizationDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.OrgDataAccess().Delete(id);
            return result;
        }
    }
}
