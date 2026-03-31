// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a paper derivative of type newsprint.
/// </summary>
[IsoId("_JwKEUFryEeWN79Bl6BUd3g")]
[DisplayName("Paper Commodity Newsprint")]
public record PaperCommodityNewsprint1
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_Qx4aoFryEeWN79Bl6BUd3g")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType8Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_zT-VsFryEeWN79Bl6BUd3g")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public AssetClassSubProductType36Code? SubProduct { get; init; }
}
