// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification using a proprietary scheme.
/// </summary>
[IsoId("_Vyh485qLEeWcAIE4lEkF_Q")]
[DisplayName("Generic Identification")]
public record GenericIdentification79
{
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_Vyh495qLEeWcAIE4lEkF_Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax34Text)]
    [StringLength(maximumLength: 34, MinimumLength = 1)]
    public required IsoRestrictedFINXMax34Text Identification { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_Vyh4-ZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText Issuer { get; init; }

    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_Vyh4-5qLEeWcAIE4lEkF_Q")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4AlphaNumericText? SchemeName { get; init; }
}
