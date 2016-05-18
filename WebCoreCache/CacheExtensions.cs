using System;

namespace WebCoreCache
{

    public static class CacheExtensions
    {
        public static readonly TimeSpan CACHE_TTL = TimeSpan.FromHours(2);

        public static object GetUser(this ICache cache, string token)
        {
            string key = CacheKeys.GetUser(token);
            return cache.Get(key);
        }

        public static void SetUser(this ICache cache, string token, object user)
        {
            string key = CacheKeys.GetUser(token);
            cache.Set(key, user, CACHE_TTL);
        }

        public static object GetDeviceToken(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceToken(deviceId);
            return cache.Get(key);
        }
        public static void SetDeviceToken(this ICache cache, string deviceId, string token)
        {
            string key = CacheKeys.GetDeviceToken(deviceId);
            cache.Set(key, token, CACHE_TTL);
        }
        public static void ClearDeviceToken(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceToken(deviceId);
            cache.Expire(key);
        }
        public static object GetSpeedThreshold(this ICache cache, string connectionString)
        {
            string key = CacheKeys.GetSpeed(connectionString);
            return cache.Get(key);
        }

        public static void SetSpeedThreshold(this ICache cache, string connectionString, object speed)
        {
            string key = CacheKeys.GetSpeed(connectionString);
            cache.Set(key, speed, CACHE_TTL);
        }

        public static void ClearSpeedThreshold(this ICache cache, string connectionString)
        {
            string key = CacheKeys.GetSpeed(connectionString);
            cache.Expire(key);
        }

        public static object GetIdleThreshold(this ICache cache, string connectionString)
        {
            string key = CacheKeys.GetIdle(connectionString);
            return cache.Get(key);
        }

        public static void SetIdleThreshold(this ICache cache, string connectionString, object idle)
        {
            string key = CacheKeys.GetIdle(connectionString);
            cache.Set(key, idle, CACHE_TTL);
        }
        public static void ClearIdleThreshold(this ICache cache, string connectionString)
        {
            string key = CacheKeys.GetIdle(connectionString);
            cache.Expire(key);
        }
        public static object GetDeviceIdleStart(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceIdle(deviceId);
            return cache.Get(key);
        }

        public static void SetDeviceIdleStart(this ICache cache, string deviceId, object startTime)
        {
            string key = CacheKeys.GetDeviceIdle(deviceId);
            cache.Set(key, startTime, CACHE_TTL);
        }

        public static void ClearDeviceIdleStart(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceIdle(deviceId);
            cache.Expire(key);
        }

        public static object GetDeviceIdleLastNotified(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetIdleLastNotified(deviceId);
            return cache.Get(key);
        }

        public static void SetDeviceIdleLastNotified(this ICache cache, string deviceId, object lastTime)
        {
            string key = CacheKeys.GetIdleLastNotified(deviceId);
            cache.Set(key, lastTime, CACHE_TTL);
        }

        public static void ClearDeviceIdleLastNotified(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetIdleLastNotified(deviceId);
            cache.Expire(key);
        }

        public static object GetDeviceSpeedLastNotified(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceLastSpeed(deviceId);
            return cache.Get(key);
        }

        public static void SetDeviceSpeedLastNotified(this ICache cache, string deviceId, object lastTime)
        {
            string key = CacheKeys.GetDeviceLastSpeed(deviceId);
            cache.Set(key, lastTime, CACHE_TTL);
        }

        public static void ClearDeviceLastSpeed(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceLastSpeed(deviceId);
            cache.Expire(key);
        }

        public static object GetDeviceGCMRegistration(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetGCM(deviceId);
            return cache.Get(key);
        }

        public static void SetDeviceGCMRegistration(this ICache cache, string deviceId, object registrationModel)
        {
            string key = CacheKeys.GetGCM(deviceId);
            cache.Set(key, registrationModel, CACHE_TTL);
        }

        public static void ClearDeviceGCMRegistration(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetGCM(deviceId);
            cache.Expire(key);
        }

        public static object GetDeviceGCMState(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetGCMState(deviceId);
            return cache.Get(key);
        }

        public static void SetDeviceGCMState(this ICache cache, string deviceId, object state)
        {
            string key = CacheKeys.GetGCMState(deviceId);
            cache.Set(key, state, CACHE_TTL);
        }

        public static void ClearDeviceGCMState(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetGCMState(deviceId);
            cache.Expire(key);
        }

        public static object GetDeviceUserInfo(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceUser(deviceId);
            return cache.Get(key);
        }

        public static void SetDeviceUserInfo(this ICache cache, string deviceId, object userInformation)
        {
            string key = CacheKeys.GetDeviceUser(deviceId);
            cache.Set(key, userInformation, CACHE_TTL);
        }

        public static void CleareDeviceUserInfo(this ICache cache, string deviceId)
        {
            string key = CacheKeys.GetDeviceUser(deviceId);
            cache.Expire(key);
        }
        public static object GetClientIdleList(this ICache cache, string clientKey, int workerId)
        {
            string key = CacheKeys.GetClientIdleList(clientKey, workerId);
            return cache.Get(key);
        }
        public static void SetClientIdleList(this ICache cache, string clientKey, int workerId, object idleList)
        {
            string key = CacheKeys.GetClientIdleList(clientKey, workerId);
            cache.Set(key, idleList, CACHE_TTL);
        }
        public static void ClearClientIdleList(this ICache cache, string clientKey, int workerId)
        {
            string key = CacheKeys.GetClientIdleList(clientKey, workerId);
            cache.Expire(key);
        }
        public static object GetClientSpeedList(this ICache cache, string clientKey, int workerId)
        {
            string key = CacheKeys.GetClientSpeedList(clientKey, workerId);
            return cache.Get(key);
        }
        public static void SetClientSpeedList(this ICache cache, string clientKey, int workerId, object speedList)
        {
            string key = CacheKeys.GetClientSpeedList(clientKey, workerId);
            cache.Set(key, speedList, CACHE_TTL);
        }
        public static void ClearClientSpeedList(this ICache cache, string clientKey, int workerId)
        {
            string key = CacheKeys.GetClientSpeedList(clientKey, workerId);
            cache.Expire(key);
        }

