// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxRecordDetails2"/>
[IsoId("_yv3kC69fEeen6L7OP7lnvg")]
[DisplayName("Tax Record Details")]
public partial record TaxRecordDetails2
{
    /// <inheritdoc cref="ITaxRecordDetails2.Period"/>
    [IsoId("_zCdv4a9fEeen6L7OP7lnvg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod2? Period { get; init; }

    /// <inheritdoc cref="ITaxRecordDetails2.Amount"/>
    [IsoId("_zCdv469fEeen6L7OP7lnvg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
