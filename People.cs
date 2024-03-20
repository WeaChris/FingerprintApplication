using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FingerprintApplication
{
    internal class People
    {
        
        [BsonElement("_id")]
        public ObjectId _id { get; set; }

        [BsonElement("folderName")]
        public string FolderName { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("surname")]
        public string Surname { get; set; }

        [BsonElement("fathers_name")]
        public string FathersName { get; set; }

        [BsonElement("mothers_name")]
        public string MothersName { get; set; }

        [BsonElement("date_ofBirth")]
        public DateTime DateofBirth { get; set; }

        [BsonElement("place_ofBirth")]
        public string PlaceOfBirth { get; set; }

        [BsonElement("place_of_residence")]
        public string PlaceOfResidence { get; set; }

        [BsonElement("diata3i")]
        public string Diata3i { get; set; }

        [BsonElement("when_showup")]
        public Appearances WhenShowup { get; set; }

        [BsonElement("fingerprint_data")]
        public byte[] fingerprint_data { get; set; }

        [BsonElement("appearances")]
        public Object[] appearances { get; set; }

        

        public People(string folderName, string name, string surname, string fathersName, Appearances whenShowup,string mothersName , DateTime dateOfBirth , string placeOfBirth , string placeOfresidence, string diata3i,  byte[] fingerprint_data, Object[] appearances)
        {
            this.FolderName = folderName;
            this.Name = name;
            this.Surname = surname;
            this.FathersName = fathersName;
            this.WhenShowup = whenShowup;
            this.MothersName = mothersName;
            this.DateofBirth = dateOfBirth;
            this.PlaceOfBirth = placeOfBirth;
            this.PlaceOfResidence = placeOfresidence;
            this.Diata3i = diata3i;
            this.fingerprint_data = fingerprint_data;
            this.appearances = appearances;
        }
    }
    
}
