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
/// This record is an implementation of the colr.010.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralSubstitutionRequest message is sent by either the collateral giver or its collateral manager to the collateral taker or its collateral manager. It is used to request a substitution of collateral by specifying the collateral to be returned and proposing the new type(s) of collateral to be delivered. Note: There are cases where the collateral taker can initiate the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// The CollateralSubstitutionRequest message can be sent by either the collateral giver or collateral taker in order to substitute collateral that is already held by the other party.
/// </summary>
[Description(
    @"Scope|The CollateralSubstitutionRequest message is sent by either the collateral giver or its collateral manager to the collateral taker or its collateral manager. It is used to request a substitution of collateral by specifying the collateral to be returned and proposing the new type(s) of collateral to be delivered. Note: There are cases where the collateral taker can initiate the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralSubstitutionRequest message can be sent by either the collateral giver or collateral taker in order to substitute collateral that is already held by the other party."
)]
[IsoId("_vvBH0YFrEeWtPe6Crjmeug")]
[DisplayName("Collateral Substitution Request V")]
public record CollateralSubstitutionRequestV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.010.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.010.001.04";

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
    [IsoId("_vvBH04FrEeWtPe6Crjmeug")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_vvBH1YFrEeWtPe6Crjmeug")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation4 Obligation { get; init; }

    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_vvBH14FrEeWtPe6Crjmeug")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public Agreement4? Agreement { get; init; }

    /// <summary>
    /// Provides details about the collateral that will be returned.
    /// </summary>
    [IsoId("_vvBH2YFrEeWtPe6Crjmeug")]
    [DisplayName("Collateral Substitution Return")]
    [IsoXmlTag("CollSbstitnRtr")]
    public required CollateralSubstitution5 CollateralSubstitutionReturn { get; init; }

    /// <summary>
    /// Provides details about the collateral that will be delivered.
    /// </summary>
    [IsoId("_vvBH24FrEeWtPe6Crjmeug")]
    [DisplayName("Collateral Substitution Deliver")]
    [IsoXmlTag("CollSbstitnDlvr")]
    public CollateralSubstitution4? CollateralSubstitutionDeliver { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vvBH3YFrEeWtPe6Crjmeug")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CollateralSubstitutionRequestV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralSubstitutionRequestV04.
