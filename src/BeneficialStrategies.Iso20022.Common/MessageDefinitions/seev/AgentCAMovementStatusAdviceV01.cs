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
[Description(
    @"Scope|This message is sent by a CSD to an issuer (or its agent) to report the status, or a change in status, of|- a global distribution status advice released by an issuer (or its agent);|- a movement instruction released by an issuer (or its agent);|- a movement cancellation request sent by the issuer (or its agent); and|- the non-settlement of the movements at the CSD.|Usage|This message is used to report the status of:|- the movements resulting from a movement instruction message, in which case, the Agent Corporate Action Movement Instruction Identification must be present;|- the movements resulting from a global distribution status advice message (with the status, authorised), in which case, the Agent Corporate Action Global Distribution Status Advice Identification must be present;|- the movement cancellation request, in which case, the Agent Corporate Action Movement Cancellation Request Identification must be present; and|- the movements resulting from an election status advice (if the status of the election advice is rejected or if the status of the election cancellation request or amendment request is accepted) in case there is a settlement problem. The Election Status Advice Identification must be present.|In the case of a failed settlement, the message contains details of the movement, such as account details, securities or cash information and the reason of the failure.|This message should not be used to provide the confirmation of the settlement; the Agent Corporate Action Movement Confirmation message should be used instead."
)]
[IsoId("_TQurWdEwEd-BzquC8wXy7w_-1045499600")]
[DisplayName("Agent CA Movement Status Advice V")]
public record AgentCAMovementStatusAdviceV01 : IOuterRecord
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

    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TQurWtEwEd-BzquC8wXy7w_-1742571317")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// Identification of the Agent Corporate Action Election Status Advice.
    /// </summary>
    [IsoId("_TQurW9EwEd-BzquC8wXy7w_-1429169217")]
    [DisplayName("Agent CA Election Status Advice Identification")]
    [IsoXmlTag("AgtCAElctnStsAdvcId")]
    public required DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; }

    /// <summary>
    /// Identification of the Agent Corporate Action Global Distribution Status Advice.
    /// </summary>
    [IsoId("_TQurXNEwEd-BzquC8wXy7w_-1486425039")]
    [DisplayName("Agent CA Global Distribution Status Advice Identification")]
    [IsoXmlTag("AgtCAGblDstrbtnStsAdvcId")]
    public required DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; }

    /// <summary>
    /// Identification of the linked Agent CA Movement Instruction for which a status is given.
    /// </summary>
    [IsoId("_TQ4cUNEwEd-BzquC8wXy7w_-1745342942")]
    [DisplayName("Agent CA Movement Instruction Identification")]
    [IsoXmlTag("AgtCAMvmntInstrId")]
    public required DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the linked Agent CA Movement Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TQ4cUdEwEd-BzquC8wXy7w_-1588344197")]
    [DisplayName("Agent CA Movement Cancellation Request Identification")]
    [IsoXmlTag("AgtCAMvmntCxlReqId")]
    public required DocumentIdentification8 AgentCAMovementCancellationRequestIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TQ4cUtEwEd-BzquC8wXy7w_529102850")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Status of the movement instruction.
    /// </summary>
    [IsoId("_TQ4cU9EwEd-BzquC8wXy7w_-2031490064")]
    [DisplayName("Movement Status Details")]
    [IsoXmlTag("MvmntStsDtls")]
    public required CorporateActionMovementStatus1Choice_ MovementStatusDetails { get; init; }

    /// <summary>
    /// Status of the movement cancellation request.
    /// </summary>
    [IsoId("_TQ4cVNEwEd-BzquC8wXy7w_1041846719")]
    [DisplayName("Movement Cancellation Status Details")]
    [IsoXmlTag("MvmntCxlStsDtls")]
    public required CorporateMovementStatus2 MovementCancellationStatusDetails { get; init; }
}

// Since AgentCAMovementStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAMovementStatusAdviceV01.
