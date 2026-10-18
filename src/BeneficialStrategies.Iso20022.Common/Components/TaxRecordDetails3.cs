// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxRecordDetails3"/>
[IsoId("_oAWcqd4lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Record Details")]
public partial record TaxRecordDetails3
{
    /// <inheritdoc cref="ITaxRecordDetails3.Period"/>
    [IsoId("_oB4God4lEeqt1ZcLzWyWFw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod3? Period { get; init; }

    /// <inheritdoc cref="ITaxRecordDetails3.Amount"/>
    [IsoId("_oB4Go94lEeqt1ZcLzWyWFw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
