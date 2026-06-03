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
[IsoId("41d883f7-39bf-4e64-9d91-7a8b3c8e1e8f")]
[DisplayName("Performance Factors5")]
public record PerformanceFactors5
{
    /// <summary>
    /// Value of the NAV before all corporate events of the valuation date, divided by the value of the NAV after the corporate event.
    /// </summary>
    [IsoId("0b0c386a-e37a-4aee-9206-d3a93773f52e")]
    [DisplayName("Corporate Action Factor")]
    [IsoXmlTag("CorpActnFctr")]
    public IsoDecimalNumber? CorporateActionFactor { get; init; }

    /// <summary>
    /// Value of the NAV before a corporate event, divided by the value of the NAV after the corporate event, accumulated for a number of corporate events over the defined period of time.
    /// </summary>
    [IsoId("46d6c844-0e2a-4291-b1f3-5dc742853bc9")]
    [DisplayName("Cumulative Corporate Action Factor")]
    [IsoXmlTag("CmltvCorpActnFctr")]
    public IsoDecimalNumber? CumulativeCorporateActionFactor { get; init; }

    /// <summary>
    /// Period of time for the calculation of the cumulative corporate action factor.
    /// </summary>
    [IsoId("ce623689-7e54-4815-8835-bc117a491940")]
    [DisplayName("Accumulation Period")]
    [IsoXmlTag("AcmltnPrd")]
    public DatePeriod2? AccumulationPeriod { get; init; }

    /// <summary>
    /// Normal performance value of the NAV.
    /// </summary>
    [IsoId("5455c937-00e0-4288-852a-805aa53c6939")]
    [DisplayName("Normal Performance")]
    [IsoXmlTag("NrmlPrfrmnc")]
    public IsoDecimalNumber? NormalPerformance { get; init; }
}
