// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a commodity asset class
/// </summary>
[IsoId("_EzO169R8EemZdYGWu384Zw")]
[DisplayName("Compare Commodity Asset Class")]
public record CompareCommodityAssetClass2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_E3RoYdR8EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public AssetClassCommodity5Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_E3RoY9R8EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public AssetClassCommodity5Choice_? Value2 { get; init; }
}
