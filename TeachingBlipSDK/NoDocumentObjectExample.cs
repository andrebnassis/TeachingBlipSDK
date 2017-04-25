using Lime.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeachingBlipSDK
{
    [DataContract]
    public class NoDocumentObjectExample : Document
    {
        public NoDocumentObjectExample() : base(MediaType.Parse("application/vnd.teachingblipsdk.example-data+json"))
        {
        }

        public NoDocumentObjectExample(int someIntInput, string someStringInput) : base(MediaType.Parse("application/vnd.teachingblipsdk.example-data+json"))
        {
            PropertyInt = someIntInput;
            PropertyString = someStringInput;
        }
        [DataMember(Name = "propertyint")]
        public int PropertyInt { get; set; }
        [DataMember(Name = "propertystring")]
        public string PropertyString { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

   
}
