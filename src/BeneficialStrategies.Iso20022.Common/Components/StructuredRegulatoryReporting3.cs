// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRegulatoryReporting3"/>
[IsoId("_SnhZ4tp-Ed-ak6NoX_4Aeg_797411932")]
[DisplayName("Structured Regulatory Reporting")]
public partial record StructuredRegulatoryReporting3
{
    /// <inheritdoc cref="IStructuredRegulatoryReporting3.Type"/>
    [IsoId("_SnhZ49p-Ed-ak6NoX_4Aeg_-237266117")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <inheritdoc cref="IStructuredRegulatoryReporting3.Date"/>
    [IsoId("_SnhZ5Np-Ed-ak6NoX_4Aeg_63801781")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="IStructuredRegulatoryReporting3.Country"/>
    [IsoId("_SnhZ5dp-Ed-ak6NoX_4Aeg_123830660")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <inheritdoc cref="IStructuredRegulatoryReporting3.Code"/>
    [IsoId("_SnhZ5tp-Ed-ak6NoX_4Aeg_797412241")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? Code { get; init; }

    /// <inheritdoc cref="IStructuredRegulatoryReporting3.Amount"/>
    [IsoId("_SnhZ59p-Ed-ak6NoX_4Aeg_797412303")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <inheritdoc cref="IStructuredRegulatoryReporting3.Information"/>
    [IsoId("_SnhZ6Np-Ed-ak6NoX_4Aeg_797412333")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    public SimpleValueList<IsoMax35Text> Information { get; init; } = [];
}
