//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BisConnectivityServices.BisWebserviceReferences {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CallContext", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class CallContext : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PartitionKeyField;
        
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
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageId {
            get {
                return this.MessageIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageIdField, value) != true)) {
                    this.MessageIdField = value;
                    this.RaisePropertyChanged("MessageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartitionKey {
            get {
                return this.PartitionKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.PartitionKeyField, value) != true)) {
                    this.PartitionKeyField = value;
                    this.RaisePropertyChanged("PartitionKey");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Infolog", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class Infolog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BisConnectivityServices.BisWebserviceReferences.InfologEntry[] EntriesField;
        
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
        public BisConnectivityServices.BisWebserviceReferences.InfologEntry[] Entries {
            get {
                return this.EntriesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntriesField, value) != true)) {
                    this.EntriesField = value;
                    this.RaisePropertyChanged("Entries");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologEntry", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class InfologEntry : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BisConnectivityServices.BisWebserviceReferences.InfologType TypeField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BisConnectivityServices.BisWebserviceReferences.InfologType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologType", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    public enum InfologType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BisConUrlHttpAction", Namespace="http://schemas.datacontract.org/2004/07/Dynamics.AX.Application")]
    public enum BisConUrlHttpAction : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Post = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Put = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Get = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Patch = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Delete = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PostOrPut = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fault", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class Fault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid RequestIdField;
        
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
        public string ExceptionMessage {
            get {
                return this.ExceptionMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionMessageField, value) != true)) {
                    this.ExceptionMessageField = value;
                    this.RaisePropertyChanged("ExceptionMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionType {
            get {
                return this.ExceptionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionTypeField, value) != true)) {
                    this.ExceptionTypeField = value;
                    this.RaisePropertyChanged("ExceptionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid RequestId {
            get {
                return this.RequestIdField;
            }
            set {
                if ((this.RequestIdField.Equals(value) != true)) {
                    this.RequestIdField = value;
                    this.RaisePropertyChanged("RequestId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="BisWebserviceReferences.BisWsWebserviceCall")]
    public interface BisWsWebserviceCall {
        
        // CODEGEN: Generating message contract since message executeOperation has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BisWsWebserviceCall/executeOperation", ReplyAction="http://tempuri.org/BisWsWebserviceCall/executeOperationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BisConnectivityServices.BisWebserviceReferences.Fault), Action="http://tempuri.org/BisWsWebserviceCall/Fault", Name="Fault", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        BisConnectivityServices.BisWebserviceReferences.executeOperationResponse executeOperation(BisConnectivityServices.BisWebserviceReferences.executeOperation request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BisWsWebserviceCall/executeOperation", ReplyAction="http://tempuri.org/BisWsWebserviceCall/executeOperationResponse")]
        System.Threading.Tasks.Task<BisConnectivityServices.BisWebserviceReferences.executeOperationResponse> executeOperationAsync(BisConnectivityServices.BisWebserviceReferences.executeOperation request);
        
        // CODEGEN: Generating message contract since message ping has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BisWsWebserviceCall/ping", ReplyAction="http://tempuri.org/BisWsWebserviceCall/pingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BisConnectivityServices.BisWebserviceReferences.Fault), Action="http://tempuri.org/BisWsWebserviceCall/Fault", Name="Fault", Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        BisConnectivityServices.BisWebserviceReferences.pingResponse ping(BisConnectivityServices.BisWebserviceReferences.ping request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BisWsWebserviceCall/ping", ReplyAction="http://tempuri.org/BisWsWebserviceCall/pingResponse")]
        System.Threading.Tasks.Task<BisConnectivityServices.BisWebserviceReferences.pingResponse> pingAsync(BisConnectivityServices.BisWebserviceReferences.ping request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="executeOperation", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class executeOperation {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public BisConnectivityServices.BisWebserviceReferences.CallContext CallContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=1)]
        public string _ProjectId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=2)]
        public string _Url;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=3)]
        public string _UserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=4)]
        public string _WebServiceId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=5)]
        public string _content;
        
        public executeOperation() {
        }
        
        public executeOperation(BisConnectivityServices.BisWebserviceReferences.CallContext CallContext, BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod, string _ProjectId, string _Url, string _UserName, string _WebServiceId, string _content) {
            this.CallContext = CallContext;
            this._HttpMethod = _HttpMethod;
            this._ProjectId = _ProjectId;
            this._Url = _Url;
            this._UserName = _UserName;
            this._WebServiceId = _WebServiceId;
            this._content = _content;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="executeOperationResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class executeOperationResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public BisConnectivityServices.BisWebserviceReferences.Infolog Infolog;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string result;
        
        public executeOperationResponse() {
        }
        
        public executeOperationResponse(BisConnectivityServices.BisWebserviceReferences.Infolog Infolog, string result) {
            this.Infolog = Infolog;
            this.result = result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ping", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class ping {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public BisConnectivityServices.BisWebserviceReferences.CallContext CallContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=1)]
        public string _ProjectId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=2)]
        public string _WebServiceId;
        
        public ping() {
        }
        
        public ping(BisConnectivityServices.BisWebserviceReferences.CallContext CallContext, BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod, string _ProjectId, string _WebServiceId) {
            this.CallContext = CallContext;
            this._HttpMethod = _HttpMethod;
            this._ProjectId = _ProjectId;
            this._WebServiceId = _WebServiceId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pingResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class pingResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2013/01/datacontracts")]
        public BisConnectivityServices.BisWebserviceReferences.Infolog Infolog;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string result;
        
        public pingResponse() {
        }
        
        public pingResponse(BisConnectivityServices.BisWebserviceReferences.Infolog Infolog, string result) {
            this.Infolog = Infolog;
            this.result = result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BisWsWebserviceCallChannel : BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BisWsWebserviceCallClient : System.ServiceModel.ClientBase<BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall>, BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall {
        
        public BisWsWebserviceCallClient() {
        }
        
        public BisWsWebserviceCallClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BisWsWebserviceCallClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BisWsWebserviceCallClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BisWsWebserviceCallClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BisConnectivityServices.BisWebserviceReferences.executeOperationResponse BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall.executeOperation(BisConnectivityServices.BisWebserviceReferences.executeOperation request) {
            return base.Channel.executeOperation(request);
        }
        
        public BisConnectivityServices.BisWebserviceReferences.Infolog executeOperation(BisConnectivityServices.BisWebserviceReferences.CallContext CallContext, BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod, string _ProjectId, string _Url, string _UserName, string _WebServiceId, string _content, out string result) {
            BisConnectivityServices.BisWebserviceReferences.executeOperation inValue = new BisConnectivityServices.BisWebserviceReferences.executeOperation();
            inValue.CallContext = CallContext;
            inValue._HttpMethod = _HttpMethod;
            inValue._ProjectId = _ProjectId;
            inValue._Url = _Url;
            inValue._UserName = _UserName;
            inValue._WebServiceId = _WebServiceId;
            inValue._content = _content;
            BisConnectivityServices.BisWebserviceReferences.executeOperationResponse retVal = ((BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall)(this)).executeOperation(inValue);
            result = retVal.result;
            return retVal.Infolog;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BisConnectivityServices.BisWebserviceReferences.executeOperationResponse> BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall.executeOperationAsync(BisConnectivityServices.BisWebserviceReferences.executeOperation request) {
            return base.Channel.executeOperationAsync(request);
        }
        
        public System.Threading.Tasks.Task<BisConnectivityServices.BisWebserviceReferences.executeOperationResponse> executeOperationAsync(BisConnectivityServices.BisWebserviceReferences.CallContext CallContext, BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod, string _ProjectId, string _Url, string _UserName, string _WebServiceId, string _content) {
            BisConnectivityServices.BisWebserviceReferences.executeOperation inValue = new BisConnectivityServices.BisWebserviceReferences.executeOperation();
            inValue.CallContext = CallContext;
            inValue._HttpMethod = _HttpMethod;
            inValue._ProjectId = _ProjectId;
            inValue._Url = _Url;
            inValue._UserName = _UserName;
            inValue._WebServiceId = _WebServiceId;
            inValue._content = _content;
            return ((BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall)(this)).executeOperationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BisConnectivityServices.BisWebserviceReferences.pingResponse BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall.ping(BisConnectivityServices.BisWebserviceReferences.ping request) {
            return base.Channel.ping(request);
        }
        
        public BisConnectivityServices.BisWebserviceReferences.Infolog ping(BisConnectivityServices.BisWebserviceReferences.CallContext CallContext, BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod, string _ProjectId, string _WebServiceId, out string result) {
            BisConnectivityServices.BisWebserviceReferences.ping inValue = new BisConnectivityServices.BisWebserviceReferences.ping();
            inValue.CallContext = CallContext;
            inValue._HttpMethod = _HttpMethod;
            inValue._ProjectId = _ProjectId;
            inValue._WebServiceId = _WebServiceId;
            BisConnectivityServices.BisWebserviceReferences.pingResponse retVal = ((BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall)(this)).ping(inValue);
            result = retVal.result;
            return retVal.Infolog;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BisConnectivityServices.BisWebserviceReferences.pingResponse> BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall.pingAsync(BisConnectivityServices.BisWebserviceReferences.ping request) {
            return base.Channel.pingAsync(request);
        }
        
        public System.Threading.Tasks.Task<BisConnectivityServices.BisWebserviceReferences.pingResponse> pingAsync(BisConnectivityServices.BisWebserviceReferences.CallContext CallContext, BisConnectivityServices.BisWebserviceReferences.BisConUrlHttpAction _HttpMethod, string _ProjectId, string _WebServiceId) {
            BisConnectivityServices.BisWebserviceReferences.ping inValue = new BisConnectivityServices.BisWebserviceReferences.ping();
            inValue.CallContext = CallContext;
            inValue._HttpMethod = _HttpMethod;
            inValue._ProjectId = _ProjectId;
            inValue._WebServiceId = _WebServiceId;
            return ((BisConnectivityServices.BisWebserviceReferences.BisWsWebserviceCall)(this)).pingAsync(inValue);
        }
    }
}
