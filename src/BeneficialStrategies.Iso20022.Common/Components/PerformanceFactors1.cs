// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Performance factors of the investment fund / fund class.
/// </summary>
[IsoId("_TTfIAtp-Ed-ak6NoX_4Aeg_1116778698")]
[DisplayName("Performance Factors")]
public record PerformanceFactors1
{
    /// <summary>
    /// Value of the NAV before all corporate events of the valuation date, divided by the value of the NAV after the corporate event.
    /// </summary>
    [IsoId("_TTfIA9p-Ed-ak6NoX_4Aeg_-359866902")]
    [DisplayName("Corporate Action Factor")]
    [IsoXmlTag("CorpActnFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? CorporateActionFactor { get; init; }

    /// <summary>
    /// Value of the NAV before a corporate event, divided by the value of the NAV after the corporate event, accumulated for a number of corporate events over the defined period of time.
    /// </summary>
    [IsoId("_TTfIBNp-Ed-ak6NoX_4Aeg_-358021142")]
    [DisplayName("Cumulative Corporate Action Factor")]
    [IsoXmlTag("CmltvCorpActnFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? CumulativeCorporateActionFactor { get; init; }

    /// <summary>
    /// Period of time for the calculation of the cumulative corporate action factor.
    /// </summary>
    [IsoId("_TTfIBdp-Ed-ak6NoX_4Aeg_-1211048401")]
    [DisplayName("Accumulation Period")]
    [IsoXmlTag("AcmltnPrd")]
    public DatePeriodDetails? AccumulationPeriod { get; init; }

    /// <summary>
    /// Normal performance value of the NAV.
    /// </summary>
    [IsoId("_TTfIBtp-Ed-ak6NoX_4Aeg_-357097187")]
    [DisplayName("Normal Performance")]
    [IsoXmlTag("NrmlPrfrmnc")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? NormalPerformance { get; init; }
}
