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
/// This record is an implementation of the tsmt.015.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DeltaReport message is sent by the matching application to the parties involved in the request of a baseline amendment.
/// The message is used to list the differences between the established and the newly proposed baseline.
/// Usage
/// The DeltaReport message can be sent by the matching application to
/// - the parties involved in the amendment of a baseline that has been established in the push-through mode. In the outlined scenario the message is sent to the requester of the amendment to acknowledge the receipt of the request and to list the differences between the established and the newly proposed baseline and to the counterparty to list the differences between the established and the newly proposed baseline and to request the acceptance or rejection of the amendment request,
/// or
/// - the party that has requested the amendment of a baseline established in the lodge mode. In the outlined scenario the message is used to confirm the changes to the baseline and to list the differences between the amended baseline and the baseline established earlier.
/// </summary>
[Description(
    @"Scope|The DeltaReport message is sent by the matching application to the parties involved in the request of a baseline amendment.|The message is used to list the differences between the established and the newly proposed baseline.|Usage|The DeltaReport message can be sent by the matching application to|- the parties involved in the amendment of a baseline that has been established in the push-through mode. In the outlined scenario the message is sent to the requester of the amendment to acknowledge the receipt of the request and to list the differences between the established and the newly proposed baseline and to the counterparty to list the differences between the established and the newly proposed baseline and to request the acceptance or rejection of the amendment request,|or|- the party that has requested the amendment of a baseline established in the lodge mode. In the outlined scenario the message is used to confirm the changes to the baseline and to list the differences between the amended baseline and the baseline established earlier."
)]
[IsoId("_nsFeyNE8Ed-BzquC8wXy7w_1762924909")]
[DisplayName("Delta Report V")]
public record DeltaReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.015.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DltaRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.015.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_nsPPwNE8Ed-BzquC8wXy7w_1762925372")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_nsPPwdE8Ed-BzquC8wXy7w_1762924912")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_nsPPwtE8Ed-BzquC8wXy7w_1762925433")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_nsPPw9E8Ed-BzquC8wXy7w_1762925188")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Sequence number of the proposed baseline amendment.
    /// </summary>
    [IsoId("_nsPPxNE8Ed-BzquC8wXy7w_1762925826")]
    [DisplayName("Amendment Number")]
    [IsoXmlTag("AmdmntNb")]
    public required Count1 AmendmentNumber { get; init; }

    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_nsPPxdE8Ed-BzquC8wXy7w_1762925311")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_nsPPxtE8Ed-BzquC8wXy7w_1762925464")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; }

    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_nsPPx9E8Ed-BzquC8wXy7w_1762925711")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; }

    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nsYZsNE8Ed-BzquC8wXy7w_1762925280")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; }

    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nsYZsdE8Ed-BzquC8wXy7w_1762925221")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; }

    /// <summary>
    /// Reference to the identification of the baseline included in the amendment request.
    /// </summary>
    [IsoId("_nsYZstE8Ed-BzquC8wXy7w_1762925795")]
    [DisplayName("Submitter Proposed Baseline Reference")]
    [IsoXmlTag("SubmitrPropsdBaselnRef")]
    public required DocumentIdentification1 SubmitterProposedBaselineReference { get; init; }

    /// <summary>
    /// Detailed comparison between the currently established baseline elements and the proposed ones.
    /// </summary>
    [IsoId("_nsYZs9E8Ed-BzquC8wXy7w_1762925773")]
    [DisplayName("Updated Element")]
    [IsoXmlTag("UpdtdElmt")]
    public required ComparisonResult2 UpdatedElement { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_nsYZtNE8Ed-BzquC8wXy7w_1762925341")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since DeltaReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DeltaReportV03.
