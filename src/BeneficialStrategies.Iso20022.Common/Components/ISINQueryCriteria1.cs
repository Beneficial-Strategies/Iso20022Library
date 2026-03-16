// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the product through ISIN.
/// </summary>
[IsoId("_ZSH2YJNkEeytjZlcgApf6A")]
[DisplayName("ISIN Query Criteria")]
public record ISINQueryCriteria1
{
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_kIBo8JNkEeytjZlcgApf6A")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    public SimpleValueList<IsoISINOct2015Identifier> Identifier { get; init; } = [];

    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_2ud_oJNkEeytjZlcgApf6A")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; }
}
