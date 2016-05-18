using System;
using ServiceStack.Redis;

namespace WebCoreCache
{
    public class AspNetCache : ICache
    {
        private const string CacheKeyPrefix = "WEBCORE_";

        RedisClient redis = new RedisClient("127.0.0.1", 6379);

        public object Get(string key)
        {
            return redis.Get(key);
        }

        public object Get<Type>(string key)
        {
            return redis.Get<Type>(key);
        }

        public void Set(string key, object value, TimeSpan expiresIn)
        {
            redis.Set(key, value, expiresIn);
        }

        public void Expire(string key)
        {
            redis.Del(key);
        }

        public void Extend(string key)
        {
            redis.Persist(key);
        }

        private string GetKey(string key)
        {
            return redis.GetKeysByPattern(key).ToString();
        }


        public void ClearCache()
        {
            redis.FlushAll();
        }
    }
}