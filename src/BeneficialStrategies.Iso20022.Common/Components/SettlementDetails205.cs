// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[IsoId("_Sw3zQSqSEeyR9JrVGfaMKw")]
[DisplayName("Settlement Details")]
public record SettlementDetails205
{
    /// <summary>
    /// Indicates the date as known by the two parties to be used for matching purposes when settlement of securities occurs.
    /// </summary>
    [IsoId("_TJKXcSqSEeyR9JrVGfaMKw")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TradeDate { get; init; }

    /// <summary>
    /// Provides details on either the delivering or receiving settlement parties.
    /// </summary>
    [IsoId("_TJKXcyqSEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties35Choice_? SettlementParties { get; init; }

    /// <summary>
    /// Indicates the collateral ownership.
    /// </summary>
    [IsoId("_TJKXdSqSEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Ownership")]
    [IsoXmlTag("CollOwnrsh")]
    public required CollateralOwnership4 CollateralOwnership { get; init; }
}
