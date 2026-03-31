// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a freight derivative of type wet.
/// </summary>
[IsoId("_ojjOEbv6EeiLRYqS-r-R-A")]
[DisplayName("Freight Commodity Wet")]
public record FreightCommodityWet2
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_ozV9kbv6EeiLRYqS-r-R-A")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType4Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_ozV9k7v6EeiLRYqS-r-R-A")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public required AssetClassSubProductType32Code SubProduct { get; init; }

    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [IsoId("_ozV9lbv6EeiLRYqS-r-R-A")]
    [DisplayName("Additional Sub Product")]
    [IsoXmlTag("AddtlSubPdct")]
    public required AssetClassDetailedSubProductType34Code AdditionalSubProduct { get; init; }
}
