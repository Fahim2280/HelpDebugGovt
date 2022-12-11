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
    public class SubscriptionService
    {
        public static List<SubscriptionDTO> GetSubscriptions()
        {
            var data = DataAccessFactory.SubscriptionDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Subscription, SubscriptionDTO>());
            var mapper = new Mapper(config);
            var Subscriptions = mapper.Map<List<SubscriptionDTO>>(data);
            return Subscriptions;
        }

        public static SubscriptionDTO Get(int id)
        {
            var data = DataAccessFactory.SubscriptionDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Subscription, SubscriptionDTO>());
            var mapper = new Mapper(config);
            var Subscriptions = mapper.Map<SubscriptionDTO>(data);
            return Subscriptions;
        }

        public static SubscriptionDTO Add(SubscriptionDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SubscriptionDTO, Subscription>();
                cfg.CreateMap<Subscription, SubscriptionDTO>();
            });
            var mapper = new Mapper(config);
            var Subscriptions = mapper.Map<Subscription>(add);
            var result = DataAccessFactory.SubscriptionDataAccess().Add(Subscriptions);
            return mapper.Map<SubscriptionDTO>(result);
        }

        public static SubscriptionDTO Update(SubscriptionDTO id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SubscriptionDTO, Subscription>();
                cfg.CreateMap<Subscription, SubscriptionDTO>();
            });
            var mapper = new Mapper(config);
            var Subscriptions = mapper.Map<Subscription>(id);
            var result = DataAccessFactory.SubscriptionDataAccess().Update(Subscriptions);
            return mapper.Map<SubscriptionDTO>(result);
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.SubscriptionDataAccess().Delete(id);
            return result;
        }
    }
}
