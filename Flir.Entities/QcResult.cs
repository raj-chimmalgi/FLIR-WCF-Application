using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Flir.Entities
{
    [DataContract]
    public class QcResult
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int CameraId { get; set; }
        [DataMember]
        public int PowerSupplyId { get; set; }
        [DataMember]
        public bool QcPassed { get; set; }
        [DataMember]
        public DateTime DateTested { get; set; }
    }
}
