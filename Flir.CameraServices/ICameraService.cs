using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Flir.Entities;

namespace Flir.CameraServices
{
    [ServiceContract]
    public interface ICameraService
    {
        [OperationContract]
        List<Camera> GetCameras();

        [OperationContract]
        bool ConnectToCamera(int cameraId);

        [OperationContract]
        bool StartStreaming(int cameraId);

        [OperationContract]
        bool StopStreaming(int cameraId);

        [OperationContract]
        bool DisconnectCamera(int cameraId);
    }
}
