// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a freight derivative of type dry.
/// </summary>
[IsoId("_UwBLgU8REe2PGo0mhYCh1g")]
[DisplayName("Freight Commodity Dry")]
public record FreightCommodityDry3
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_Uw58UU8REe2PGo0mhYCh1g")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType4Code BaseProduct { get; init; }

    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_Uw58U08REe2PGo0mhYCh1g")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public AssetClassSubProductType31Code? SubProduct { get; init; }

    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [IsoId("_Uw58VU8REe2PGo0mhYCh1g")]
    [DisplayName("Additional Sub Product")]
    [IsoXmlTag("AddtlSubPdct")]
    public AssetClassDetailedSubProductType33Code? AdditionalSubProduct { get; init; }
}
