using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintApplication
{
    

    internal class Appearances
    {
        [BsonElement("startDate")]
        public int StartDate { get; set; }

        [BsonElement("endDate")]
        public int EndDate { get; set; }

        [BsonElement("endOfRecursion")]
        public DateTime EndOfRecursion { get; set; }

        public Appearances (int startDate , int endDate , DateTime endofrec) {
           this.StartDate = startDate;
           this.EndDate = endDate;
           this.EndOfRecursion = endofrec;
        }

    }

    
}
