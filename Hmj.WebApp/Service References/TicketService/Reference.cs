﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hmj.WebApp.TicketService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TicketService.VoucherWebServiceSoap")]
    public interface VoucherWebServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 SendSignVoucherByCustIDResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSignVoucherByCustID", ReplyAction="*")]
        Hmj.WebApp.TicketService.SendSignVoucherByCustIDResponse SendSignVoucherByCustID(Hmj.WebApp.TicketService.SendSignVoucherByCustIDRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 fromUserName 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSignVoucherByFromUserName", ReplyAction="*")]
        Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameResponse SendSignVoucherByFromUserName(Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSignVoucherByCustIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSignVoucherByCustID", Namespace="http://tempuri.org/", Order=0)]
        public Hmj.WebApp.TicketService.SendSignVoucherByCustIDRequestBody Body;
        
        public SendSignVoucherByCustIDRequest() {
        }
        
        public SendSignVoucherByCustIDRequest(Hmj.WebApp.TicketService.SendSignVoucherByCustIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSignVoucherByCustIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int custID;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int cardID;
        
        public SendSignVoucherByCustIDRequestBody() {
        }
        
        public SendSignVoucherByCustIDRequestBody(int custID, int cardID) {
            this.custID = custID;
            this.cardID = cardID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSignVoucherByCustIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSignVoucherByCustIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public Hmj.WebApp.TicketService.SendSignVoucherByCustIDResponseBody Body;
        
        public SendSignVoucherByCustIDResponse() {
        }
        
        public SendSignVoucherByCustIDResponse(Hmj.WebApp.TicketService.SendSignVoucherByCustIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSignVoucherByCustIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SendSignVoucherByCustIDResult;
        
        public SendSignVoucherByCustIDResponseBody() {
        }
        
        public SendSignVoucherByCustIDResponseBody(string SendSignVoucherByCustIDResult) {
            this.SendSignVoucherByCustIDResult = SendSignVoucherByCustIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSignVoucherByFromUserNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSignVoucherByFromUserName", Namespace="http://tempuri.org/", Order=0)]
        public Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameRequestBody Body;
        
        public SendSignVoucherByFromUserNameRequest() {
        }
        
        public SendSignVoucherByFromUserNameRequest(Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSignVoucherByFromUserNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fromUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int cardID;
        
        public SendSignVoucherByFromUserNameRequestBody() {
        }
        
        public SendSignVoucherByFromUserNameRequestBody(string fromUserName, int cardID) {
            this.fromUserName = fromUserName;
            this.cardID = cardID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSignVoucherByFromUserNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSignVoucherByFromUserNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameResponseBody Body;
        
        public SendSignVoucherByFromUserNameResponse() {
        }
        
        public SendSignVoucherByFromUserNameResponse(Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSignVoucherByFromUserNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SendSignVoucherByFromUserNameResult;
        
        public SendSignVoucherByFromUserNameResponseBody() {
        }
        
        public SendSignVoucherByFromUserNameResponseBody(string SendSignVoucherByFromUserNameResult) {
            this.SendSignVoucherByFromUserNameResult = SendSignVoucherByFromUserNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VoucherWebServiceSoapChannel : Hmj.WebApp.TicketService.VoucherWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VoucherWebServiceSoapClient : System.ServiceModel.ClientBase<Hmj.WebApp.TicketService.VoucherWebServiceSoap>, Hmj.WebApp.TicketService.VoucherWebServiceSoap {
        
        public VoucherWebServiceSoapClient() {
        }
        
        public VoucherWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VoucherWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VoucherWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VoucherWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hmj.WebApp.TicketService.SendSignVoucherByCustIDResponse Hmj.WebApp.TicketService.VoucherWebServiceSoap.SendSignVoucherByCustID(Hmj.WebApp.TicketService.SendSignVoucherByCustIDRequest request) {
            return base.Channel.SendSignVoucherByCustID(request);
        }
        
        public string SendSignVoucherByCustID(int custID, int cardID) {
            Hmj.WebApp.TicketService.SendSignVoucherByCustIDRequest inValue = new Hmj.WebApp.TicketService.SendSignVoucherByCustIDRequest();
            inValue.Body = new Hmj.WebApp.TicketService.SendSignVoucherByCustIDRequestBody();
            inValue.Body.custID = custID;
            inValue.Body.cardID = cardID;
            Hmj.WebApp.TicketService.SendSignVoucherByCustIDResponse retVal = ((Hmj.WebApp.TicketService.VoucherWebServiceSoap)(this)).SendSignVoucherByCustID(inValue);
            return retVal.Body.SendSignVoucherByCustIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameResponse Hmj.WebApp.TicketService.VoucherWebServiceSoap.SendSignVoucherByFromUserName(Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameRequest request) {
            return base.Channel.SendSignVoucherByFromUserName(request);
        }
        
        public string SendSignVoucherByFromUserName(string fromUserName, int cardID) {
            Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameRequest inValue = new Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameRequest();
            inValue.Body = new Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameRequestBody();
            inValue.Body.fromUserName = fromUserName;
            inValue.Body.cardID = cardID;
            Hmj.WebApp.TicketService.SendSignVoucherByFromUserNameResponse retVal = ((Hmj.WebApp.TicketService.VoucherWebServiceSoap)(this)).SendSignVoucherByFromUserName(inValue);
            return retVal.Body.SendSignVoucherByFromUserNameResult;
        }
    }
}
