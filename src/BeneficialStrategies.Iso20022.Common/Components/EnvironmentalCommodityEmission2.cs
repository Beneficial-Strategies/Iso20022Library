// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an environmental derivative of type emission.
/// </summary>
[IsoId("_ynBwEbv4EeiLRYqS-r-R-A")]
[DisplayName("Environmental Commodity Emission")]
public record EnvironmentalCommodityEmission2
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_yww64bv4EeiLRYqS-r-R-A")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType3Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_yww647v4EeiLRYqS-r-R-A")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public required AssetClassSubProductType10Code SubProduct { get; init; }

    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [IsoId("_yww65bv4EeiLRYqS-r-R-A")]
    [DisplayName("Additional Sub Product")]
    [IsoXmlTag("AddtlSubPdct")]
    public required AssetClassDetailedSubProductType8Code AdditionalSubProduct { get; init; }
}
