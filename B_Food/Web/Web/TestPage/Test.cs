using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.Common;
using ServiceStack.Redis;
using ServiceStack.Text;
using ServiceStack.ServiceInterface;

namespace B1993.Web.Web
{
    public class Redis
    {
        public void a()
        {
            RedisClient redisClient = new RedisClient("47.92.117.106", 6379);
            string strRedis = redisClient.Get<string>("city");
        }
        
    }
}