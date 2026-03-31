// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor’s ability to bear losses.
/// </summary>
[IsoId("_jWdr8bSaEeq-6ssAXwSh-g")]
[DisplayName("Loss Bearing")]
public record LossBearing2
{
    /// <summary>
    /// Specifies whether the product is compatible with a client who cannot bear loss of capital. Minor losses especially due to costs are possible. For a negative target (no), the product should not be sold to investors that cannot bear losses. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03010.
    /// </summary>
    [IsoId("_joeB8bSaEeq-6ssAXwSh-g")]
    [DisplayName("No Capital Loss")]
    [IsoXmlTag("NoCptlLoss")]
    public TargetMarket1Code? NoCapitalLoss { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with a client who is seeking to preserve capital or who can bear losses limited to a level specified by a structured security or structure fund product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03020.
    /// </summary>
    [IsoId("_joeB87SaEeq-6ssAXwSh-g")]
    [DisplayName("Limited Capital Loss")]
    [IsoXmlTag("LtdCptlLoss")]
    public TargetMarket1Code? LimitedCapitalLoss { get; init; }

    /// <summary>
    /// Specifies the percentage of loss that can be carried by the investor. This is only specified when a clear partial capital guarantee is provided on the primary market. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03030.
    /// </summary>
    [IsoId("_joeB9bSaEeq-6ssAXwSh-g")]
    [DisplayName("Limited Capital Loss Level")]
    [IsoXmlTag("LtdCptlLossLvl")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LimitedCapitalLossLevel { get; init; }

    /// <summary>
    /// Specifies the product is compatible with a client who does not need capital guarantee nor protection. One hundred percent of the capital is at risk. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03040.
    /// </summary>
    [IsoId("_joeB97SaEeq-6ssAXwSh-g")]
    [DisplayName("No Capital Guarantee")]
    [IsoXmlTag("NoCptlGrnt")]
    public TargetMarket1Code? NoCapitalGuarantee { get; init; }

    /// <summary>
    /// Specifies the product is compatible with a client who can bear loss beyond the capital. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 03050.
    /// </summary>
    [IsoId("_joeB-bSaEeq-6ssAXwSh-g")]
    [DisplayName("Loss Beyond Capital")]
    [IsoXmlTag("LossByndCptl")]
    public TargetMarket1Code? LossBeyondCapital { get; init; }

    /// <summary>
    /// Specifies another type of loss bearing.
    /// </summary>
    [IsoId("_joeB-7SaEeq-6ssAXwSh-g")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherTargetMarketLossBearing1> Other { get; init; } = [];
}
