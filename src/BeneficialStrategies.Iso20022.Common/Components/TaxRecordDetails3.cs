// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the individual tax amount(s) per period of the tax record.
/// </summary>
[IsoId("_oAWcqd4lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Record Details")]
public record TaxRecordDetails3
{
    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_oB4God4lEeqt1ZcLzWyWFw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod3? Period { get; init; }

    /// <summary>
    /// Underlying tax amount related to the specified period.
    /// </summary>
    [IsoId("_oB4Go94lEeqt1ZcLzWyWFw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
