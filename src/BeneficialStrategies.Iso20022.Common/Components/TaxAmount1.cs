// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxAmount1"/>
[IsoId("_RwGCpNp-Ed-ak6NoX_4Aeg_-1186076323")]
[DisplayName("Tax Amount")]
public partial record TaxAmount1
{
    /// <inheritdoc cref="ITaxAmount1.Rate"/>
    [IsoId("_RwGCpdp-Ed-ak6NoX_4Aeg_-1186076014")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <inheritdoc cref="ITaxAmount1.TaxableBaseAmount"/>
    [IsoId("_RwGCptp-Ed-ak6NoX_4Aeg_-1186075922")]
    [DisplayName("Taxable Base Amount")]
    [IsoXmlTag("TaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxAmount1.TotalAmount"/>
    [IsoId("_RwGCp9p-Ed-ak6NoX_4Aeg_-1186075952")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <inheritdoc cref="ITaxAmount1.Details"/>
    [IsoId("_RwPMkNp-Ed-ak6NoX_4Aeg_-515652974")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public ValueList<TaxRecordDetails1> Details { get; init; } = [];
}
