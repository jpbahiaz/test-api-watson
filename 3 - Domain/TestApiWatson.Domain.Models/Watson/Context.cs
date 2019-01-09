using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class Context
    {
        [DataMember(Name = "conversation_id")]
        public string ConversationId { get; set; }

        [DataMember(Name = "system")]
        public dynamic System { get; set; }

        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }
    }
}
