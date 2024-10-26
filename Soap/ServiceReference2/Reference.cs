﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://soap/filters", ConfigurationName="FilterPort")]
public interface FilterPort
{
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<getFiltersResponse> getFiltersAsync(getFiltersRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<deleteFilterResponse1> deleteFilterAsync(deleteFilterRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<editFilterResponse1> editFilterAsync(editFilterRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<saveFilterResponse1> saveFilterAsync(saveFilterRequest1 request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap/filters")]
public partial class getFiltersRequest
{
    
    private int userIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int userId
    {
        get
        {
            return this.userIdField;
        }
        set
        {
            this.userIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap/filters")]
public partial class SaveFilterType
{
    
    private int userIdField;
    
    private string nameField;
    
    private string productCodeField;
    
    private System.DateTime startRequestDateField;
    
    private bool startRequestDateFieldSpecified;
    
    private System.DateTime endRequestDateField;
    
    private bool endRequestDateFieldSpecified;
    
    private System.DateTime startReceiptDateField;
    
    private bool startReceiptDateFieldSpecified;
    
    private System.DateTime endReceiptDateField;
    
    private bool endReceiptDateFieldSpecified;
    
    private string statusField;
    
    private string storeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int userId
    {
        get
        {
            return this.userIdField;
        }
        set
        {
            this.userIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string productCode
    {
        get
        {
            return this.productCodeField;
        }
        set
        {
            this.productCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime startRequestDate
    {
        get
        {
            return this.startRequestDateField;
        }
        set
        {
            this.startRequestDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startRequestDateSpecified
    {
        get
        {
            return this.startRequestDateFieldSpecified;
        }
        set
        {
            this.startRequestDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime endRequestDate
    {
        get
        {
            return this.endRequestDateField;
        }
        set
        {
            this.endRequestDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endRequestDateSpecified
    {
        get
        {
            return this.endRequestDateFieldSpecified;
        }
        set
        {
            this.endRequestDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime startReceiptDate
    {
        get
        {
            return this.startReceiptDateField;
        }
        set
        {
            this.startReceiptDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startReceiptDateSpecified
    {
        get
        {
            return this.startReceiptDateFieldSpecified;
        }
        set
        {
            this.startReceiptDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime endReceiptDate
    {
        get
        {
            return this.endReceiptDateField;
        }
        set
        {
            this.endReceiptDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endReceiptDateSpecified
    {
        get
        {
            return this.endReceiptDateFieldSpecified;
        }
        set
        {
            this.endReceiptDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string store
    {
        get
        {
            return this.storeField;
        }
        set
        {
            this.storeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap/filters")]
public partial class EditFilterType
{
    
    private int idField;
    
    private string nameField;
    
    private string productCodeField;
    
    private System.DateTime startRequestDateField;
    
    private bool startRequestDateFieldSpecified;
    
    private System.DateTime endRequestDateField;
    
    private bool endRequestDateFieldSpecified;
    
    private System.DateTime startReceiptDateField;
    
    private bool startReceiptDateFieldSpecified;
    
    private System.DateTime endReceiptDateField;
    
    private bool endReceiptDateFieldSpecified;
    
    private string statusField;
    
    private string storeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string productCode
    {
        get
        {
            return this.productCodeField;
        }
        set
        {
            this.productCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime startRequestDate
    {
        get
        {
            return this.startRequestDateField;
        }
        set
        {
            this.startRequestDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startRequestDateSpecified
    {
        get
        {
            return this.startRequestDateFieldSpecified;
        }
        set
        {
            this.startRequestDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime endRequestDate
    {
        get
        {
            return this.endRequestDateField;
        }
        set
        {
            this.endRequestDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endRequestDateSpecified
    {
        get
        {
            return this.endRequestDateFieldSpecified;
        }
        set
        {
            this.endRequestDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime startReceiptDate
    {
        get
        {
            return this.startReceiptDateField;
        }
        set
        {
            this.startReceiptDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startReceiptDateSpecified
    {
        get
        {
            return this.startReceiptDateFieldSpecified;
        }
        set
        {
            this.startReceiptDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime endReceiptDate
    {
        get
        {
            return this.endReceiptDateField;
        }
        set
        {
            this.endReceiptDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endReceiptDateSpecified
    {
        get
        {
            return this.endReceiptDateFieldSpecified;
        }
        set
        {
            this.endReceiptDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string store
    {
        get
        {
            return this.storeField;
        }
        set
        {
            this.storeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap/filters")]
public partial class FilterSoap
{
    
    private int idField;
    
    private string nameField;
    
    private string productCodeField;
    
    private System.DateTime startRequestDateField;
    
    private bool startRequestDateFieldSpecified;
    
    private System.DateTime endRequestDateField;
    
    private bool endRequestDateFieldSpecified;
    
    private System.DateTime startReceiptDateField;
    
    private bool startReceiptDateFieldSpecified;
    
    private System.DateTime endReceiptDateField;
    
    private bool endReceiptDateFieldSpecified;
    
    private string statusField;
    
    private string storeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string productCode
    {
        get
        {
            return this.productCodeField;
        }
        set
        {
            this.productCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime startRequestDate
    {
        get
        {
            return this.startRequestDateField;
        }
        set
        {
            this.startRequestDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startRequestDateSpecified
    {
        get
        {
            return this.startRequestDateFieldSpecified;
        }
        set
        {
            this.startRequestDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime endRequestDate
    {
        get
        {
            return this.endRequestDateField;
        }
        set
        {
            this.endRequestDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endRequestDateSpecified
    {
        get
        {
            return this.endRequestDateFieldSpecified;
        }
        set
        {
            this.endRequestDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime startReceiptDate
    {
        get
        {
            return this.startReceiptDateField;
        }
        set
        {
            this.startReceiptDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startReceiptDateSpecified
    {
        get
        {
            return this.startReceiptDateFieldSpecified;
        }
        set
        {
            this.startReceiptDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime endReceiptDate
    {
        get
        {
            return this.endReceiptDateField;
        }
        set
        {
            this.endReceiptDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endReceiptDateSpecified
    {
        get
        {
            return this.endReceiptDateFieldSpecified;
        }
        set
        {
            this.endReceiptDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string store
    {
        get
        {
            return this.storeField;
        }
        set
        {
            this.storeField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getFiltersRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap/filters", Order=0)]
    public getFiltersRequest getFiltersRequest;
    
    public getFiltersRequest1()
    {
    }
    
    public getFiltersRequest1(getFiltersRequest getFiltersRequest)
    {
        this.getFiltersRequest = getFiltersRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getFiltersResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="getFiltersResponse", Namespace="http://soap/filters", Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("filters", IsNullable=false)]
    public FilterSoap[] getFiltersResponse1;
    
    public getFiltersResponse()
    {
    }
    
    public getFiltersResponse(FilterSoap[] getFiltersResponse1)
    {
        this.getFiltersResponse1 = getFiltersResponse1;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap/filters")]
public partial class deleteFilterRequest
{
    
    private int idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap/filters")]
public partial class deleteFilterResponse
{
    
    private bool successField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public bool success
    {
        get
        {
            return this.successField;
        }
        set
        {
            this.successField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class deleteFilterRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap/filters", Order=0)]
    public deleteFilterRequest deleteFilterRequest;
    
    public deleteFilterRequest1()
    {
    }
    
    public deleteFilterRequest1(deleteFilterRequest deleteFilterRequest)
    {
        this.deleteFilterRequest = deleteFilterRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class deleteFilterResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap/filters", Order=0)]
    public deleteFilterResponse deleteFilterResponse;
    
    public deleteFilterResponse1()
    {
    }
    
    public deleteFilterResponse1(deleteFilterResponse deleteFilterResponse)
    {
        this.deleteFilterResponse = deleteFilterResponse;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap/filters")]
public partial class editFilterRequest
{
    
    private EditFilterType filterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public EditFilterType filter
    {
        get
        {
            return this.filterField;
        }
        set
        {
            this.filterField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap/filters")]
public partial class editFilterResponse
{
    
    private FilterSoap filterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public FilterSoap filter
    {
        get
        {
            return this.filterField;
        }
        set
        {
            this.filterField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class editFilterRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap/filters", Order=0)]
    public editFilterRequest editFilterRequest;
    
    public editFilterRequest1()
    {
    }
    
    public editFilterRequest1(editFilterRequest editFilterRequest)
    {
        this.editFilterRequest = editFilterRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class editFilterResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap/filters", Order=0)]
    public editFilterResponse editFilterResponse;
    
    public editFilterResponse1()
    {
    }
    
    public editFilterResponse1(editFilterResponse editFilterResponse)
    {
        this.editFilterResponse = editFilterResponse;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap/filters")]
public partial class saveFilterRequest
{
    
    private SaveFilterType filterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public SaveFilterType filter
    {
        get
        {
            return this.filterField;
        }
        set
        {
            this.filterField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap/filters")]
public partial class saveFilterResponse
{
    
    private FilterSoap filterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public FilterSoap filter
    {
        get
        {
            return this.filterField;
        }
        set
        {
            this.filterField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class saveFilterRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap/filters", Order=0)]
    public saveFilterRequest saveFilterRequest;
    
    public saveFilterRequest1()
    {
    }
    
    public saveFilterRequest1(saveFilterRequest saveFilterRequest)
    {
        this.saveFilterRequest = saveFilterRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class saveFilterResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap/filters", Order=0)]
    public saveFilterResponse saveFilterResponse;
    
    public saveFilterResponse1()
    {
    }
    
    public saveFilterResponse1(saveFilterResponse saveFilterResponse)
    {
        this.saveFilterResponse = saveFilterResponse;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
public interface FilterPortChannel : FilterPort, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
public partial class FilterPortClient : System.ServiceModel.ClientBase<FilterPort>, FilterPort
{
    
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
    
    public FilterPortClient() : 
            base(FilterPortClient.GetDefaultBinding(), FilterPortClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.FilterPortSoap11.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public FilterPortClient(EndpointConfiguration endpointConfiguration) : 
            base(FilterPortClient.GetBindingForEndpoint(endpointConfiguration), FilterPortClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public FilterPortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
            base(FilterPortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public FilterPortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(FilterPortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public FilterPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getFiltersResponse> FilterPort.getFiltersAsync(getFiltersRequest1 request)
    {
        return base.Channel.getFiltersAsync(request);
    }
    
    public System.Threading.Tasks.Task<getFiltersResponse> getFiltersAsync(getFiltersRequest getFiltersRequest)
    {
        getFiltersRequest1 inValue = new getFiltersRequest1();
        inValue.getFiltersRequest = getFiltersRequest;
        return ((FilterPort)(this)).getFiltersAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<deleteFilterResponse1> FilterPort.deleteFilterAsync(deleteFilterRequest1 request)
    {
        return base.Channel.deleteFilterAsync(request);
    }
    
    public System.Threading.Tasks.Task<deleteFilterResponse1> deleteFilterAsync(deleteFilterRequest deleteFilterRequest)
    {
        deleteFilterRequest1 inValue = new deleteFilterRequest1();
        inValue.deleteFilterRequest = deleteFilterRequest;
        return ((FilterPort)(this)).deleteFilterAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<editFilterResponse1> FilterPort.editFilterAsync(editFilterRequest1 request)
    {
        return base.Channel.editFilterAsync(request);
    }
    
    public System.Threading.Tasks.Task<editFilterResponse1> editFilterAsync(editFilterRequest editFilterRequest)
    {
        editFilterRequest1 inValue = new editFilterRequest1();
        inValue.editFilterRequest = editFilterRequest;
        return ((FilterPort)(this)).editFilterAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<saveFilterResponse1> FilterPort.saveFilterAsync(saveFilterRequest1 request)
    {
        return base.Channel.saveFilterAsync(request);
    }
    
    public System.Threading.Tasks.Task<saveFilterResponse1> saveFilterAsync(saveFilterRequest saveFilterRequest)
    {
        saveFilterRequest1 inValue = new saveFilterRequest1();
        inValue.saveFilterRequest = saveFilterRequest;
        return ((FilterPort)(this)).saveFilterAsync(inValue);
    }
    
    public virtual System.Threading.Tasks.Task OpenAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
    }
    
    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.FilterPortSoap11))
        {
            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
            result.MaxBufferSize = int.MaxValue;
            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            result.MaxReceivedMessageSize = int.MaxValue;
            result.AllowCookies = true;
            return result;
        }
        throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
    }
    
    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.FilterPortSoap11))
        {
            return new System.ServiceModel.EndpointAddress("http://localhost:8080/ws/*");
        }
        throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
    }
    
    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return FilterPortClient.GetBindingForEndpoint(EndpointConfiguration.FilterPortSoap11);
    }
    
    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return FilterPortClient.GetEndpointAddress(EndpointConfiguration.FilterPortSoap11);
    }
    
    public enum EndpointConfiguration
    {
        
        FilterPortSoap11,
    }
}