using System;

namespace WebCoreCache
{
    public interface ICache
    {
        object Get(string key);
        object Get<Type>(string key);
        void Set(string key, object value, TimeSpan expiresIn);
        void Expire(string key);
        void Extend(string key);
        void ClearCache();
    }
}
