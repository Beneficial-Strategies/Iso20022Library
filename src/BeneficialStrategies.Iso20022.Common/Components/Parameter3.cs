// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters associated to a mask generator cryptographic function.
/// </summary>
[IsoId("_X5JB8QurEeK6BpGAixa3eA")]
[DisplayName("Parameter")]
public record Parameter3
{
    /// <summary>
    /// Digest algorithm used in the mask generator function.
    /// </summary>
    [IsoId("_ueLVIAurEeK6BpGAixa3eA")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm5Code? DigestAlgorithm { get; init; }
}
