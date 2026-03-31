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
/// This record is an implementation of the colr.011.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralSubstitutionResponse message is sent by either the collateral taker or its collateral manager to the collateral giver or its collateral manager. This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected. If the collateral proposed is rejected then a new CollateralSubstitutionRequest should be sent. Note: There are cases where the collateral giver will send this message when the collateral taker has initiated the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected.
/// </summary>
[Description(
    @"Scope|The CollateralSubstitutionResponse message is sent by either the collateral taker or its collateral manager to the collateral giver or its collateral manager. This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected. If the collateral proposed is rejected then a new CollateralSubstitutionRequest should be sent. Note: There are cases where the collateral giver will send this message when the collateral taker has initiated the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected."
)]
[IsoId("_J4YklSgrEeyB747fKu7_rw")]
[DisplayName("Collateral Substitution Response V")]
public record CollateralSubstitutionResponseV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.011.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.011.001.05";

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
    [IsoId("_J4YkmygrEeyB747fKu7_rw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YknSgrEeyB747fKu7_rw")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation9 Obligation { get; init; }

    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YknygrEeyB747fKu7_rw")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public Agreement4? Agreement { get; init; }

    /// <summary>
    /// Provides details about the collateral substitution response.
    /// </summary>
    [IsoId("_J4YkoSgrEeyB747fKu7_rw")]
    [DisplayName("Substitution Response")]
    [IsoXmlTag("SbstitnRspn")]
    public required SubstitutionResponse2 SubstitutionResponse { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkoygrEeyB747fKu7_rw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CollateralSubstitutionResponseV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralSubstitutionResponseV05.
