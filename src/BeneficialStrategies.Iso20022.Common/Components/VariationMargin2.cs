// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards central counterparty.
/// </summary>
[IsoId("_Uk2CN9p-Ed-ak6NoX_4Aeg_1785473393")]
[DisplayName("Variation Margin2")]
public record VariationMargin2
{
    [IsoId("_Uk2CONp-Ed-ak6NoX_4Aeg_-292711042")]
    [DisplayName("Total Variation Margin")]
    [IsoXmlTag("TtlVartnMrgn")]
    [MinLength(1)]
    public ValueList<TotalVariationMargin1> TotalVariationMargin { get; init; } = [];

    [IsoId("_Uk_MINp-Ed-ak6NoX_4Aeg_-514484433")]
    [DisplayName("Total Mark To Market")]
    [IsoXmlTag("TtlMrkToMkt")]
    public required Amount2 TotalMarkToMarket { get; init; }

    [IsoId("_Uk_MIdp-Ed-ak6NoX_4Aeg_526741485")]
    [DisplayName("Mark To Market Netted")]
    [IsoXmlTag("MrkToMktNetd")]
    public ValueList<Amount2> MarkToMarketNetted { get; init; } = [];

    [IsoId("_Uk_MItp-Ed-ak6NoX_4Aeg_-859385259")]
    [DisplayName("Mark To Market Gross")]
    [IsoXmlTag("MrkToMktGrss")]
    public ValueList<Amount2> MarkToMarketGross { get; init; } = [];

    [IsoId("_Uk_MI9p-Ed-ak6NoX_4Aeg_-781100489")]
    [DisplayName("Mark To Market Fails")]
    [IsoXmlTag("MrkToMktFls")]
    public ValueList<Amount2> MarkToMarketFails { get; init; } = [];

    [IsoId("_Uk_MJNp-Ed-ak6NoX_4Aeg_1551318789")]
    [DisplayName("Fails Haircut")]
    [IsoXmlTag("FlsHrcut")]
    public required Amount2 FailsHaircut { get; init; }
}
