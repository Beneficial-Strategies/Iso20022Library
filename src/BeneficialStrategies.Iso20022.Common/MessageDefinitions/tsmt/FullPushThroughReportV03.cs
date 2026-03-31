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
/// This record is an implementation of the tsmt.018.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FullPushThroughReport message is sent by the matching application to a party involved in a transaction.
/// This message is used to pass on information that the matching application has received from the submitter. The forwarded information can originate from an InitialBaselineSubmission or BaselineReSubmission or BaselineAmendmentRequest message.
/// Usage
/// The FullPushThroughReport message can be sent by the matching application to a party to convey
/// - the details of an InitialBaselineSubmission message that it has obtained, or
/// - the details of a BaselineResubmission message that it has obtained, or
/// - the details of a BaselineAmendmentRequest message that it has obtained.
/// </summary>
[Description(
    @"Scope|The FullPushThroughReport message is sent by the matching application to a party involved in a transaction.|This message is used to pass on information that the matching application has received from the submitter. The forwarded information can originate from an InitialBaselineSubmission or BaselineReSubmission or BaselineAmendmentRequest message.|Usage|The FullPushThroughReport message can be sent by the matching application to a party to convey|- the details of an InitialBaselineSubmission message that it has obtained, or|- the details of a BaselineResubmission message that it has obtained, or|- the details of a BaselineAmendmentRequest message that it has obtained."
)]
[IsoId("_paNNeNE8Ed-BzquC8wXy7w_-1602880214")]
[DisplayName("Full Push Through Report V")]
public record FullPushThroughReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.018.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FullPushThrghRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.018.001.03";

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
    [IsoId("_paNNedE8Ed-BzquC8wXy7w_-1602880211")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_paNNetE8Ed-BzquC8wXy7w_-1602880178")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_paNNe9E8Ed-BzquC8wXy7w_-1602879810")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_paNNfNE8Ed-BzquC8wXy7w_-1602880093")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for the financial institution which submitted the baseline.
    /// </summary>
    [IsoId("_paW-cNE8Ed-BzquC8wXy7w_-1602879793")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Specifies the type of report.
    /// </summary>
    [IsoId("_paW-cdE8Ed-BzquC8wXy7w_-1602880136")]
    [DisplayName("Report Purpose")]
    [IsoXmlTag("RptPurp")]
    public required ReportType1 ReportPurpose { get; init; }

    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_paW-ctE8Ed-BzquC8wXy7w_-1602879673")]
    [DisplayName("Pushed Through Baseline")]
    [IsoXmlTag("PushdThrghBaseln")]
    public required Baseline3 PushedThroughBaseline { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_paW-c9E8Ed-BzquC8wXy7w_-1602879715")]
    [DisplayName("Buyer Contact Person")]
    [IsoXmlTag("BuyrCtctPrsn")]
    public ContactIdentification1? BuyerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_paW-dNE8Ed-BzquC8wXy7w_-1602879163")]
    [DisplayName("Seller Contact Person")]
    [IsoXmlTag("SellrCtctPrsn")]
    public ContactIdentification1? SellerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the buyer&apos;s bank.
    /// </summary>
    [IsoId("_paW-ddE8Ed-BzquC8wXy7w_-1602879518")]
    [DisplayName("Buyer Bank Contact Person")]
    [IsoXmlTag("BuyrBkCtctPrsn")]
    public ContactIdentification1? BuyerBankContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the seller&apos;s bank.
    /// </summary>
    [IsoId("_paW-dtE8Ed-BzquC8wXy7w_-1602879638")]
    [DisplayName("Seller Bank Contact Person")]
    [IsoXmlTag("SellrBkCtctPrsn")]
    public ContactIdentification1? SellerBankContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in another bank than the seller or buyer&apos;s bank.
    /// </summary>
    [IsoId("_paW-d9E8Ed-BzquC8wXy7w_-595440751")]
    [DisplayName("Other Bank Contact Person")]
    [IsoXmlTag("OthrBkCtctPrsn")]
    public ContactIdentification3? OtherBankContactPerson { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_pagIYNE8Ed-BzquC8wXy7w_-1602879750")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since FullPushThroughReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FullPushThroughReportV03.
