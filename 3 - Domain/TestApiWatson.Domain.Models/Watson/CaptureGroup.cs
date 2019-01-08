using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class CaptureGroup
    {
        [DataMember(Name = "group")]
        public string Group { get; set; }
        [DataMember(Name = "location")]
        public int[] Location { get; set; }
    }
}
