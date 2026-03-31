// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and statutory requirements.
/// </summary>
[IsoId("_SnOe_9p-Ed-ak6NoX_4Aeg_699509907")]
[DisplayName("Structured Regulatory Reporting")]
public record StructuredRegulatoryReporting2
{
    /// <summary>
    /// Specifies the nature, purpose, and reason for the transaction to be reported for regulatory and statutory requirements in a coded form.
    /// </summary>
    [IsoId("_SnYP8Np-Ed-ak6NoX_4Aeg_766002068")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? Code { get; init; }

    /// <summary>
    /// Amount of money to be reported for regulatory and statutory requirements.
    /// </summary>
    [IsoId("_SnYP8dp-Ed-ak6NoX_4Aeg_766002103")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Additional details that cater for specific domestic regulatory requirements.||Usage: Information is used to provide details that are not catered for in the Code or/and Amount elements.
    /// </summary>
    [IsoId("_SnYP8tp-Ed-ak6NoX_4Aeg_766002145")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Information { get; init; }
}
