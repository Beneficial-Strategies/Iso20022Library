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

namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendmentAcceptance message is sent by the party requested to accept or reject an amendment to the matching application.
/// The message is used to accept an amendment request.
/// Usage
/// The AmendmentAcceptance message can be sent by the party requested to accept or reject an amendment to inform that it accepts the requested amendment.
/// The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.
/// The rejection of an amendment request can be achieved by sending an AmendmentRejection message.
/// </summary>
[Description(
    @"Scope|The AmendmentAcceptance message is sent by the party requested to accept or reject an amendment to the matching application.|The message is used to accept an amendment request.|Usage|The AmendmentAcceptance message can be sent by the party requested to accept or reject an amendment to inform that it accepts the requested amendment.|The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.|The rejection of an amendment request can be achieved by sending an AmendmentRejection message."
)]
[IsoId("_j0IVwtE8Ed-BzquC8wXy7w_1561210255")]
[DisplayName("Amendment Acceptance V")]
public record AmendmentAcceptanceV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.005.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdmntAccptnc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.005.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_j0IVw9E8Ed-BzquC8wXy7w_1561211944")]
    [DisplayName("Acceptance Identification")]
    [IsoXmlTag("AccptncId")]
    public required MessageIdentification1 AcceptanceIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_j0IVxNE8Ed-BzquC8wXy7w_1561211914")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the identification of the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_j0IVxdE8Ed-BzquC8wXy7w_1561212005")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }

    /// <summary>
    /// Reference to the identification of the delta report that contained the amendment.
    /// </summary>
    [IsoId("_j0IVxtE8Ed-BzquC8wXy7w_1561211883")]
    [DisplayName("Delta Report Reference")]
    [IsoXmlTag("DltaRptRef")]
    public required MessageIdentification1 DeltaReportReference { get; init; }

    /// <summary>
    /// Sequence number of the accepted baseline amendment.
    /// </summary>
    [IsoId("_j0IVx9E8Ed-BzquC8wXy7w_1561211975")]
    [DisplayName("Accepted Amendment Number")]
    [IsoXmlTag("AccptdAmdmntNb")]
    public required Count1 AcceptedAmendmentNumber { get; init; }
}

// Since AmendmentAcceptanceV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendmentAcceptanceV02.
