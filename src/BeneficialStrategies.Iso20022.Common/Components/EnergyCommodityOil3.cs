// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an energy derivative of type oil.
/// </summary>
[IsoId("_bqf04U8SEe2PGo0mhYCh1g")]
[DisplayName("Energy Commodity Oil")]
public record EnergyCommodityOil3
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_brghgU8SEe2PGo0mhYCh1g")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType2Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_brghg08SEe2PGo0mhYCh1g")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public AssetClassSubProductType8Code? SubProduct { get; init; }

    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [IsoId("_brghhU8SEe2PGo0mhYCh1g")]
    [DisplayName("Additional Sub Product")]
    [IsoXmlTag("AddtlSubPdct")]
    public AssetClassDetailedSubProductType32Code? AdditionalSubProduct { get; init; }
}
