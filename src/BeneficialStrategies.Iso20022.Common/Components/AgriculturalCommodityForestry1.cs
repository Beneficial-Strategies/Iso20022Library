// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an agricultural derivative of type forestry.
/// </summary>
[IsoId("_6LCcUFq_EeWN79Bl6BUd3g")]
[DisplayName("Agricultural Commodity Forestry")]
public record AgriculturalCommodityForestry1
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_DBMksFrAEeWN79Bl6BUd3g")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType1Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_KdxD8FrAEeWN79Bl6BUd3g")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public required AssetClassSubProductType21Code SubProduct { get; init; }
}
