// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_Lk9JgUavEemG5fbqCekzMw")]
public interface IDatePeriod3 : IIsoComponent
{
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_Lx7OgUavEemG5fbqCekzMw")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    IsoISODate FromDate { get; }

    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_Lx7Og0avEemG5fbqCekzMw")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    IsoISODate? ToDate { get; }
}
