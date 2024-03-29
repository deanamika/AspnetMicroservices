﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public String Name { get; set; }
        public String Category { get; set; }
        public String Description { get; set; }
        public String Summary { get; set; }
        public String ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
