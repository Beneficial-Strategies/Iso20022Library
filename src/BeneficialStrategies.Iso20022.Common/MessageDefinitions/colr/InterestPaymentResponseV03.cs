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

namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.014.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This InterestPaymentResponse message is sent by either;
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager
/// This is a response to the InterestPaymentRequest message and the amount of interest requested or advised can be accepted or rejected.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// The InterestPaymentResponse message is sent in response to the InterestPaymentRequest in order to accept or reject the amount of interest requested or advised. A rejection reason and information can be provide if the InterestPaymentRequest is being rejected.
/// </summary>
[Description(
    @"Scope|This InterestPaymentResponse message is sent by either;|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager|This is a response to the InterestPaymentRequest message and the amount of interest requested or advised can be accepted or rejected.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The InterestPaymentResponse message is sent in response to the InterestPaymentRequest in order to accept or reject the amount of interest requested or advised. A rejection reason and information can be provide if the InterestPaymentRequest is being rejected."
)]
[IsoId("_977eoWNnEeSIWbZ6by9dnA")]
[DisplayName("Interest Payment Response V")]
public record InterestPaymentResponseV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.014.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntrstPmtRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.014.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_977eo2NnEeSIWbZ6by9dnA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_GigdcGNpEeSIWbZ6by9dnA")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation3 Obligation { get; init; }

    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_977erWNnEeSIWbZ6by9dnA")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public required Agreement2 Agreement { get; init; }

    /// <summary>
    /// Provides details on the interest amount due to party A.
    /// </summary>
    [IsoId("_977er2NnEeSIWbZ6by9dnA")]
    [DisplayName("Interest Due To A")]
    [IsoXmlTag("IntrstDueToA")]
    public InterestAmount2? InterestDueToA { get; init; }

    /// <summary>
    /// Provides details on the interest amount due to party B.
    /// </summary>
    [IsoId("_977esWNnEeSIWbZ6by9dnA")]
    [DisplayName("Interest Due To B")]
    [IsoXmlTag("IntrstDueToB")]
    public InterestAmount2? InterestDueToB { get; init; }

    /// <summary>
    /// Provides details on the response to the interest payment request.
    /// </summary>
    [IsoId("_977es2NnEeSIWbZ6by9dnA")]
    [DisplayName("Interest Response")]
    [IsoXmlTag("IntrstRspn")]
    public required InterestResponse1 InterestResponse { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_977etWNnEeSIWbZ6by9dnA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since InterestPaymentResponseV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InterestPaymentResponseV03.
