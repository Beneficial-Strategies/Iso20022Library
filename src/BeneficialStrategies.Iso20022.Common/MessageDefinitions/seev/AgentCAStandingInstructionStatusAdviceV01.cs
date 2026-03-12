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
    
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TSEvKtEwEd-BzquC8wXy7w_4729651")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Identification of the linked Agent CA Standing Instruction Request for which a status is given.
    /// </summary>
    [IsoId("_TSEvK9EwEd-BzquC8wXy7w_45366871")]
    [DisplayName("Agent CA Standing Instruction Request Identification")]
    [IsoXmlTag("AgtCAStgInstrReqId")]
    public required DocumentIdentification8 AgentCAStandingInstructionRequestIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the linked Agent CA Standing Instruction Cancellation Request for which a status is given.|.
    /// </summary>
    [IsoId("_TSEvLNEwEd-BzquC8wXy7w_146031516")]
    [DisplayName("Agent CA Standing Instruction Cancellation Request Identification")]
    [IsoXmlTag("AgtCAStgInstrCxlReqId")]
    public required DocumentIdentification8 AgentCAStandingInstructionCancellationRequestIdentification { get; init; } 
    
    /// <summary>
    /// General information about the standing instruction.
    /// </summary>
    [IsoId("_TSN5ENEwEd-BzquC8wXy7w_-1087118100")]
    [DisplayName("Standing Instruction General Information")]
    [IsoXmlTag("StgInstrGnlInf")]
    public required CorporateActionStandingInstructionGeneralInformation1 StandingInstructionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Status of the standing instruction request.
    /// </summary>
    [IsoId("_TSN5EdEwEd-BzquC8wXy7w_-1705435837")]
    [DisplayName("Standing Instruction Request Status")]
    [IsoXmlTag("StgInstrReqSts")]
    public required StandingInstructionStatus1Choice_ StandingInstructionRequestStatus { get; init; } 
    
    /// <summary>
    /// Provides information about the status of a standing instruction cancellation request.
    /// </summary>
    [IsoId("_TSN5EtEwEd-BzquC8wXy7w_-1517034703")]
    [DisplayName("Standing Instruction Cancellation Request Status")]
    [IsoXmlTag("StgInstrCxlReqSts")]
    public required StandingInstructionCancellationStatus1Choice_ StandingInstructionCancellationRequestStatus { get; init; } 
    
    
    #nullable disable
    
}


// Since AgentCAStandingInstructionStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAStandingInstructionStatusAdviceV01.

