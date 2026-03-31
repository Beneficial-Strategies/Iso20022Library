// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value of the public component of a RSA key.
/// </summary>
[IsoId("_Ol9RQItPEeSxlKlAGYErFg")]
[DisplayName("Public RSA Key")]
public record PublicRSAKey1
{
    /// <summary>
    /// Modulus of the RSA key.
    /// </summary>
    [IsoId("_eGY5QItPEeSxlKlAGYErFg")]
    [DisplayName("Modulus")]
    [IsoXmlTag("Mdlus")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public required IsoMax5000Binary Modulus { get; init; }

    /// <summary>
    /// Public exponent of the RSA key.
    /// </summary>
    [IsoId("_ifpYgItPEeSxlKlAGYErFg")]
    [DisplayName("Exponent")]
    [IsoXmlTag("Expnt")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public required IsoMax5000Binary Exponent { get; init; }
}
