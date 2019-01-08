using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class ConversaWatson
    {
        [DataMember(Name = "alternate_intents")]
        public bool AlternateIntents { get; set; }

        [DataMember(Name = "intents")]
        public List<Intent> Intents { get; set; }

        [DataMember(Name = "entities")]
        public List<Entity> Entities { get; set; }

        [DataMember(Name = "input")]
        public UserInput Input { get; set; }

        [DataMember(Name = "output")]
        public Output Output { get; set; }

        [DataMember(Name = "context")]
        public Context Context { get; set; }
    }
}
