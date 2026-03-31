// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an agricultural derivative of type livestock.
/// </summary>
[IsoId("_YbmQwFrAEeWN79Bl6BUd3g")]
[DisplayName("Agricultural Commodity Live Stock")]
public record AgriculturalCommodityLiveStock1
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_ftCeEFrAEeWN79Bl6BUd3g")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType1Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_oRBRUFrAEeWN79Bl6BUd3g")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public required AssetClassSubProductType22Code SubProduct { get; init; }
}
