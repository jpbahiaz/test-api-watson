using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class Intent
    {
        [DataMember(Name = "intent")]
        public string IntentName { get; set; }
        [DataMember(Name = "confidence")]
        public double Confidence { get; set; }
    }
}
