using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Flir.Entities
{
    [DataContract]
    public class ConnectedCamera
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int CameraId { get; set; }
        [DataMember]
        public int PowerSupplyId { get; set; }
    }
}
