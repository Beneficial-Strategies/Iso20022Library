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
[IsoId("_SnhZ4tp-Ed-ak6NoX_4Aeg_797411932")]
[DisplayName("Structured Regulatory Reporting")]
public record StructuredRegulatoryReporting3
{
    /// <summary>
    /// Specifies the type of the information supplied in the regulatory reporting details.
    /// </summary>
    [IsoId("_SnhZ49p-Ed-ak6NoX_4Aeg_-237266117")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Date related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_SnhZ5Np-Ed-ak6NoX_4Aeg_63801781")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Country related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_SnhZ5dp-Ed-ak6NoX_4Aeg_123830660")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Specifies the nature, purpose, and reason for the transaction to be reported for regulatory and statutory requirements in a coded form.
    /// </summary>
    [IsoId("_SnhZ5tp-Ed-ak6NoX_4Aeg_797412241")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? Code { get; init; }

    /// <summary>
    /// Amount of money to be reported for regulatory and statutory requirements.
    /// </summary>
    [IsoId("_SnhZ59p-Ed-ak6NoX_4Aeg_797412303")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Additional details that cater for specific domestic regulatory requirements.
    /// </summary>
    [IsoId("_SnhZ6Np-Ed-ak6NoX_4Aeg_797412333")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    public SimpleValueList<IsoMax35Text> Information { get; init; } = [];
}
