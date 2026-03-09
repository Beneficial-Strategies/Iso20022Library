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
/// This record is an implementation of the seev.022.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to report the status, or a change in status, of
/// - a global distribution status advice released by an issuer (or its agent);
/// - a movement instruction released by an issuer (or its agent);
/// - a movement cancellation request sent by the issuer (or its agent); and
/// - the non-settlement of the movements at the CSD.
/// Usage
/// This message is used to report the status of:
/// - the movements resulting from a movement instruction message, in which case, the Agent Corporate Action Movement Instruction Identification must be present;
/// - the movements resulting from a global distribution status advice message (with the status, authorised), in which case, the Agent Corporate Action Global Distribution Status Advice Identification must be present;
/// - the movement cancellation request, in which case, the Agent Corporate Action Movement Cancellation Request Identification must be present; and
/// - the movements resulting from an election status advice (if the status of the election advice is rejected or if the status of the election cancellation request or amendment request is accepted) in case there is a settlement problem. The Election Status Advice Identification must be present.
/// In the case of a failed settlement, the message contains details of the movement, such as account details, securities or cash information and the reason of the failure.
/// This message should not be used to provide the confirmation of the settlement; the Agent Corporate Action Movement Confirmation message should be used instead.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to report the status, or a change in status, of|- a global distribution status advice released by an issuer (or its agent);|- a movement instruction released by an issuer (or its agent);|- a movement cancellation request sent by the issuer (or its agent); and|- the non-settlement of the movements at the CSD.|Usage|This message is used to report the status of:|- the movements resulting from a movement instruction message, in which case, the Agent Corporate Action Movement Instruction Identification must be present;|- the movements resulting from a global distribution status advice message (with the status, authorised), in which case, the Agent Corporate Action Global Distribution Status Advice Identification must be present;|- the movement cancellation request, in which case, the Agent Corporate Action Movement Cancellation Request Identification must be present; and|- the movements resulting from an election status advice (if the status of the election advice is rejected or if the status of the election cancellation request or amendment request is accepted) in case there is a settlement problem. The Election Status Advice Identification must be present.|In the case of a failed settlement, the message contains details of the movement, such as account details, securities or cash information and the reason of the failure.|This message should not be used to provide the confirmation of the settlement; the Agent Corporate Action Movement Confirmation message should be used instead.")]
[IsoId("_TQurWdEwEd-BzquC8wXy7w_-1045499600")]
[DisplayName("Agent CA Movement Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAMovementStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.022.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAMvmntStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.022.001.01";
    
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
    /// Constructs a AgentCAMovementStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAMovementStatusAdviceV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAElectionStatusAdviceIdentification,DocumentIdentification8 reqAgentCAGlobalDistributionStatusAdviceIdentification,DocumentIdentification8 reqAgentCAMovementInstructionIdentification,DocumentIdentification8 reqAgentCAMovementCancellationRequestIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,CorporateActionMovementStatus1Choice_ reqMovementStatusDetails,CorporateMovementStatus2 reqMovementCancellationStatusDetails )
    {
        Identification = reqIdentification;
        AgentCAElectionStatusAdviceIdentification = reqAgentCAElectionStatusAdviceIdentification;
        AgentCAGlobalDistributionStatusAdviceIdentification = reqAgentCAGlobalDistributionStatusAdviceIdentification;
        AgentCAMovementInstructionIdentification = reqAgentCAMovementInstructionIdentification;
        AgentCAMovementCancellationRequestIdentification = reqAgentCAMovementCancellationRequestIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        MovementStatusDetails = reqMovementStatusDetails;
        MovementCancellationStatusDetails = reqMovementCancellationStatusDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TQurWtEwEd-BzquC8wXy7w_-1742571317")]
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
    /// Identification of the Agent Corporate Action Election Status Advice.
    /// </summary>
    [IsoId("_TQurW9EwEd-BzquC8wXy7w_-1429169217")]
    [DisplayName("Agent CA Election Status Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnStsAdvcId")]
    #endif
    [IsoXmlTag("AgtCAElctnStsAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Agent Corporate Action Global Distribution Status Advice.
    /// </summary>
    [IsoId("_TQurXNEwEd-BzquC8wXy7w_-1486425039")]
    [DisplayName("Agent CA Global Distribution Status Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAGblDstrbtnStsAdvcId")]
    #endif
    [IsoXmlTag("AgtCAGblDstrbtnStsAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Movement Instruction for which a status is given.
    /// </summary>
    [IsoId("_TQ4cUNEwEd-BzquC8wXy7w_-1745342942")]
    [DisplayName("Agent CA Movement Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAMvmntInstrId")]
    #endif
    [IsoXmlTag("AgtCAMvmntInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAMovementInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Movement Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TQ4cUdEwEd-BzquC8wXy7w_-1588344197")]
    [DisplayName("Agent CA Movement Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAMvmntCxlReqId")]
    #endif
    [IsoXmlTag("AgtCAMvmntCxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAMovementCancellationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAMovementCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAMovementCancellationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAMovementCancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TQ4cUtEwEd-BzquC8wXy7w_529102850")]
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
    /// Status of the movement instruction.
    /// </summary>
    [IsoId("_TQ4cU9EwEd-BzquC8wXy7w_-2031490064")]
    [DisplayName("Movement Status Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntStsDtls")]
    #endif
    [IsoXmlTag("MvmntStsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMovementStatus1Choice_ MovementStatusDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMovementStatus1Choice_ MovementStatusDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementStatus1Choice_ MovementStatusDetails { get; init; } 
    #else
    public CorporateActionMovementStatus1Choice_ MovementStatusDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the movement cancellation request.
    /// </summary>
    [IsoId("_TQ4cVNEwEd-BzquC8wXy7w_1041846719")]
    [DisplayName("Movement Cancellation Status Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntCxlStsDtls")]
    #endif
    [IsoXmlTag("MvmntCxlStsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateMovementStatus2 MovementCancellationStatusDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateMovementStatus2 MovementCancellationStatusDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateMovementStatus2 MovementCancellationStatusDetails { get; init; } 
    #else
    public CorporateMovementStatus2 MovementCancellationStatusDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAMovementStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAMovementStatusAdviceV01.