        public static object GetImageRecipientList(this ICache cache, string clientKey, int workerId)
        {
            string key = CacheKeys.GetImageRecipientListToken(clientKey, workerId);
            return cache.Get(key);
        }

        public static void SetImageRecipientList(this ICache cache, string clientKey, int workerId, object imageList, TimeSpan ttl)
        {
            if (ttl == null)
            {
                ttl = CACHE_TTL;
            }
            string key = CacheKeys.GetImageRecipientListToken(clientKey, workerId);
            cache.Set(key, imageList, ttl);
        }

        public static void CleareImageRecipientList(this ICache cache, string clientKey, int workerId)
        {
            string key = CacheKeys.GetImageRecipientListToken(clientKey, workerId);
            cache.Expire(key);
        }

        public static void SetGroupConnectionInfo(this ICache cache, string groupKey, object connectionInfo)
        {
            string key = CacheKeys.GetGroupConnectionInfo(groupKey);
            cache.Set(key, connectionInfo, CACHE_TTL);
        }

        public static object GetGroupConnectionInfo(this ICache cache, string groupKey)
        {
            string key = CacheKeys.GetGroupConnectionInfo(groupKey);
            return cache.Get(key);
        }

        public static void ExpireGroupConnectionInfo(this ICache cache, string groupKey)
        {
            string key = CacheKeys.GetGroupConnectionInfo(groupKey);
            cache.Expire(key);
        }

        public static void SetGroupDashboardObject(this ICache cache, string groupKey, object dashboardObj)
        {
            string key = CacheKeys.GetDashboardObjects(groupKey);
            cache.Set(key, dashboardObj, CACHE_TTL);
        }

        public static object GetGroupDashboardObject(this ICache cache, string groupKey)
        {
            string key = CacheKeys.GetDashboardObjects(groupKey);
            return cache.Get(key);
        }

        public static void SetGroupRouteObject(this ICache cache, string groupKey, int routeKey, object routeObj)
        {
            string key = CacheKeys.GetRouteStats(groupKey, routeKey);
            cache.Set(key, routeObj, CACHE_TTL);
        }

        public static object GetGroupRouteObject(this ICache cache, string groupKey, int routeKey)
        {
            string key = CacheKeys.GetRouteStats(groupKey, routeKey);
            return cache.Get(key);
        }
    }

    public static class CacheKeys
    {
        public static string GetUser(string token)
        {
            return "User-" + token;
        }
        public static string GetSpeed(string connectionString)
        {
            return "webcore.threshold.speed/" + connectionString;
        }
        public static string GetIdle(string connectionString)
        {
            return "webcore.threshold.idle/" + connectionString;
        }
        public static string GetDeviceIdle(string deviceId)
        {
            return "webcore.device.idleStart/" + deviceId;
        }
        public static string GetDeviceLastSpeed(string deviceId)
        {
            return "webcore.device.notification.speed.last/" + deviceId;
        }
        public static string GetIdleLastNotified(string deviceId)
        {
            return "webcore.device.notification.idle.last/" + deviceId;
        }
        public static string GetGCM(string deviceId)
        {
            return "webcore.device.gcm/" + deviceId;
        }
        public static string GetGCMState(string deviceId)
        {
            return "webcore.device.gcm.state/" + deviceId;
        }
        public static string GetDeviceUser(string deviceId)
        {
            return "webcore.device.userInfo/" + deviceId;
        }
        public static string GetClientIdleList(string clientKey, int workerId)
        {
            return "webcore.notifications.idle.distribution/" + clientKey + "/" + workerId.ToString();
        }
        public static string GetClientSpeedList(string clientKey, int workerId)
        {
            return "webcore.notifications.speed.distribution/" + clientKey + "/" + workerId.ToString();
        }
        public static string GetDeviceToken(string deviceId)
        {
            return "webcore.device.token/" + deviceId;
        }
        public static string GetImageRecipientListToken(string clientKey, int workerId)
        {
            return "webcore.notifications.imageList/" + clientKey + "/" + workerId.ToString();
        }
        public static string GetGroupConnectionInfo(string group)
        {
            return "webcore.signalR.group.connectionInfo/" + group;
        }

        //Chat Keys:
        public static string GetUserInGroup(string user, string group)
        {
            return "webcore.chat.userInGroup/" + user + "_" + group;
        }

        public static string GetUserByMembership(string userKey)
        {
            return "webcore.chat.userByMembership/" + userKey;
        }

        public static string GetClientUserByEeId(int eeId, int clientId)
        {
            return String.Format("webcore.chat.clientUser/{0}/{1}", clientId, eeId); 
        }

        public static string GetUsersGCMRegistration(string userKey)
        {
            return "webcore.chat.usersGCMRegistration/" + userKey;
        }

        public static string GetUsersChatClient(string userKey)
        {
            return "webcore.chat.userChatClient/" + userKey;
        }


        //Dashboard :

        public static string GetDashboardObjects(string groupKey)
        {
            return "webcore.dashboard.allObjects/" + groupKey;
        }

        public static string GetRouteStats(string groupKey, int routeHistoryId)
        {
            return String.Format("webcore.dashboard.routes/{0}/{1}", groupKey, routeHistoryId);
        }

    }
}
