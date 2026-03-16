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
/// This record is an implementation of the caaa.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorBatchTransferResponse message is sent by the acquirer to the card acceptor to acknowledge the proper reception of the AcceptorBatchTransfer.
/// Usage
/// The AcceptorBatchTransferResponse message is used by an acquirer to inform the card acceptor of the card payment transactions that could not be captured in the AcceptorBatchTransfer.
/// </summary>
[Description(
    @"Scope|The AcceptorBatchTransferResponse message is sent by the acquirer to the card acceptor to acknowledge the proper reception of the AcceptorBatchTransfer.|Usage|The AcceptorBatchTransferResponse message is used by an acquirer to inform the card acceptor of the card payment transactions that could not be captured in the AcceptorBatchTransfer."
)]
[IsoId("_fHr69KMVEeCJ6YNENx4h-w_-1884462176")]
[DisplayName("Acceptor Batch Transfer Response V")]
public record AcceptorBatchTransferResponseV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.012.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrBtchTrfRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.012.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Capture advice response message management information.
    /// </summary>
    [IsoId("_fHr69aMVEeCJ6YNENx4h-w_-1280012543")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header3 Header { get; init; }

    /// <summary>
    /// Information related to the previously sent set of transaction.
    /// </summary>
    [IsoId("_fHr69qMVEeCJ6YNENx4h-w_-71921900")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required CardPaymentDataSet2 DataSet { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_fHr696MVEeCJ6YNENx4h-w_977823991")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType1 SecurityTrailer { get; init; }
}

// Since AcceptorBatchTransferResponseV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorBatchTransferResponseV01.
