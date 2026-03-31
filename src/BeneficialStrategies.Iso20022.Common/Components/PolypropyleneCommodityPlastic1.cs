// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a polypropylene derivative of type plastic.
/// </summary>
[IsoId("_05754Gs4EeW9oI9ZdgWHPQ")]
[DisplayName("Polypropylene Commodity Plastic")]
public record PolypropyleneCommodityPlastic1
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_bNpscGs5EeW9oI9ZdgWHPQ")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType9Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_eOMFQGs5EeW9oI9ZdgWHPQ")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public AssetClassSubProductType18Code? SubProduct { get; init; }
}
