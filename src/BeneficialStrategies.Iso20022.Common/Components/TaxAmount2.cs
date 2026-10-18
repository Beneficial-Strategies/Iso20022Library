// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxAmount2"/>
[IsoId("_yeA_Fa9fEeen6L7OP7lnvg")]
[DisplayName("Tax Amount")]
public partial record TaxAmount2
{
    /// <inheritdoc cref="ITaxAmount2.Rate"/>
    [IsoId("_yv3kA69fEeen6L7OP7lnvg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <inheritdoc cref="ITaxAmount2.TaxableBaseAmount"/>
    [IsoId("_yv3kBa9fEeen6L7OP7lnvg")]
    [DisplayName("Taxable Base Amount")]
    [IsoXmlTag("TaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxAmount2.TotalAmount"/>
    [IsoId("_yv3kB69fEeen6L7OP7lnvg")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <inheritdoc cref="ITaxAmount2.Details"/>
    [IsoId("_yv3kCa9fEeen6L7OP7lnvg")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public ValueList<TaxRecordDetails2> Details { get; init; } = [];
}
