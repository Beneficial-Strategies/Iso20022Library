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
/// This record is an implementation of the caaa.011.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent).
/// </summary>
[Description(
    @"The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent)."
)]
[IsoId("_93JPQap4EeanIZ10Ka8PnA")]
[DisplayName("Acceptor Batch Transfer V")]
public record AcceptorBatchTransferV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.011.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrBtchTrf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.011.001.06";

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
    [IsoId("_93JPRap4EeanIZ10Ka8PnA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header25 Header { get; init; }

    /// <summary>
    /// Card payment transactions from one or several data set of transactions.
    /// </summary>
    [IsoId("_93JPR6p4EeanIZ10Ka8PnA")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public required CardPaymentBatchTransfer5 BatchTransfer { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_93JPSap4EeanIZ10Ka8PnA")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType12? SecurityTrailer { get; init; }
}

// Since AcceptorBatchTransferV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorBatchTransferV06.
