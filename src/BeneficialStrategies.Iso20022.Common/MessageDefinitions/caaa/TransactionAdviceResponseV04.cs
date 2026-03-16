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
/// This record is an implementation of the caaa.021.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.
/// </summary>
[Description(
    @"The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice."
)]
[IsoId("_0jwTEXMlEe2vXY6MoVq19w")]
[DisplayName("Transaction Advice Response V")]
public record TransactionAdviceResponseV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.021.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxAdvcRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.021.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Completion advice message management information.
    /// </summary>
    [IsoId("_0jwTE3MlEe2vXY6MoVq19w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header70 Header { get; init; }

    /// <summary>
    /// Information related to the transaction advice response.
    /// </summary>
    [IsoId("_0jwTFXMlEe2vXY6MoVq19w")]
    [DisplayName("Transaction Advice Response")]
    [IsoXmlTag("TxAdvcRspn")]
    public required AcceptorCompletionAdviceResponse11 TransactionAdviceResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_0jwTF3MlEe2vXY6MoVq19w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType36? SecurityTrailer { get; init; }
}

// Since TransactionAdviceResponseV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransactionAdviceResponseV04.
