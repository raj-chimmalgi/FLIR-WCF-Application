using System;
using System.Diagnostics;
using System.ServiceModel;
using Flir.CameraServices;
using Flir.PowerSupplyServices;


namespace Flir.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost powerSupplyHost = new ServiceHost(typeof(PowerSupplyService));
                ServiceHost cameraHost = new ServiceHost(typeof(CameraService));
                powerSupplyHost.Open();
                cameraHost.Open();
                Console.WriteLine("Hit any key to exit");
                Console.ReadKey();
                powerSupplyHost.Close();
                cameraHost.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
