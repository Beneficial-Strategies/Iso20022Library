// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.027.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to the CSD to report the status, or a change in status, of a standing instruction request or the status of a standing instruction cancellation request.
/// Usage
/// When this message is used to report the status of a standing instruction request, the building block Standing Instruction Request Identification must be present.
/// When this message is used to report the status of a standing instruction cancellation request, the building block Standing Instruction Cancellation Request Identification must be present.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to the CSD to report the status, or a change in status, of a standing instruction request or the status of a standing instruction cancellation request.|Usage|When this message is used to report the status of a standing instruction request, the building block Standing Instruction Request Identification must be present.|When this message is used to report the status of a standing instruction cancellation request, the building block Standing Instruction Cancellation Request Identification must be present.")]
[IsoId("_TSEvKdEwEd-BzquC8wXy7w_486290785")]
[DisplayName("Agent CA Standing Instruction Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAStandingInstructionStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.027.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAStgInstrStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.027.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AgentCAStandingInstructionStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAStandingInstructionStatusAdviceV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAStandingInstructionRequestIdentification,DocumentIdentification8 reqAgentCAStandingInstructionCancellationRequestIdentification,CorporateActionStandingInstructionGeneralInformation1 reqStandingInstructionGeneralInformation,StandingInstructionStatus1Choice_ reqStandingInstructionRequestStatus,StandingInstructionCancellationStatus1Choice_ reqStandingInstructionCancellationRequestStatus )
    {
        Identification = reqIdentification;
        AgentCAStandingInstructionRequestIdentification = reqAgentCAStandingInstructionRequestIdentification;
        AgentCAStandingInstructionCancellationRequestIdentification = reqAgentCAStandingInstructionCancellationRequestIdentification;
        StandingInstructionGeneralInformation = reqStandingInstructionGeneralInformation;
        StandingInstructionRequestStatus = reqStandingInstructionRequestStatus;
        StandingInstructionCancellationRequestStatus = reqStandingInstructionCancellationRequestStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TSEvKtEwEd-BzquC8wXy7w_4729651")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Standing Instruction Request for which a status is given.
    /// </summary>
    [IsoId("_TSEvK9EwEd-BzquC8wXy7w_45366871")]
    [DisplayName("Agent CA Standing Instruction Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAStgInstrReqId")]
    #endif
    [IsoXmlTag("AgtCAStgInstrReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAStandingInstructionRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAStandingInstructionRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAStandingInstructionRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAStandingInstructionRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Standing Instruction Cancellation Request for which a status is given.|.
    /// </summary>
    [IsoId("_TSEvLNEwEd-BzquC8wXy7w_146031516")]
    [DisplayName("Agent CA Standing Instruction Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAStgInstrCxlReqId")]
    #endif
    [IsoXmlTag("AgtCAStgInstrCxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAStandingInstructionCancellationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAStandingInstructionCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAStandingInstructionCancellationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAStandingInstructionCancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the standing instruction.
    /// </summary>
    [IsoId("_TSN5ENEwEd-BzquC8wXy7w_-1087118100")]
    [DisplayName("Standing Instruction General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgInstrGnlInf")]
    #endif
    [IsoXmlTag("StgInstrGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionStandingInstructionGeneralInformation1 StandingInstructionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionStandingInstructionGeneralInformation1 StandingInstructionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionStandingInstructionGeneralInformation1 StandingInstructionGeneralInformation { get; init; } 
    #else
    public CorporateActionStandingInstructionGeneralInformation1 StandingInstructionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the standing instruction request.
    /// </summary>
    [IsoId("_TSN5EdEwEd-BzquC8wXy7w_-1705435837")]
    [DisplayName("Standing Instruction Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgInstrReqSts")]
    #endif
    [IsoXmlTag("StgInstrReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingInstructionStatus1Choice_ StandingInstructionRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingInstructionStatus1Choice_ StandingInstructionRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingInstructionStatus1Choice_ StandingInstructionRequestStatus { get; init; } 
    #else
    public StandingInstructionStatus1Choice_ StandingInstructionRequestStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the status of a standing instruction cancellation request.
    /// </summary>
    [IsoId("_TSN5EtEwEd-BzquC8wXy7w_-1517034703")]
    [DisplayName("Standing Instruction Cancellation Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgInstrCxlReqSts")]
    #endif
    [IsoXmlTag("StgInstrCxlReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingInstructionCancellationStatus1Choice_ StandingInstructionCancellationRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingInstructionCancellationStatus1Choice_ StandingInstructionCancellationRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingInstructionCancellationStatus1Choice_ StandingInstructionCancellationRequestStatus { get; init; } 
    #else
    public StandingInstructionCancellationStatus1Choice_ StandingInstructionCancellationRequestStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAStandingInstructionStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAStandingInstructionStatusAdviceV01.

