// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument representing ownership of an amount of a commodity.
/// </summary>
[IsoId("_l0hO0BYHEeejf-cbr8l5qw")]
[DisplayName("Commodity")]
public record Commodity2
{
    /// <summary>
    /// Mark-to-market pre-haircut value.
    /// </summary>
    [IsoId("_0jm5cBYHEeejf-cbr8l5qw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveCurrencyAnd24Amount MarketValue { get; init; }

    /// <summary>
    /// Specifies the type of commodity.
    /// </summary>
    [IsoId("_6IEnkBYHEeejf-cbr8l5qw")]
    [DisplayName("Commodity Type")]
    [IsoXmlTag("CmmdtyTp")]
    public required AssetClassDetailedSubProductType1Choice_ CommodityType { get; init; }
}
