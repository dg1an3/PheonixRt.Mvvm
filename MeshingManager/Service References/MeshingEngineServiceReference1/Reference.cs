﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PheonixRt.MeshingManagerService.MeshingEngineServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MeshingEngineServiceReference1.IMeshingEngine")]
    public interface IMeshingEngine {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeshingEngine/MeshStructure", ReplyAction="http://tempuri.org/IMeshingEngine/MeshStructureResponse")]
        PheonixRt.MeshingServiceContracts.MeshingResponse MeshStructure(PheonixRt.MeshingServiceContracts.MeshingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeshingEngine/MeshStructure", ReplyAction="http://tempuri.org/IMeshingEngine/MeshStructureResponse")]
        System.Threading.Tasks.Task<PheonixRt.MeshingServiceContracts.MeshingResponse> MeshStructureAsync(PheonixRt.MeshingServiceContracts.MeshingRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMeshingEngineChannel : PheonixRt.MeshingManagerService.MeshingEngineServiceReference1.IMeshingEngine, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MeshingEngineClient : System.ServiceModel.ClientBase<PheonixRt.MeshingManagerService.MeshingEngineServiceReference1.IMeshingEngine>, PheonixRt.MeshingManagerService.MeshingEngineServiceReference1.IMeshingEngine {
        
        public MeshingEngineClient() {
        }
        
        public MeshingEngineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MeshingEngineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeshingEngineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeshingEngineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PheonixRt.MeshingServiceContracts.MeshingResponse MeshStructure(PheonixRt.MeshingServiceContracts.MeshingRequest request) {
            return base.Channel.MeshStructure(request);
        }
        
        public System.Threading.Tasks.Task<PheonixRt.MeshingServiceContracts.MeshingResponse> MeshStructureAsync(PheonixRt.MeshingServiceContracts.MeshingRequest request) {
            return base.Channel.MeshStructureAsync(request);
        }
    }
}
