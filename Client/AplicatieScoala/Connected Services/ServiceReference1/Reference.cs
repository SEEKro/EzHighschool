﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicatieScoala.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getPassword(string functie, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPassword", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getPasswordAsync(string functie, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPersonalInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getPersonalInfo(string functie, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPersonalInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getPersonalInfoAsync(string functie, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getGrades", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getGrades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getGrades", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getGradesAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (With_x0020_parametter) of message With_x0020_parametter does not match the default value (getGrades1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/With parametter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AplicatieScoala.ServiceReference1.Withparametter1 getGrades1(AplicatieScoala.ServiceReference1.Withparametter request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/With parametter", ReplyAction="*")]
        System.Threading.Tasks.Task<AplicatieScoala.ServiceReference1.Withparametter1> getGrades1Async(AplicatieScoala.ServiceReference1.Withparametter request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAbsenteByUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getAbsenteByUser(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAbsenteByUser", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getAbsenteByUserAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertGrade", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertGrade(string user_profesor, string user_elev, int id_materie, int nota, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertGrade", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertGradeAsync(string user_profesor, string user_elev, int id_materie, int nota, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertAbsenta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertAbsenta(string user_elev, int id_materie, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertAbsenta", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertAbsentaAsync(string user_elev, int id_materie, string data);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="With parametter", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Withparametter {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string user;
        
        public Withparametter() {
        }
        
        public Withparametter(string user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="With parametterResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Withparametter1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("With parametterResult")]
        public System.Data.DataSet WithparametterResult;
        
        public Withparametter1() {
        }
        
        public Withparametter1(System.Data.DataSet WithparametterResult) {
            this.WithparametterResult = WithparametterResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : AplicatieScoala.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<AplicatieScoala.ServiceReference1.WebServiceSoap>, AplicatieScoala.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet getPassword(string functie, string user) {
            return base.Channel.getPassword(functie, user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getPasswordAsync(string functie, string user) {
            return base.Channel.getPasswordAsync(functie, user);
        }
        
        public System.Data.DataSet getPersonalInfo(string functie, string user) {
            return base.Channel.getPersonalInfo(functie, user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getPersonalInfoAsync(string functie, string user) {
            return base.Channel.getPersonalInfoAsync(functie, user);
        }
        
        public System.Data.DataSet getGrades() {
            return base.Channel.getGrades();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getGradesAsync() {
            return base.Channel.getGradesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AplicatieScoala.ServiceReference1.Withparametter1 AplicatieScoala.ServiceReference1.WebServiceSoap.getGrades1(AplicatieScoala.ServiceReference1.Withparametter request) {
            return base.Channel.getGrades1(request);
        }
        
        public System.Data.DataSet getGrades1(string user) {
            AplicatieScoala.ServiceReference1.Withparametter inValue = new AplicatieScoala.ServiceReference1.Withparametter();
            inValue.user = user;
            AplicatieScoala.ServiceReference1.Withparametter1 retVal = ((AplicatieScoala.ServiceReference1.WebServiceSoap)(this)).getGrades1(inValue);
            return retVal.WithparametterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AplicatieScoala.ServiceReference1.Withparametter1> AplicatieScoala.ServiceReference1.WebServiceSoap.getGrades1Async(AplicatieScoala.ServiceReference1.Withparametter request) {
            return base.Channel.getGrades1Async(request);
        }
        
        public System.Threading.Tasks.Task<AplicatieScoala.ServiceReference1.Withparametter1> getGrades1Async(string user) {
            AplicatieScoala.ServiceReference1.Withparametter inValue = new AplicatieScoala.ServiceReference1.Withparametter();
            inValue.user = user;
            return ((AplicatieScoala.ServiceReference1.WebServiceSoap)(this)).getGrades1Async(inValue);
        }
        
        public System.Data.DataSet getAbsenteByUser(string user) {
            return base.Channel.getAbsenteByUser(user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getAbsenteByUserAsync(string user) {
            return base.Channel.getAbsenteByUserAsync(user);
        }
        
        public int insertGrade(string user_profesor, string user_elev, int id_materie, int nota, string data) {
            return base.Channel.insertGrade(user_profesor, user_elev, id_materie, nota, data);
        }
        
        public System.Threading.Tasks.Task<int> insertGradeAsync(string user_profesor, string user_elev, int id_materie, int nota, string data) {
            return base.Channel.insertGradeAsync(user_profesor, user_elev, id_materie, nota, data);
        }
        
        public int insertAbsenta(string user_elev, int id_materie, string data) {
            return base.Channel.insertAbsenta(user_elev, id_materie, data);
        }
        
        public System.Threading.Tasks.Task<int> insertAbsentaAsync(string user_elev, int id_materie, string data) {
            return base.Channel.insertAbsentaAsync(user_elev, id_materie, data);
        }
    }
}