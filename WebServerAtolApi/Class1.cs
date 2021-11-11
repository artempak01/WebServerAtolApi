using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace KKTWebServerApi
{
    static public class KKTWebServerApi
    {
        public static async Task<JObject> queryDeviceInfo(string Path)
        {
            try
            {
                WebRequest request = WebRequest.Create($"http://{Path}:16732/api/v2/operations/queryDeviceInfo?deviceID=default");
                request.Method = "POST";
                request.ContentType = "application/json";
                WebResponse response = await request.GetResponseAsync();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        JObject ResponseString = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(reader.ReadToEnd());
                        response.Close();
                        return ResponseString;
                    }
                }
            }
            catch (System.Exception)
            {
                return null;
            }
        }


        public static JObject queryFnStatus(string Path)
        {
            try
            {
                WebRequest request = WebRequest.Create($"http://{Path}:16732/api/v2/operations/queryFnStatus?deviceID=default");
                request.Method = "POST";
                request.ContentType = "application/json";
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        JObject ResponseString = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(reader.ReadToEnd());

                        response.Close();
                        return ResponseString;
                    }
                }
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public static async Task<JObject> queryFnInfo(string Path)
        {
            try
            {
                WebRequest request = WebRequest.Create($"http://{Path}:16732/api/v2/operations/queryFnInfo?deviceID=default");
                request.Method = "POST";
                request.ContentType = "application/json";
                WebResponse response = await request.GetResponseAsync();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        JObject ResponseString = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(reader.ReadToEnd());

                        response.Close();
                        return ResponseString;
                    }
                }
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public async static Task<JObject> queryOfdExchangeStatus(string Path)
        {
            try
            {
                WebRequest request = WebRequest.Create($"http://{Path}:16732/api/v2/operations//queryOfdExchangeStatus?deviceID=default");
                request.Method = "POST";
                request.ContentType = "application/json";
                WebResponse response = await request.GetResponseAsync();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        JObject ResponseString = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(reader.ReadToEnd());
                        response.Close();
                        return ResponseString;
                    }
                }
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
