using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Collections;
using System.Text.Json;
using System.Collections.Specialized;
using System.Security.Policy;
using System.Net;
using Newtonsoft.Json;
using static Navigator.Storage;

namespace Navigator
{
    public static class HTTPSClient
    {
        static HttpClient client;
        static string user_agent;
        static string urlLogin;
        static string urlGroups;
        static string urlChilds;
        static string urlChild;

        public static void Init()
        {
            client = new HttpClient();
            user_agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:95.0) Gecko/20100101 Firefox/95.0";
            urlLogin = "https://booking.dop29.ru/api/user/login";
            urlGroups = string.Format("https://booking.dop29.ru/api/rest/eventGroups?_dc=1641896017213&page=1&start=0&length={0}&extFilters=[{{\"property\":\"is_deleted\",\"value\":\"0\",\"comparison\":\"eq\"}},{{\"property\":\"event.is_deleted\",\"value\":\"N\",\"comparison\":\"eq\"}}]&format=attendance",
                Settings.MAX_GROUPS_COUNT);
            urlChilds = "https://booking.dop29.ru/api/attendance/members/get?_dc=1641896197594&page=1&start=0&length=50&extFilters=[{{\"property\":\"group_id\",\"value\":\"{0}\"}},{{\"property\":\"academic_year_id\",\"value\":{1}}},{{\"property\":\"dateStart\",\"value\":\"{1}-12-01 00:00:00\"}},{{\"property\":\"dateEnd\",\"value\":\"{1}-12-31 23:59:59\"}}]";
            urlChild = "https://booking.dop29.ru/api/rest/kid/{0}?_dc=1704971612231";
        }

        public static async Task POSTLogin(string username, string password)
        {
            client.DefaultRequestHeaders.UserAgent.Clear();
            client.DefaultRequestHeaders.UserAgent.TryParseAdd(user_agent);

            var payload = new
            {
                email = username,
                password = password
            };

            var json = System.Text.Json.JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(urlLogin, content);
            var responceString = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                root = JsonConvert.DeserializeObject<RootObject>(responceString);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", root.Data.AccessToken);
            }

            await GETGroups();
        }

        public static async Task GETGroups()
        {
            var response = await client.GetAsync(urlGroups);
            var responceString = await response.Content.ReadAsStringAsync();
            GroupsCount groupsCount;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                groupsCount = JsonConvert.DeserializeObject<GroupsCount>(responceString);
                groups.AddRange(groupsCount.Data);
                if (groupsCount.Data.Count < int.Parse(groupsCount.RecordsFiltered))
                {

                    string url = string.Format("https://booking.dop29.ru/api/rest/eventGroups?_dc=1641896017213&page=1&start=0&length={0}&extFilters=[{{\"property\":\"is_deleted\",\"value\":\"0\",\"comparison\":\"eq\"}},{{\"property\":\"event.is_deleted\",\"value\":\"N\",\"comparison\":\"eq\"}}]&format=attendance",
                        Settings.MAX_GROUPS_COUNT, groupsCount.RecordsFiltered);

                    response = await client.GetAsync(url);
                    responceString = await response.Content.ReadAsStringAsync();

                    GroupsCount groupsCount1 = JsonConvert.DeserializeObject<GroupsCount>(responceString);
                    groups.AddRange(groupsCount1.Data);

                }

            }

        }

        public static async Task<List<ChildMember>> GETChilds(string groupId, string year)
        {
            string url = string.Format(urlChilds, groupId, year);
            var response = await client.GetAsync(url);
            var responceString = await response.Content.ReadAsStringAsync();
            MembersGroup membersGroup;
            if(response.StatusCode == HttpStatusCode.OK)
            {
                membersGroup = JsonConvert.DeserializeObject<MembersGroup>(responceString);

                return membersGroup.data;
            }
            return new List<ChildMember>();
        }

        public static async Task<Child> GETChildInfo(string kid_id)
        {
            string url = string.Format(urlChild, kid_id);
            var response = await client.GetAsync(url);
            var responceString = await response.Content.ReadAsStringAsync();
            ChildInfo info;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                info = JsonConvert.DeserializeObject<ChildInfo>(responceString);
                return info.data[0];
            }
            return new Child();
        }
    }
}
        


