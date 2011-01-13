﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caliberweb.Core.USGS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://gisdata.usgs.gov/XMLWebServices2/", ConfigurationName="USGS.Elevation_ServiceSoap")]
    public interface Elevation_ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://gisdata.usgs.gov/XMLWebServices2/getElevation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Xml.XmlNode getElevation(string X_Value, string Y_Value, string Elevation_Units, string Source_Layer, string Elevation_Only);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://gisdata.usgs.gov/XMLWebServices2/getAllElevations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Xml.XmlNode getAllElevations(string X_Value, string Y_Value, string Elevation_Units);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface Elevation_ServiceSoapChannel : Caliberweb.Core.USGS.Elevation_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Elevation_ServiceSoapClient : System.ServiceModel.ClientBase<Caliberweb.Core.USGS.Elevation_ServiceSoap>, Caliberweb.Core.USGS.Elevation_ServiceSoap {
        
        public Elevation_ServiceSoapClient() {
        }
        
        public Elevation_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Elevation_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Elevation_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Elevation_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Xml.XmlNode getElevation(string X_Value, string Y_Value, string Elevation_Units, string Source_Layer, string Elevation_Only) {
            return base.Channel.getElevation(X_Value, Y_Value, Elevation_Units, Source_Layer, Elevation_Only);
        }
        
        public System.Xml.XmlNode getAllElevations(string X_Value, string Y_Value, string Elevation_Units) {
            return base.Channel.getAllElevations(X_Value, Y_Value, Elevation_Units);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://gisdata.usgs.gov/XMLWebServices2/", ConfigurationName="USGS.Elevation_ServiceHttpGet")]
    public interface Elevation_ServiceHttpGet {
        
        [System.ServiceModel.OperationContractAttribute()]
        void getElevation();
        
        [System.ServiceModel.OperationContractAttribute()]
        void getAllElevations();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface Elevation_ServiceHttpGetChannel : Caliberweb.Core.USGS.Elevation_ServiceHttpGet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Elevation_ServiceHttpGetClient : System.ServiceModel.ClientBase<Caliberweb.Core.USGS.Elevation_ServiceHttpGet>, Caliberweb.Core.USGS.Elevation_ServiceHttpGet {
        
        public Elevation_ServiceHttpGetClient() {
        }
        
        public Elevation_ServiceHttpGetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Elevation_ServiceHttpGetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Elevation_ServiceHttpGetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Elevation_ServiceHttpGetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void getElevation() {
            base.Channel.getElevation();
        }
        
        public void getAllElevations() {
            base.Channel.getAllElevations();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://gisdata.usgs.gov/XMLWebServices2/", ConfigurationName="USGS.Elevation_ServiceHttpPost")]
    public interface Elevation_ServiceHttpPost {
        
        [System.ServiceModel.OperationContractAttribute()]
        void getElevation();
        
        [System.ServiceModel.OperationContractAttribute()]
        void getAllElevations();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface Elevation_ServiceHttpPostChannel : Caliberweb.Core.USGS.Elevation_ServiceHttpPost, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Elevation_ServiceHttpPostClient : System.ServiceModel.ClientBase<Caliberweb.Core.USGS.Elevation_ServiceHttpPost>, Caliberweb.Core.USGS.Elevation_ServiceHttpPost {
        
        public Elevation_ServiceHttpPostClient() {
        }
        
        public Elevation_ServiceHttpPostClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Elevation_ServiceHttpPostClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Elevation_ServiceHttpPostClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Elevation_ServiceHttpPostClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void getElevation() {
            base.Channel.getElevation();
        }
        
        public void getAllElevations() {
            base.Channel.getAllElevations();
        }
    }
}