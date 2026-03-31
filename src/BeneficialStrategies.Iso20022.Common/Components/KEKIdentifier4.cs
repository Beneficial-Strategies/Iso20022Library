// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic key involved in the security command.
/// </summary>
[IsoId("_21LV8YtJEeSxlKlAGYErFg")]
[DisplayName("KEK Identifier")]
public record KEKIdentifier4
{
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("_3Bi-AYtJEeSxlKlAGYErFg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    [IsoId("_3Bi-A4tJEeSxlKlAGYErFg")]
    [DisplayName("Key Identification")]
    [IsoXmlTag("KeyId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? KeyIdentification { get; init; }

    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_3Bi-BYtJEeSxlKlAGYErFg")]
    [DisplayName("Key Version")]
    [IsoXmlTag("KeyVrsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? KeyVersion { get; init; }
}
