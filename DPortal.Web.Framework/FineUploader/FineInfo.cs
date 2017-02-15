using System;
using Newtonsoft.Json.Linq;

namespace DPortal.Web.Framework.FineUploader
{
    public class FineInfo
    {
        public FineInfo()
        {
        }
        public FineInfo(string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                JToken jObject = JObject.Parse(json);
                id = (string)jObject["id"];
                uuid = (string)jObject["uuid"];
                name = (string)jObject["name"];
                size = (long?)jObject["size"];
                extension = (string)jObject["extension"];
                contenttype = (string)jObject["contenttype"];
                comments = (string)jObject["comments"];
                created = (DateTime?)jObject["created"];
                user_id = (int?)jObject["user_id"];
            }
        }
        public string id { get; set; }
        public string uuid { get; set; }
        public string name { get; set; }
        public long? size { get; set; }
        public string extension { get; set; }
        public string contenttype { get; set; }
        public string thumbnailUrl { get; set; }
        public string comments { get; set; }
        public DateTime? created { get; set; }
        public int? user_id { get; set; }
    }
}
