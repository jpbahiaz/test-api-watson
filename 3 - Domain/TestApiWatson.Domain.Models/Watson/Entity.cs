using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class Entity
    {
        [DataMember(Name = "entity")]
        public string EntityName { get; set; }
        [DataMember(Name = "location")]
        public int[] Location { get; set; }
        [DataMember(Name = "value")]
        public string Value { get; set; }
        [DataMember(Name = "confidence")]
        public double Confidence { get; set; }
        [DataMember(Name = "metadata")]
        public dynamic Metadata { get; set; }
        [DataMember(Name = "groups")]
        public List<CaptureGroup> CaptureGroups { get; set; }
    }
}
