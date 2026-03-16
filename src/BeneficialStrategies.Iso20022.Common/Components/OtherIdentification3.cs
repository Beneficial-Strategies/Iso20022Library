// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other accepted financial instrument&apos;s identification than ISIN.
/// </summary>
[IsoId("_XqYXMAgaEeCVlvYcV4HKqQ")]
[DisplayName("Other Identification")]
public record OtherIdentification3
{
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_XqYXOAgaEeCVlvYcV4HKqQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax31Text)]
    [StringLength(maximumLength: 31, MinimumLength = 1)]
    public required IsoRestrictedFINXMax31Text Identification { get; init; }

    /// <summary>
    /// Identifies the suffix of the security identification.
    /// </summary>
    [IsoId("_XqYXQAgaEeCVlvYcV4HKqQ")]
    [DisplayName("Suffix")]
    [IsoXmlTag("Sfx")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? Suffix { get; init; }

    /// <summary>
    /// Type of the identification.
    /// </summary>
    [IsoId("_XqYXSQgaEeCVlvYcV4HKqQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IdentificationSource3Choice_ Type { get; init; }
}
