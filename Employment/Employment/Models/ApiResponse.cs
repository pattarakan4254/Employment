using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employment.Models
{
    public class ApiResponse
    {
        [JsonProperty(PropertyName = "data")]
        public List<Room> data { get; set; }
    }
    public class Room
    {
        public string room_name { get; set; }
        public override string ToString()
        {
            return room_name;
        }
    }
}
