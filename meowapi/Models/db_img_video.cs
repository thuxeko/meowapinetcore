using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meowapi.Models
{
    public class db_img_video
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string id_iv { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public int datetime { get; set; }
        public string thumnail { get; set; }
    }
}
