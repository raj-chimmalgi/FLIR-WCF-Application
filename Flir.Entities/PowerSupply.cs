using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Flir.Entities
{
    [DataContract]
    public class PowerSupply
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ComPort { get; set; }
    }
}
