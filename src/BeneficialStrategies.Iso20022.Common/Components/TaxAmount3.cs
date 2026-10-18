// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxAmount3"/>
[IsoId("_n-65U94lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Amount")]
public partial record TaxAmount3
{
    /// <inheritdoc cref="ITaxAmount3.Rate"/>
    [IsoId("_oAWcod4lEeqt1ZcLzWyWFw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <inheritdoc cref="ITaxAmount3.TaxableBaseAmount"/>
    [IsoId("_oAWco94lEeqt1ZcLzWyWFw")]
    [DisplayName("Taxable Base Amount")]
    [IsoXmlTag("TaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxAmount3.TotalAmount"/>
    [IsoId("_oAWcpd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <inheritdoc cref="ITaxAmount3.Details"/>
    [IsoId("_oAWcp94lEeqt1ZcLzWyWFw")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public ValueList<TaxRecordDetails3> Details { get; init; } = [];
}
