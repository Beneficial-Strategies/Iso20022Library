// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// An investor’s ability to bear losses.
/// </summary>
[IsoId("_VPJpEDcPEeiIxKQErQxblg")]
[DisplayName("Loss Bearing")]
public record LossBearing1
{
    /// <summary>
    /// Specifies whether the product is compatible with a client who cannot bear loss of capital. Minor losses especially due to costs are possible. For a negative target (no), the product should not be sold to investors that cannot bear losses. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03010. In EMT v2, this is known as Compatible With Clients Who Can Not Bear Capital Loss.
    /// </summary>
    [IsoId("_dXtroDcPEeiIxKQErQxblg")]
    [DisplayName("No Capital Loss")]
    [IsoXmlTag("NoCptlLoss")]
    public TargetMarket1Code? NoCapitalLoss { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with a client who is seeking to preserve capital or who can bear losses limited to a level specified by a structured security or structure fund product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03020. In EMT v2, this is known as Compatible With Clients Who Can Bear Limited Capital Loss.
    /// </summary>
    [IsoId("_iPPbQDcPEeiIxKQErQxblg")]
    [DisplayName("Limited Capital Loss")]
    [IsoXmlTag("LtdCptlLoss")]
    public TargetMarket1Code? LimitedCapitalLoss { get; init; }

    /// <summary>
    /// Specifies the percentage of loss that can be carried by the investor. This is typically used for structured products or structured funds. This is only specified when a clear partial capital guarantee is provided on the primary market and the product is held until maturity. The level of potential losses is the one that could be calculated according to the offering documentation. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03030.
    /// </summary>
    [IsoId("_nMuo8DcPEeiIxKQErQxblg")]
    [DisplayName("Limited Capital Loss Level")]
    [IsoXmlTag("LtdCptlLossLvl")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LimitedCapitalLossLevel { get; init; }

    /// <summary>
    /// Specifies the product is compatible with a client who does not need capital guarantee nor protection. One hundred percent of the capital is at risk. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03040. In EMT v2, this is known as Compatible With Clients Who Do Not Need Capital Guarantee.
    /// </summary>
    [IsoId("_x7USkDcPEeiIxKQErQxblg")]
    [DisplayName("No Capital Guarantee")]
    [IsoXmlTag("NoCptlGrnt")]
    public TargetMarket1Code? NoCapitalGuarantee { get; init; }

    /// <summary>
    /// Specifies the product is compatible with a client who can bear loss beyond the capital. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03050. In EMT v2, this is known as Compatible With Clients Who Can Bear Loss Beyond Capital.
    /// </summary>
    [IsoId("_0YI6UDcPEeiIxKQErQxblg")]
    [DisplayName("Loss Beyond Capital")]
    [IsoXmlTag("LossByndCptl")]
    public TargetMarket1Code? LossBeyondCapital { get; init; }

    /// <summary>
    /// Specifies another type of loss bearing.
    /// </summary>
    [IsoId("_1Bc9EDcPEeiIxKQErQxblg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherTargetMarketLossBearing1? Other { get; init; }
}
