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
[IsoId("_RwPMldp-Ed-ak6NoX_4Aeg_-1423474117")]
[DisplayName("Tax Record Details")]
public record TaxRecordDetails1
{
    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_RwPMltp-Ed-ak6NoX_4Aeg_-1180585644")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod1? Period { get; init; }

    /// <summary>
    /// Underlying tax amount related to the specified period.
    /// </summary>
    [IsoId("_RwPMl9p-Ed-ak6NoX_4Aeg_-1423474086")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
