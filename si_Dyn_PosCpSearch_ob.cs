﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8922
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://jahwa.com/pos/crm", ConfigurationName="si_Dyn_PosCpSearch_ob")]
public interface si_Dyn_PosCpSearch_ob
{
    
    // CODEGEN: 操作 si_PosCpSearch_ob 以后生成的消息协定不是 RPC，也不是换行文档。
    [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    si_PosCpSearch_obResponse si_PosCpSearch_ob(si_PosCpSearch_obRequest request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jahwa.com/pos/crm")]
public partial class dt_Dyn_PosCpSearch_req
{
    
    private string aCCOUNT_IDField;
    
    private string mOB_NUMBERField;
    
    private string dATA_SOURCEField;
    
    private string vGROUPField;
    
    private string sOURCE_SYSTEMField;
    
    private string lOYALTY_BRANDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public string ACCOUNT_ID
    {
        get
        {
            return this.aCCOUNT_IDField;
        }
        set
        {
            this.aCCOUNT_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string MOB_NUMBER
    {
        get
        {
            return this.mOB_NUMBERField;
        }
        set
        {
            this.mOB_NUMBERField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
    public string DATA_SOURCE
    {
        get
        {
            return this.dATA_SOURCEField;
        }
        set
        {
            this.dATA_SOURCEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
    public string VGROUP
    {
        get
        {
            return this.vGROUPField;
        }
        set
        {
            this.vGROUPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
    public string SOURCE_SYSTEM
    {
        get
        {
            return this.sOURCE_SYSTEMField;
        }
        set
        {
            this.sOURCE_SYSTEMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
    public string LOYALTY_BRAND
    {
        get
        {
            return this.lOYALTY_BRANDField;
        }
        set
        {
            this.lOYALTY_BRANDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jahwa.com/pos/crm")]
public partial class ZPARTERN_CP2
{
    
    private string bPEXTField;
    
    private string zCP_TYPEField;
    
    private string zCP_NUMField;
    
    private string zCP_PASSWField;
    
    private string zCP_USE_FLAGField;
    
    private System.DateTime zCPUDATEField;
    
    private bool zCPUDATEFieldSpecified;
    
    private System.DateTime zCPSDATEField;
    
    private bool zCPSDATEFieldSpecified;
    
    private string wB_ORDER_IDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public string BPEXT
    {
        get
        {
            return this.bPEXTField;
        }
        set
        {
            this.bPEXTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string ZCP_TYPE
    {
        get
        {
            return this.zCP_TYPEField;
        }
        set
        {
            this.zCP_TYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
    public string ZCP_NUM
    {
        get
        {
            return this.zCP_NUMField;
        }
        set
        {
            this.zCP_NUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
    public string ZCP_PASSW
    {
        get
        {
            return this.zCP_PASSWField;
        }
        set
        {
            this.zCP_PASSWField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
    public string ZCP_USE_FLAG
    {
        get
        {
            return this.zCP_USE_FLAGField;
        }
        set
        {
            this.zCP_USE_FLAGField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
    public System.DateTime ZCPUDATE
    {
        get
        {
            return this.zCPUDATEField;
        }
        set
        {
            this.zCPUDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ZCPUDATESpecified
    {
        get
        {
            return this.zCPUDATEFieldSpecified;
        }
        set
        {
            this.zCPUDATEFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
    public System.DateTime ZCPSDATE
    {
        get
        {
            return this.zCPSDATEField;
        }
        set
        {
            this.zCPSDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ZCPSDATESpecified
    {
        get
        {
            return this.zCPSDATEFieldSpecified;
        }
        set
        {
            this.zCPSDATEFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
    public string WB_ORDER_ID
    {
        get
        {
            return this.wB_ORDER_IDField;
        }
        set
        {
            this.wB_ORDER_IDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jahwa.com/pos/crm")]
public partial class ZPARTERN_CP1
{
    
    private string bPEXTField;
    
    private string zCP_TYPEField;
    
    private string tOTALField;
    
    private string tOTAL_YSYField;
    
    private string tOTAL_WSYField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public string BPEXT
    {
        get
        {
            return this.bPEXTField;
        }
        set
        {
            this.bPEXTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string ZCP_TYPE
    {
        get
        {
            return this.zCP_TYPEField;
        }
        set
        {
            this.zCP_TYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
    public string TOTAL
    {
        get
        {
            return this.tOTALField;
        }
        set
        {
            this.tOTALField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
    public string TOTAL_YSY
    {
        get
        {
            return this.tOTAL_YSYField;
        }
        set
        {
            this.tOTAL_YSYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
    public string TOTAL_WSY
    {
        get
        {
            return this.tOTAL_WSYField;
        }
        set
        {
            this.tOTAL_WSYField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jahwa.com/pos/crm")]
public partial class dt_Dyn_PosCpSearch_res
{
    
    private string zTYPEField;
    
    private string mESSAGEField;
    
    private ZPARTERN_CP1[] zPARTERN_CP1Field;
    
    private ZPARTERN_CP2[] zPARTERN_CP2Field;
    
    private dt_Dyn_PosCpSearch_resITEM[] zCPQ_RESULTField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public string ZTYPE
    {
        get
        {
            return this.zTYPEField;
        }
        set
        {
            this.zTYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string MESSAGE
    {
        get
        {
            return this.mESSAGEField;
        }
        set
        {
            this.mESSAGEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ITEM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public ZPARTERN_CP1[] ZPARTERN_CP1
    {
        get
        {
            return this.zPARTERN_CP1Field;
        }
        set
        {
            this.zPARTERN_CP1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ITEM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public ZPARTERN_CP2[] ZPARTERN_CP2
    {
        get
        {
            return this.zPARTERN_CP2Field;
        }
        set
        {
            this.zPARTERN_CP2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ITEM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public dt_Dyn_PosCpSearch_resITEM[] ZCPQ_RESULT
    {
        get
        {
            return this.zCPQ_RESULTField;
        }
        set
        {
            this.zCPQ_RESULTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://jahwa.com/pos/crm")]
public partial class dt_Dyn_PosCpSearch_resITEM
{
    
    private string eXTERNAL_IDField;
    
    private string aCCOUNT_IDField;
    
    private string tEXT1Field;
    
    private string zCP_YHQField;
    
    private string zCP_NUMField;
    
    private string zCP_YHQDESField;
    
    private string cONTENTField;
    
    private string rULEField;
    
    private string zCP_TYPEField;
    
    private string zCP_PASSWField;
    
    private System.DateTime zCP_BDATEField;
    
    private bool zCP_BDATEFieldSpecified;
    
    private System.DateTime zCP_EDATEField;
    
    private bool zCP_EDATEFieldSpecified;
    
    private string zCP_JEField;
    
    private string zCP_ZKField;
    
    private string zCP_POINTField;
    
    private string zCP_PRODField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public string EXTERNAL_ID
    {
        get
        {
            return this.eXTERNAL_IDField;
        }
        set
        {
            this.eXTERNAL_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string ACCOUNT_ID
    {
        get
        {
            return this.aCCOUNT_IDField;
        }
        set
        {
            this.aCCOUNT_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
    public string TEXT1
    {
        get
        {
            return this.tEXT1Field;
        }
        set
        {
            this.tEXT1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
    public string ZCP_YHQ
    {
        get
        {
            return this.zCP_YHQField;
        }
        set
        {
            this.zCP_YHQField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
    public string ZCP_NUM
    {
        get
        {
            return this.zCP_NUMField;
        }
        set
        {
            this.zCP_NUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
    public string ZCP_YHQDES
    {
        get
        {
            return this.zCP_YHQDESField;
        }
        set
        {
            this.zCP_YHQDESField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
    public string CONTENT
    {
        get
        {
            return this.cONTENTField;
        }
        set
        {
            this.cONTENTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
    public string RULE
    {
        get
        {
            return this.rULEField;
        }
        set
        {
            this.rULEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
    public string ZCP_TYPE
    {
        get
        {
            return this.zCP_TYPEField;
        }
        set
        {
            this.zCP_TYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
    public string ZCP_PASSW
    {
        get
        {
            return this.zCP_PASSWField;
        }
        set
        {
            this.zCP_PASSWField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
    public System.DateTime ZCP_BDATE
    {
        get
        {
            return this.zCP_BDATEField;
        }
        set
        {
            this.zCP_BDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ZCP_BDATESpecified
    {
        get
        {
            return this.zCP_BDATEFieldSpecified;
        }
        set
        {
            this.zCP_BDATEFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
    public System.DateTime ZCP_EDATE
    {
        get
        {
            return this.zCP_EDATEField;
        }
        set
        {
            this.zCP_EDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ZCP_EDATESpecified
    {
        get
        {
            return this.zCP_EDATEFieldSpecified;
        }
        set
        {
            this.zCP_EDATEFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
    public string ZCP_JE
    {
        get
        {
            return this.zCP_JEField;
        }
        set
        {
            this.zCP_JEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
    public string ZCP_ZK
    {
        get
        {
            return this.zCP_ZKField;
        }
        set
        {
            this.zCP_ZKField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
    public string ZCP_POINT
    {
        get
        {
            return this.zCP_POINTField;
        }
        set
        {
            this.zCP_POINTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
    public string ZCP_PROD
    {
        get
        {
            return this.zCP_PRODField;
        }
        set
        {
            this.zCP_PRODField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class si_PosCpSearch_obRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jahwa.com/pos/crm", Order=0)]
    public dt_Dyn_PosCpSearch_req mt_Dyn_PosCpSearch_req;
    
    public si_PosCpSearch_obRequest()
    {
    }
    
    public si_PosCpSearch_obRequest(dt_Dyn_PosCpSearch_req mt_Dyn_PosCpSearch_req)
    {
        this.mt_Dyn_PosCpSearch_req = mt_Dyn_PosCpSearch_req;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class si_PosCpSearch_obResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jahwa.com/pos/crm", Order=0)]
    public dt_Dyn_PosCpSearch_res mt_Dyn_PosCpSearch_res;
    
    public si_PosCpSearch_obResponse()
    {
    }
    
    public si_PosCpSearch_obResponse(dt_Dyn_PosCpSearch_res mt_Dyn_PosCpSearch_res)
    {
        this.mt_Dyn_PosCpSearch_res = mt_Dyn_PosCpSearch_res;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface si_Dyn_PosCpSearch_obChannel : si_Dyn_PosCpSearch_ob, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class si_Dyn_PosCpSearch_obClient : System.ServiceModel.ClientBase<si_Dyn_PosCpSearch_ob>, si_Dyn_PosCpSearch_ob
{
    
    public si_Dyn_PosCpSearch_obClient()
    {
    }
    
    public si_Dyn_PosCpSearch_obClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public si_Dyn_PosCpSearch_obClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public si_Dyn_PosCpSearch_obClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public si_Dyn_PosCpSearch_obClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    si_PosCpSearch_obResponse si_Dyn_PosCpSearch_ob.si_PosCpSearch_ob(si_PosCpSearch_obRequest request)
    {
        return base.Channel.si_PosCpSearch_ob(request);
    }
    
    public dt_Dyn_PosCpSearch_res si_PosCpSearch_ob(dt_Dyn_PosCpSearch_req mt_Dyn_PosCpSearch_req)
    {
        si_PosCpSearch_obRequest inValue = new si_PosCpSearch_obRequest();
        inValue.mt_Dyn_PosCpSearch_req = mt_Dyn_PosCpSearch_req;
        si_PosCpSearch_obResponse retVal = ((si_Dyn_PosCpSearch_ob)(this)).si_PosCpSearch_ob(inValue);
        return retVal.mt_Dyn_PosCpSearch_res;
    }
}