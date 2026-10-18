// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRegulatoryReporting2"/>
[IsoId("_SnOe_9p-Ed-ak6NoX_4Aeg_699509907")]
[DisplayName("Structured Regulatory Reporting")]
public partial record StructuredRegulatoryReporting2
{
    /// <inheritdoc cref="IStructuredRegulatoryReporting2.Code"/>
    [IsoId("_SnYP8Np-Ed-ak6NoX_4Aeg_766002068")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? Code { get; init; }

    /// <inheritdoc cref="IStructuredRegulatoryReporting2.Amount"/>
    [IsoId("_SnYP8dp-Ed-ak6NoX_4Aeg_766002103")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CurrencyAndAmount? Amount { get; init; }

    /// <inheritdoc cref="IStructuredRegulatoryReporting2.Information"/>
    [IsoId("_SnYP8tp-Ed-ak6NoX_4Aeg_766002145")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Information { get; init; }
}
