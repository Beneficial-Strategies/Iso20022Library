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
/// This record is an implementation of the seev.030.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to report the status, or a change in status, of a corporate action deactivation instruction or the status of a deactivation cancellation request.
/// Usage
/// This message is used to provide a status on the deactivation instruction, especially to confirm the deactivation of a Corporate Action event or option.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to report the status, or a change in status, of a corporate action deactivation instruction or the status of a deactivation cancellation request.|Usage|This message is used to provide a status on the deactivation instruction, especially to confirm the deactivation of a Corporate Action event or option.")]
[IsoId("_TMQbDNEwEd-BzquC8wXy7w_622567227")]
[DisplayName("Agent CA Deactivation Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCADeactivationStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.030.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCADeactvtnStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.030.001.01";
    
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
    /// Constructs a AgentCADeactivationStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCADeactivationStatusAdviceV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCADeactivationInstructionIdentification,DocumentIdentification8 reqAgentCADeactivationCancellationRequestIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,CorporateActionDeactivationInstructionStatus1 reqDeactivationInstructionStatus,CorporateActionDeactivationCancellationStatus1Choice_ reqDeactivationCancellationRequestStatus )
    {
        Identification = reqIdentification;
        AgentCADeactivationInstructionIdentification = reqAgentCADeactivationInstructionIdentification;
        AgentCADeactivationCancellationRequestIdentification = reqAgentCADeactivationCancellationRequestIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        DeactivationInstructionStatus = reqDeactivationInstructionStatus;
        DeactivationCancellationRequestStatus = reqDeactivationCancellationRequestStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TMQbDdEwEd-BzquC8wXy7w_-540475327")]
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
    /// Identification of the linked Agent CA Deactivation Instruction for which a status is given.
    /// </summary>
    [IsoId("_TMaMANEwEd-BzquC8wXy7w_-214470974")]
    [DisplayName("Agent CA Deactivation Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCADeactvtnInstrId")]
    #endif
    [IsoXmlTag("AgtCADeactvtnInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Deactivation Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TMaMAdEwEd-BzquC8wXy7w_965193756")]
    [DisplayName("Agent CA Deactivation Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCADeactvtnCxlReqId")]
    #endif
    [IsoXmlTag("AgtCADeactvtnCxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCADeactivationCancellationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCADeactivationCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCADeactivationCancellationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCADeactivationCancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMaMAtEwEd-BzquC8wXy7w_-1294066154")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the deactivation instruction sent by the issuer (agent).
    /// </summary>
    [IsoId("_TMaMA9EwEd-BzquC8wXy7w_861232790")]
    [DisplayName("Deactivation Instruction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeactvtnInstrSts")]
    #endif
    [IsoXmlTag("DeactvtnInstrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDeactivationInstructionStatus1 DeactivationInstructionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDeactivationInstructionStatus1 DeactivationInstructionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDeactivationInstructionStatus1 DeactivationInstructionStatus { get; init; } 
    #else
    public CorporateActionDeactivationInstructionStatus1 DeactivationInstructionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the deactivation cancellation request sent by the issuer (agent).
    /// </summary>
    [IsoId("_TMaMBNEwEd-BzquC8wXy7w_1319300008")]
    [DisplayName("Deactivation Cancellation Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeactvtnCxlReqSts")]
    #endif
    [IsoXmlTag("DeactvtnCxlReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDeactivationCancellationStatus1Choice_ DeactivationCancellationRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDeactivationCancellationStatus1Choice_ DeactivationCancellationRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDeactivationCancellationStatus1Choice_ DeactivationCancellationRequestStatus { get; init; } 
    #else
    public CorporateActionDeactivationCancellationStatus1Choice_ DeactivationCancellationRequestStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCADeactivationStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCADeactivationStatusAdviceV01.

