// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
[IsoId("_VygD6ZqLEeWcAIE4lEkF_Q")]
[DisplayName("Security Identification")]
public record SecurityIdentification21
{
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_VygD9ZqLEeWcAIE4lEkF_Q")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? ISIN { get; init; }

    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_Vygq0ZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public ValueList<OtherIdentification2> OtherIdentification { get; init; } = [];

    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("_Vygq05qLEeWcAIE4lEkF_Q")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? Description { get; init; }
}
