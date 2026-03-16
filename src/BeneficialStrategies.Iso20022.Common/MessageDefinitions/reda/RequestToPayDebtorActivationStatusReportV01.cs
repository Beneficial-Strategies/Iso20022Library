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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.073.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RequestToPayDebtorActivationStatusReport message is sent from the recipient of the debtor activation request message (initiation, amendment or cancellation), such as the creditor RTP provider or the creditor, to the initiator of the debtor activation request message (debtor, debtor RTP provider or any of the forwarding agent) to provide the status of the request.
///
/// </summary>
[Description(
    @"The RequestToPayDebtorActivationStatusReport message is sent from the recipient of the debtor activation request message (initiation, amendment or cancellation), such as the creditor RTP provider or the creditor, to the initiator of the debtor activation request message (debtor, debtor RTP provider or any of the forwarding agent) to provide the status of the request. |"
)]
[IsoId("_rNNB1-HzEeqbls7Gk4-ckA")]
[DisplayName("Request To Pay Debtor Activation Status Report V")]
public record RequestToPayDebtorActivationStatusReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.073.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayDbtrActvtnStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.073.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.
    /// </summary>
    [IsoId("_rNNB2-HzEeqbls7Gk4-ckA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required ActivationHeader2 Header { get; init; }

    /// <summary>
    /// Status of the debtor activation instruction (that is request, amendment or cancellation).
    /// </summary>
    [IsoId("_rNNB3eHzEeqbls7Gk4-ckA")]
    [DisplayName("Original Activation And Status")]
    [IsoXmlTag("OrgnlActvtnAndSts")]
    public required ActivationStatus2 OriginalActivationAndStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNB3-HzEeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since RequestToPayDebtorActivationStatusReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToPayDebtorActivationStatusReportV01.
