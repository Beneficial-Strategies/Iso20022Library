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
/// Contains the meta data for netting cut off update request: message identification, request servicer and a request type.
/// </summary>
[IsoId("_CnJABQN1Ee2-vqzwMUAewg")]
[DisplayName("Request Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestData2( System.String reqMessageIdentification,System.String reqRequestType,System.DateOnly reqRequestedActivationDate,PartyIdentification242Choice_ reqNetServiceParticipantIdentification )
    {
        MessageIdentification = reqMessageIdentification;
        RequestType = reqRequestType;
        RequestedActivationDate = reqRequestedActivationDate;
        NetServiceParticipantIdentification = reqNetServiceParticipantIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the message.
    /// </summary>
    [IsoId("_CswfwQN1Ee2-vqzwMUAewg")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the type of request.
    /// </summary>
    [IsoId("_CswfwwN1Ee2-vqzwMUAewg")]
    [DisplayName("Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqTp")]
    #endif
    [IsoXmlTag("ReqTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4Text RequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestType { get; init; } 
    #else
    public System.String RequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the business date on which the new netting cut off(s) is (are) to be activated.
    /// </summary>
    [IsoId("_CswfxQN1Ee2-vqzwMUAewg")]
    [DisplayName("Requested Activation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdActvtnDt")]
    #endif
    [IsoXmlTag("ReqdActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate RequestedActivationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly RequestedActivationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly RequestedActivationDate { get; init; } 
    #else
    public System.DateOnly RequestedActivationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the central system servicing the request.
    /// </summary>
    [IsoId("_CswfxwN1Ee2-vqzwMUAewg")]
    [DisplayName("Request Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqSvcr")]
    #endif
    [IsoXmlTag("ReqSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? RequestServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? RequestServicer { get; init; } 
    #else
    public PartyIdentification242Choice_? RequestServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the participant issuing the request.
    /// </summary>
    [IsoId("_CswfyQN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Participant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetSvcPtcptId")]
    #endif
    [IsoXmlTag("NetSvcPtcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; } 
    #else
    public PartyIdentification242Choice_ NetServiceParticipantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    [IsoId("_CswfywN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetSvcTp")]
    #endif
    [IsoXmlTag("NetSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NetServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NetServiceType { get; init; } 
    #else
    public System.String? NetServiceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
