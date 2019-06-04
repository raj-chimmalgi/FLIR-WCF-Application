using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Flir.Entities
{
    [DataContract]
    public class Camera
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool? QcPassed { get; set; }
        [DataMember]
        public DateTime? DateLastTested { get; set; }
    }
}
