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
/// This record is an implementation of the pain.011.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateCancellationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateCancellationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateCancellationRequest message is used to request the cancellation of an existing mandate. If accepted, this MandateCancellationRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered a valid cancellation of an existing mandate, agreed upon by all parties.
/// Usage
/// The MandateCancellationRequest message can contain only one request to cancel one specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateCancellationRequest message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(
    @"Scope|The MandateCancellationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.|The MandateCancellationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.|A MandateCancellationRequest message is used to request the cancellation of an existing mandate. If accepted, this MandateCancellationRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered a valid cancellation of an existing mandate, agreed upon by all parties.|Usage|The MandateCancellationRequest message can contain only one request to cancel one specific mandate.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.|The MandateCancellationRequest message can be used in domestic and cross-border scenarios."
)]
[IsoId("_r0RuwFkyEeGeoaLUQk__nA_893031254")]
[DisplayName("Mandate Cancellation Request V")]
public record MandateCancellationRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.011.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.011.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the cancellation of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_r0a4sFkyEeGeoaLUQk__nA_1977602072")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader47 GroupHeader { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the cancellation request.
    /// </summary>
    [IsoId("_r0a4sVkyEeGeoaLUQk__nA_1094368785")]
    [DisplayName("Underlying Cancellation Details")]
    [IsoXmlTag("UndrlygCxlDtls")]
    public required MandateCancellation2 UnderlyingCancellationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_r0kpsFkyEeGeoaLUQk__nA_-961186885")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MandateCancellationRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MandateCancellationRequestV02.
