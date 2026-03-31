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
/// This record is an implementation of the seev.026.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to the issuer agent to request the cancellation of a previously sent Agent Corporate Action Standing Instruction.
/// Usage
/// This message is used to request the cancellation of a standing instruction.
/// This message must contain the identification of the standing instruction to be cancelled. It may also contain details of the standing instruction to be cancelled, but this is not recommended.
/// </summary>
[Description(
    @"Scope|This message is sent by a CSD to the issuer agent to request the cancellation of a previously sent Agent Corporate Action Standing Instruction.|Usage|This message is used to request the cancellation of a standing instruction.|This message must contain the identification of the standing instruction to be cancelled. It may also contain details of the standing instruction to be cancelled, but this is not recommended."
)]
[IsoId("_TRx0NdEwEd-BzquC8wXy7w_608970881")]
[DisplayName("Agent CA Standing Instruction Cancellation Request V")]
public record AgentCAStandingInstructionCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.026.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAStgInstrCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.026.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TRx0NtEwEd-BzquC8wXy7w_-454258628")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// Identification of the Agent CA Standing Instruction Request to be cancelled.
    /// </summary>
    [IsoId("_TRx0N9EwEd-BzquC8wXy7w_-424704764")]
    [DisplayName("Agent CA Standing Instruction Request Identification")]
    [IsoXmlTag("AgtCAStgInstrReqId")]
    public required DocumentIdentification8 AgentCAStandingInstructionRequestIdentification { get; init; }

    /// <summary>
    /// General information about the standing instruction.
    /// </summary>
    [IsoId("_TRx0ONEwEd-BzquC8wXy7w_813068966")]
    [DisplayName("Standing Instruction General Information")]
    [IsoXmlTag("StgInstrGnlInf")]
    public required CorporateActionStandingInstructionGeneralInformation1 StandingInstructionGeneralInformation { get; init; }

    /// <summary>
    /// Information related to the standing instruction.
    /// </summary>
    [IsoId("_TRx0OdEwEd-BzquC8wXy7w_881408508")]
    [DisplayName("Standing Instruction Details")]
    [IsoXmlTag("StgInstrDtls")]
    public CorporateActionStandingInstruction1? StandingInstructionDetails { get; init; }
}

// Since AgentCAStandingInstructionCancellationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAStandingInstructionCancellationRequestV01.
