// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Query based on ISIN or an alternative format for the identification of a financial instrument.
/// </summary>
[IsoId("_2unO9BvYEeWeg9zOuV6DZQ")]
[DisplayName("Security Identification Query Criteria")]
public record SecurityIdentificationQueryCriteria1
{
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_2unO9xvYEeWeg9zOuV6DZQ")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public SimpleValueList<IsoISINOct2015Identifier> ISIN { get; init; } = [];

    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_2unO9hvYEeWeg9zOuV6DZQ")]
    [DisplayName("Alternative Instrument Identification")]
    [IsoXmlTag("AltrntvInstrmId")]
    public SimpleValueList<IsoMax52Text> AlternativeInstrumentIdentification { get; init; } = [];
}
