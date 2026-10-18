// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_T-soNtp-Ed-ak6NoX_4Aeg_330596074")]
public interface IDatePeriodDetails : IIsoComponent
{
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_T-soN9p-Ed-ak6NoX_4Aeg_330596075")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    ISODate FromDate { get; }

    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_T-soONp-Ed-ak6NoX_4Aeg_330596076")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    ISODate ToDate { get; }
}
