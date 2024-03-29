﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flir.Services.PowerSupplyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PowerSupplyServiceReference.IPowerSupplyService")]
    public interface IPowerSupplyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/GetCPowerSupplies", ReplyAction="http://tempuri.org/IPowerSupplyService/GetCPowerSuppliesResponse")]
        Flir.Entities.PowerSupply[] GetCPowerSupplies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/GetCPowerSupplies", ReplyAction="http://tempuri.org/IPowerSupplyService/GetCPowerSuppliesResponse")]
        System.Threading.Tasks.Task<Flir.Entities.PowerSupply[]> GetCPowerSuppliesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/GetVoltage", ReplyAction="http://tempuri.org/IPowerSupplyService/GetVoltageResponse")]
        float GetVoltage(int powerSupplyId, int cameraId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/GetVoltage", ReplyAction="http://tempuri.org/IPowerSupplyService/GetVoltageResponse")]
        System.Threading.Tasks.Task<float> GetVoltageAsync(int powerSupplyId, int cameraId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/GetCurrent", ReplyAction="http://tempuri.org/IPowerSupplyService/GetCurrentResponse")]
        float GetCurrent(int powerSupplyId, int cameraId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/GetCurrent", ReplyAction="http://tempuri.org/IPowerSupplyService/GetCurrentResponse")]
        System.Threading.Tasks.Task<float> GetCurrentAsync(int powerSupplyId, int cameraId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/ConnectToPowerSupply", ReplyAction="http://tempuri.org/IPowerSupplyService/ConnectToPowerSupplyResponse")]
        bool ConnectToPowerSupply(string comPort);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/ConnectToPowerSupply", ReplyAction="http://tempuri.org/IPowerSupplyService/ConnectToPowerSupplyResponse")]
        System.Threading.Tasks.Task<bool> ConnectToPowerSupplyAsync(string comPort);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/DisconnectPowerSuppy", ReplyAction="http://tempuri.org/IPowerSupplyService/DisconnectPowerSuppyResponse")]
        bool DisconnectPowerSuppy(int powerSupplyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPowerSupplyService/DisconnectPowerSuppy", ReplyAction="http://tempuri.org/IPowerSupplyService/DisconnectPowerSuppyResponse")]
        System.Threading.Tasks.Task<bool> DisconnectPowerSuppyAsync(int powerSupplyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPowerSupplyServiceChannel : Flir.Services.PowerSupplyServiceReference.IPowerSupplyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PowerSupplyServiceClient : System.ServiceModel.ClientBase<Flir.Services.PowerSupplyServiceReference.IPowerSupplyService>, Flir.Services.PowerSupplyServiceReference.IPowerSupplyService {
        
        public PowerSupplyServiceClient() {
        }
        
        public PowerSupplyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PowerSupplyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PowerSupplyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PowerSupplyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Flir.Entities.PowerSupply[] GetCPowerSupplies() {
            return base.Channel.GetCPowerSupplies();
        }
        
        public System.Threading.Tasks.Task<Flir.Entities.PowerSupply[]> GetCPowerSuppliesAsync() {
            return base.Channel.GetCPowerSuppliesAsync();
        }
        
        public float GetVoltage(int powerSupplyId, int cameraId) {
            return base.Channel.GetVoltage(powerSupplyId, cameraId);
        }
        
        public System.Threading.Tasks.Task<float> GetVoltageAsync(int powerSupplyId, int cameraId) {
            return base.Channel.GetVoltageAsync(powerSupplyId, cameraId);
        }
        
        public float GetCurrent(int powerSupplyId, int cameraId) {
            return base.Channel.GetCurrent(powerSupplyId, cameraId);
        }
        
        public System.Threading.Tasks.Task<float> GetCurrentAsync(int powerSupplyId, int cameraId) {
            return base.Channel.GetCurrentAsync(powerSupplyId, cameraId);
        }
        
        public bool ConnectToPowerSupply(string comPort) {
            return base.Channel.ConnectToPowerSupply(comPort);
        }
        
        public System.Threading.Tasks.Task<bool> ConnectToPowerSupplyAsync(string comPort) {
            return base.Channel.ConnectToPowerSupplyAsync(comPort);
        }
        
        public bool DisconnectPowerSuppy(int powerSupplyId) {
            return base.Channel.DisconnectPowerSuppy(powerSupplyId);
        }
        
        public System.Threading.Tasks.Task<bool> DisconnectPowerSuppyAsync(int powerSupplyId) {
            return base.Channel.DisconnectPowerSuppyAsync(powerSupplyId);
        }
    }
}
