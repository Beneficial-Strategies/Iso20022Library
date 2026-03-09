// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements for the identification of the message and related references.
/// </summary>
[IsoId("_QoQ359p-Ed-ak6NoX_4Aeg_823875605")]
[DisplayName("References")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record References5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a References5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public References5( UseCases1Code reqRequestType,MessageIdentification1 reqMessageIdentification,MessageIdentification1 reqProcessIdentification )
    {
        RequestType = reqRequestType;
        MessageIdentification = reqMessageIdentification;
        ProcessIdentification = reqProcessIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the type of acknowledged request.
    /// </summary>
    [IsoId("_QoQ36Np-Ed-ak6NoX_4Aeg_1346590787")]
    [DisplayName("Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqTp")]
    #endif
    [IsoXmlTag("ReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UseCases1Code RequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UseCases1Code RequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UseCases1Code RequestType { get; init; } 
    #else
    public UseCases1Code RequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_Qoao4Np-Ed-ak6NoX_4Aeg_-1175229632")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_Qoao4dp-Ed-ak6NoX_4Aeg_-790121373")]
    [DisplayName("Process Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcId")]
    #endif
    [IsoXmlTag("PrcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 ProcessIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 ProcessIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 ProcessIdentification { get; init; } 
    #else
    public MessageIdentification1 ProcessIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the message that is acknowledged.
    /// </summary>
    [IsoId("_Qoao4tp-Ed-ak6NoX_4Aeg_-1789477840")]
    [DisplayName("Acknowledged Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckdMsgId")]
    #endif
    [IsoXmlTag("AckdMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? AcknowledgedMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? AcknowledgedMessageIdentification { get; init; } 
    #else
    public MessageIdentification1? AcknowledgedMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the request.
    /// </summary>
    [IsoId("_Qoao49p-Ed-ak6NoX_4Aeg_-17664747")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Status { get; init; } 
    #else
    public System.String? Status { get; set; } 
    #endif
    
    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_Qoao5Np-Ed-ak6NoX_4Aeg_186950521")]
    [DisplayName("Attached Document Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchdDocNm")]
    #endif
    [IsoXmlTag("AttchdDocNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AttachedDocumentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttachedDocumentName { get; init; } 
    #else
    public System.String? AttachedDocumentName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
