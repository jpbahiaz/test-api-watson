using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class Metadata
    {
        [DataMember(Name = "deployment")]
        public string DeploymentId { get; set; }
    }
}
