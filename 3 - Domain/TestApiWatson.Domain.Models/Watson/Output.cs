using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class Output
    {
        [DataMember(Name = "text")]
        public List<string> Text { get; set; }
        [DataMember(Name = "nodes_visited")]
        public List<string> NodesVisited { get; set; }
        [DataMember(Name = "log_messages")]
        public List<dynamic> LogMessages { get; set; }
    }
}
