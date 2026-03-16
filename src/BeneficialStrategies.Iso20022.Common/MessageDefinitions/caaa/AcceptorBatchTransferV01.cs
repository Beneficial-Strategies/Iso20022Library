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

namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorBatchTransfer message is sent by the card acceptor to the acquirer to capture a collection of previously completed card payment transactions.
/// Usage
/// The AcceptorBatchTransfer message embeds the information required for transferring to the acquirer the data needed to perform the financial settlement of these transactions (capture).
/// </summary>
[Description(
    @"Scope|The AcceptorBatchTransfer message is sent by the card acceptor to the acquirer to capture a collection of previously completed card payment transactions.|Usage|The AcceptorBatchTransfer message embeds the information required for transferring to the acquirer the data needed to perform the financial settlement of these transactions (capture)."
)]
[IsoId("_edEQpaMVEeCJ6YNENx4h-w_1105979751")]
[DisplayName("Acceptor Batch Transfer V")]
public record AcceptorBatchTransferV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.011.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrBtchTrf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.011.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Batch capture message management information.
    /// </summary>
    [IsoId("_edEQpqMVEeCJ6YNENx4h-w_-1485321403")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header3 Header { get; init; }

    /// <summary>
    /// Information related to the set of transaction.
    /// </summary>
    [IsoId("_edEQp6MVEeCJ6YNENx4h-w_1311812770")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required CardPaymentDataSet1 DataSet { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_edEQqKMVEeCJ6YNENx4h-w_-1725019093")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType1 SecurityTrailer { get; init; }
}

// Since AcceptorBatchTransferV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorBatchTransferV01.
