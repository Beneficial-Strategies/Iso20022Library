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

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.018.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.
/// A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted.
/// Usage
/// The MandateSuspensionRequest message can contain one or more suspension requests.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.
///
/// </summary>
[Description(
    @"Scope|The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.|A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted. |Usage|The MandateSuspensionRequest message can contain one or more suspension requests.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.|"
)]
[IsoId("_rUYOLdcBEeq_l4BJLVUF2Q")]
[DisplayName("Mandate Suspension Request V")]
public record MandateSuspensionRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.018.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtSspnsnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.018.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate suspension request, but which are not part of the mandate.
    /// </summary>
    [IsoId("_rUYON9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader80 GroupHeader { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the suspension request of the mandate.
    /// </summary>
    [IsoId("_rUYOOdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Underlying Suspension Details")]
    [IsoXmlTag("UndrlygSspnsnDtls")]
    public required MandateSuspension3 UnderlyingSuspensionDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rUYOO9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MandateSuspensionRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MandateSuspensionRequestV03.
