// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_lZP5MYaDEee8r9VKRbnJSg")]
public interface IDatePeriod2 : IIsoComponent
{
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_lhvG0YaDEee8r9VKRbnJSg")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    IsoISODate FromDate { get; }

    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_lhvG04aDEee8r9VKRbnJSg")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    IsoISODate ToDate { get; }
}
