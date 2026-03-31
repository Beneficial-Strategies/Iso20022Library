// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.030.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to report the status, or a change in status, of a corporate action deactivation instruction or the status of a deactivation cancellation request.
/// Usage
/// This message is used to provide a status on the deactivation instruction, especially to confirm the deactivation of a Corporate Action event or option.
/// </summary>
[Description(
    @"Scope|This message is sent by a CSD to an issuer (or its agent) to report the status, or a change in status, of a corporate action deactivation instruction or the status of a deactivation cancellation request.|Usage|This message is used to provide a status on the deactivation instruction, especially to confirm the deactivation of a Corporate Action event or option."
)]
[IsoId("_TMQbDNEwEd-BzquC8wXy7w_622567227")]
[DisplayName("Agent CA Deactivation Status Advice V")]
public record AgentCADeactivationStatusAdviceV01 : IOuterRecord
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

    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TMQbDdEwEd-BzquC8wXy7w_-540475327")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// Identification of the linked Agent CA Deactivation Instruction for which a status is given.
    /// </summary>
    [IsoId("_TMaMANEwEd-BzquC8wXy7w_-214470974")]
    [DisplayName("Agent CA Deactivation Instruction Identification")]
    [IsoXmlTag("AgtCADeactvtnInstrId")]
    public required DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the linked Agent CA Deactivation Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TMaMAdEwEd-BzquC8wXy7w_965193756")]
    [DisplayName("Agent CA Deactivation Cancellation Request Identification")]
    [IsoXmlTag("AgtCADeactvtnCxlReqId")]
    public required DocumentIdentification8 AgentCADeactivationCancellationRequestIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMaMAtEwEd-BzquC8wXy7w_-1294066154")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Status of the deactivation instruction sent by the issuer (agent).
    /// </summary>
    [IsoId("_TMaMA9EwEd-BzquC8wXy7w_861232790")]
    [DisplayName("Deactivation Instruction Status")]
    [IsoXmlTag("DeactvtnInstrSts")]
    public required CorporateActionDeactivationInstructionStatus1 DeactivationInstructionStatus { get; init; }

    /// <summary>
    /// Status of the deactivation cancellation request sent by the issuer (agent).
    /// </summary>
    [IsoId("_TMaMBNEwEd-BzquC8wXy7w_1319300008")]
    [DisplayName("Deactivation Cancellation Request Status")]
    [IsoXmlTag("DeactvtnCxlReqSts")]
    public required CorporateActionDeactivationCancellationStatus1Choice_ DeactivationCancellationRequestStatus { get; init; }
}

// Since AgentCADeactivationStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCADeactivationStatusAdviceV01.
