// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key that must be created and sent in the response, or that must be verified.
/// </summary>
[IsoId("_MXlzwXvOEeSCJdwgzb6SFw")]
[DisplayName("KEK Identifier")]
public record KEKIdentifier3
{
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("_eHEtQHvOEeSCJdwgzb6SFw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    [IsoId("_MkjRsXvOEeSCJdwgzb6SFw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Identification { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_MkjRs3vOEeSCJdwgzb6SFw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Version { get; init; }

    /// <summary>
    /// Value to check the key, for instance, result of the encryption of the null binary string.
    /// </summary>
    [IsoId("_k7IbAHvOEeSCJdwgzb6SFw")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? KeyCheckValue { get; init; }
}
