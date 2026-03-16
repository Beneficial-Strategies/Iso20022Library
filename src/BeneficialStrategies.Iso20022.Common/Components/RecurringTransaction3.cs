// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[IsoId("_hH4hcK4wEeWpsoxRhdX-8A")]
[DisplayName("Recurring Transaction")]
public record RecurringTransaction3
{
    /// <summary>
    /// Date of first transfer.
    /// </summary>
    [IsoId("_hUsOba4wEeWpsoxRhdX-8A")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate StartDate { get; init; }

    /// <summary>
    /// Number of transfers to perform.
    /// </summary>
    [IsoId("_hUsOa64wEeWpsoxRhdX-8A")]
    [DisplayName("Number Of Occurrences")]
    [IsoXmlTag("NbOfOcrncs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfOccurrences { get; init; }

    /// <summary>
    /// Date of last transfer.
    /// </summary>
    [IsoId("_CTLosK4xEeWpsoxRhdX-8A")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EndDate { get; init; }

    /// <summary>
    /// Period of the recurring transfer.
    /// </summary>
    [IsoId("_hUsOZ64wEeWpsoxRhdX-8A")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency3Code? PeriodUnit { get; init; }

    /// <summary>
    /// Day of the period when the transfer will be performed.
    /// </summary>
    [IsoId("_hUsOaa4wEeWpsoxRhdX-8A")]
    [DisplayName("Interval Day")]
    [IsoXmlTag("IntrvlDay")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? IntervalDay { get; init; }
}
