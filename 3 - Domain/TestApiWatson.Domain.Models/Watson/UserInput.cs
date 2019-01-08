using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class UserInput
    {
        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
