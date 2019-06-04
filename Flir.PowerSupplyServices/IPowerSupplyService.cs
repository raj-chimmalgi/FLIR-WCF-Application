using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Flir.Entities;

namespace Flir.PowerSupplyServices
{
    [ServiceContract]
    public interface IPowerSupplyService
    {
        [OperationContract]
        List<PowerSupply> GetCPowerSupplies();

        [OperationContract]
        float GetVoltage(int powerSupplyId, int cameraId);

        [OperationContract]
        float GetCurrent(int powerSupplyId, int cameraId);

        [OperationContract]
        bool ConnectToPowerSupply(string comPort);

        [OperationContract]
        bool DisconnectPowerSuppy(int powerSupplyId);
    }
}
