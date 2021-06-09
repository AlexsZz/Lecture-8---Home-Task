using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8
{
    class Model
    {
        public class Data
        {
            [JsonProperty(PropertyName = "userId")]
            public int userId { get; set; }

            [JsonProperty(PropertyName = "id")]
            public int id { get; set; }

            [JsonProperty(PropertyName = "title")]
            public string title { get; set; }

            [JsonProperty(PropertyName = "body")]
            public string body { get; set; }
        }
    }
}
