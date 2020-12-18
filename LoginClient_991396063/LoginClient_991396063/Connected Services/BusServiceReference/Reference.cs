﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginClient_991396063.BusServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BusInfo", Namespace="http://schemas.datacontract.org/2004/07/FinalBusService_991396063")]
    [System.SerializableAttribute()]
    public partial class BusInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BusIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BusId {
            get {
                return this.BusIdField;
            }
            set {
                if ((this.BusIdField.Equals(value) != true)) {
                    this.BusIdField = value;
                    this.RaisePropertyChanged("BusId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusServiceReference.DBOperationsService")]
    public interface DBOperationsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DBOperationsService/InsertABus", ReplyAction="http://tempuri.org/DBOperationsService/InsertABusResponse")]
        void InsertABus(LoginClient_991396063.BusServiceReference.BusInfo bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DBOperationsService/InsertABus", ReplyAction="http://tempuri.org/DBOperationsService/InsertABusResponse")]
        System.Threading.Tasks.Task InsertABusAsync(LoginClient_991396063.BusServiceReference.BusInfo bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DBOperationsService/RetrieveBusInfo", ReplyAction="http://tempuri.org/DBOperationsService/RetrieveBusInfoResponse")]
        LoginClient_991396063.BusServiceReference.BusInfo[] RetrieveBusInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DBOperationsService/RetrieveBusInfo", ReplyAction="http://tempuri.org/DBOperationsService/RetrieveBusInfoResponse")]
        System.Threading.Tasks.Task<LoginClient_991396063.BusServiceReference.BusInfo[]> RetrieveBusInfoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DBOperationsServiceChannel : LoginClient_991396063.BusServiceReference.DBOperationsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBOperationsServiceClient : System.ServiceModel.ClientBase<LoginClient_991396063.BusServiceReference.DBOperationsService>, LoginClient_991396063.BusServiceReference.DBOperationsService {
        
        public DBOperationsServiceClient() {
        }
        
        public DBOperationsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBOperationsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBOperationsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBOperationsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertABus(LoginClient_991396063.BusServiceReference.BusInfo bus) {
            base.Channel.InsertABus(bus);
        }
        
        public System.Threading.Tasks.Task InsertABusAsync(LoginClient_991396063.BusServiceReference.BusInfo bus) {
            return base.Channel.InsertABusAsync(bus);
        }
        
        public LoginClient_991396063.BusServiceReference.BusInfo[] RetrieveBusInfo() {
            return base.Channel.RetrieveBusInfo();
        }
        
        public System.Threading.Tasks.Task<LoginClient_991396063.BusServiceReference.BusInfo[]> RetrieveBusInfoAsync() {
            return base.Channel.RetrieveBusInfoAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusServiceReference.AuthenticateUserService")]
    public interface AuthenticateUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUserService/AuthenticateUser", ReplyAction="http://tempuri.org/AuthenticateUserService/AuthenticateUserResponse")]
        string AuthenticateUser(string Name, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUserService/AuthenticateUser", ReplyAction="http://tempuri.org/AuthenticateUserService/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<string> AuthenticateUserAsync(string Name, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthenticateUserServiceChannel : LoginClient_991396063.BusServiceReference.AuthenticateUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticateUserServiceClient : System.ServiceModel.ClientBase<LoginClient_991396063.BusServiceReference.AuthenticateUserService>, LoginClient_991396063.BusServiceReference.AuthenticateUserService {
        
        public AuthenticateUserServiceClient() {
        }
        
        public AuthenticateUserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticateUserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateUserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateUserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AuthenticateUser(string Name, string Password) {
            return base.Channel.AuthenticateUser(Name, Password);
        }
        
        public System.Threading.Tasks.Task<string> AuthenticateUserAsync(string Name, string Password) {
            return base.Channel.AuthenticateUserAsync(Name, Password);
        }
    }
}
