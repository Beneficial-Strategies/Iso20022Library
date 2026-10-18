// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the individual tax amount(s) per period of the tax record.
/// </summary>
[IsoId("_oAWcqd4lEeqt1ZcLzWyWFw")]
public interface ITaxRecordDetails3 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_oB4God4lEeqt1ZcLzWyWFw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    ITaxPeriod3? Period { get; }

    /// <summary>
    /// Underlying tax amount related to the specified period.
    /// </summary>
    [IsoId("_oB4Go94lEeqt1ZcLzWyWFw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }
}
