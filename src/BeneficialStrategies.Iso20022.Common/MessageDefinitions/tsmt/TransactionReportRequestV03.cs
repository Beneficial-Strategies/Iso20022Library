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
/// This record is an implementation of the tsmt.042.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransactionReportRequest message is sent by a party involved in a transaction to the matching application.
/// This message is used to request a report on details of transactions registered in the matching application.
/// Usage
/// The TransactionReportRequest message can be sent by either party involved in a transaction to request a report on a variety of details of all transactions that the requester is involved in. For example, the message can be used to request a report on all transactions that the requester is involved in with a certain customer.
/// </summary>
[Description(
    @"Scope|The TransactionReportRequest message is sent by a party involved in a transaction to the matching application.|This message is used to request a report on details of transactions registered in the matching application.|Usage|The TransactionReportRequest message can be sent by either party involved in a transaction to request a report on a variety of details of all transactions that the requester is involved in. For example, the message can be used to request a report on all transactions that the requester is involved in with a certain customer."
)]
[IsoId("_15W1yNE8Ed-BzquC8wXy7w_-2039439363")]
[DisplayName("Transaction Report Request V")]
public record TransactionReportRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.042.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxRptReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_15W1ydE8Ed-BzquC8wXy7w_-2039438961")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Parameters to be used as criteria for the content of the transaction report.
    /// </summary>
    [IsoId("_15W1ytE8Ed-BzquC8wXy7w_-2039439323")]
    [DisplayName("Report Specification")]
    [IsoXmlTag("RptSpcfctn")]
    public required ReportSpecification4 ReportSpecification { get; init; }
}

// Since TransactionReportRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransactionReportRequestV03.
