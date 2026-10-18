// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Period of time details related to the tax payment.
/// </summary>
[IsoId("_zCdv5a9fEeen6L7OP7lnvg")]
public interface ITaxPeriod2 : IIsoComponent
{
    /// <summary>
    /// Year related to the tax payment.
    /// </summary>
    [IsoId("_zSrWIa9fEeen6L7OP7lnvg")]
    [DisplayName("Year")]
    [IsoXmlTag("Yr")]
    IsoISODate? Year { get; }

    /// <summary>
    /// Identification of the period related to the tax payment.
    /// </summary>
    [IsoId("_zSrWI69fEeen6L7OP7lnvg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    TaxRecordPeriod1Code? Type { get; }

    /// <summary>
    /// Range of time between a start date and an end date for which the tax report is provided.
    /// </summary>
    [IsoId("_zSrWJa9fEeen6L7OP7lnvg")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    IDatePeriod2? FromToDate { get; }
}
