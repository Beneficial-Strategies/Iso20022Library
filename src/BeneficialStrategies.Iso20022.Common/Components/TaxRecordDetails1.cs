// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxRecordDetails1"/>
[IsoId("_RwPMldp-Ed-ak6NoX_4Aeg_-1423474117")]
[DisplayName("Tax Record Details")]
public partial record TaxRecordDetails1
{
    /// <inheritdoc cref="ITaxRecordDetails1.Period"/>
    [IsoId("_RwPMltp-Ed-ak6NoX_4Aeg_-1180585644")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod1? Period { get; init; }

    /// <inheritdoc cref="ITaxRecordDetails1.Amount"/>
    [IsoId("_RwPMl9p-Ed-ak6NoX_4Aeg_-1423474086")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
