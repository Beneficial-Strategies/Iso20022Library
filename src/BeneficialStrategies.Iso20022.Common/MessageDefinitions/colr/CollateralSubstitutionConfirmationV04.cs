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
/// This record is an implementation of the colr.012.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralSubstitutionConfirmation message is sent by:
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager.
/// This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released. In the event that multiple pieces of collateral are being delivered in place of the collateral due to be returned by the giver, this message should only be generated once all collateral pieces have been agreed between both parties. Then the taker confirms that the collateral substitution (that is all pieces have been received) and acknowledges return of collateral.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released.
/// </summary>
[Description(
    @"Scope|The CollateralSubstitutionConfirmation message is sent by:|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager.|This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released. In the event that multiple pieces of collateral are being delivered in place of the collateral due to be returned by the giver, this message should only be generated once all collateral pieces have been agreed between both parties. Then the taker confirms that the collateral substitution (that is all pieces have been received) and acknowledges return of collateral.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This message confirms the collateral delivery. The collateral taker will only release the return of collateral when the new piece of collateral is received. The collateral giver sends the collateral taker the notification that the collateral substitution (that is new piece(s) of collateral) have been released."
)]
[IsoId("_rREV0YFrEeWtPe6Crjmeug")]
[DisplayName("Collateral Substitution Confirmation V")]
public record CollateralSubstitutionConfirmationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.012.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.012.001.04";

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
    [IsoId("_rREV04FrEeWtPe6Crjmeug")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_rREV1YFrEeWtPe6Crjmeug")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation4 Obligation { get; init; }

    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_rREV14FrEeWtPe6Crjmeug")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public Agreement4? Agreement { get; init; }

    /// <summary>
    /// Provides the status about the collateral substitution.
    /// </summary>
    [IsoId("_rREV2YFrEeWtPe6Crjmeug")]
    [DisplayName("Substitution Confirmation")]
    [IsoXmlTag("SbstitnConf")]
    public required CollateralConfirmation1 SubstitutionConfirmation { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_rREV24FrEeWtPe6Crjmeug")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CollateralSubstitutionConfirmationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralSubstitutionConfirmationV04.
