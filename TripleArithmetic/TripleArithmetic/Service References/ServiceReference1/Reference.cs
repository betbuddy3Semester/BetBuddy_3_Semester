﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripleArithmetic.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ThreeIntClass", Namespace="http://schemas.datacontract.org/2004/07/TripleOfInt")]
    [System.SerializableAttribute()]
    public partial class ThreeIntClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberOneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberThreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberTwoField;
        
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
        public int NumberOne {
            get {
                return this.NumberOneField;
            }
            set {
                if ((this.NumberOneField.Equals(value) != true)) {
                    this.NumberOneField = value;
                    this.RaisePropertyChanged("NumberOne");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumberThree {
            get {
                return this.NumberThreeField;
            }
            set {
                if ((this.NumberThreeField.Equals(value) != true)) {
                    this.NumberThreeField = value;
                    this.RaisePropertyChanged("NumberThree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumberTwo {
            get {
                return this.NumberTwoField;
            }
            set {
                if ((this.NumberTwoField.Equals(value) != true)) {
                    this.NumberTwoField = value;
                    this.RaisePropertyChanged("NumberTwo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MethodThreeIntClass", ReplyAction="http://tempuri.org/IService1/MethodThreeIntClassResponse")]
        TripleArithmetic.ServiceReference1.ThreeIntClass MethodThreeIntClass(TripleArithmetic.ServiceReference1.ThreeIntClass objectOne, TripleArithmetic.ServiceReference1.ThreeIntClass objectTwo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MethodThreeIntClass", ReplyAction="http://tempuri.org/IService1/MethodThreeIntClassResponse")]
        System.Threading.Tasks.Task<TripleArithmetic.ServiceReference1.ThreeIntClass> MethodThreeIntClassAsync(TripleArithmetic.ServiceReference1.ThreeIntClass objectOne, TripleArithmetic.ServiceReference1.ThreeIntClass objectTwo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewTriple", ReplyAction="http://tempuri.org/IService1/NewTripleResponse")]
        TripleArithmetic.ServiceReference1.ThreeIntClass NewTriple(int one, int two, int three);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewTriple", ReplyAction="http://tempuri.org/IService1/NewTripleResponse")]
        System.Threading.Tasks.Task<TripleArithmetic.ServiceReference1.ThreeIntClass> NewTripleAsync(int one, int two, int three);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TripleArithmetic.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TripleArithmetic.ServiceReference1.IService1>, TripleArithmetic.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TripleArithmetic.ServiceReference1.ThreeIntClass MethodThreeIntClass(TripleArithmetic.ServiceReference1.ThreeIntClass objectOne, TripleArithmetic.ServiceReference1.ThreeIntClass objectTwo) {
            return base.Channel.MethodThreeIntClass(objectOne, objectTwo);
        }
        
        public System.Threading.Tasks.Task<TripleArithmetic.ServiceReference1.ThreeIntClass> MethodThreeIntClassAsync(TripleArithmetic.ServiceReference1.ThreeIntClass objectOne, TripleArithmetic.ServiceReference1.ThreeIntClass objectTwo) {
            return base.Channel.MethodThreeIntClassAsync(objectOne, objectTwo);
        }
        
        public TripleArithmetic.ServiceReference1.ThreeIntClass NewTriple(int one, int two, int three) {
            return base.Channel.NewTriple(one, two, three);
        }
        
        public System.Threading.Tasks.Task<TripleArithmetic.ServiceReference1.ThreeIntClass> NewTripleAsync(int one, int two, int three) {
            return base.Channel.NewTripleAsync(one, two, three);
        }
    }
}
