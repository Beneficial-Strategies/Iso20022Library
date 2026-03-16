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
[IsoId("_9z5i4ds1Eee9e6xduATmQg")]
[DisplayName("Parameter")]
public record Parameter9
{
    /// <summary>
    /// Digest algorithm used in the mask generator function.
    /// </summary>
    [IsoId("_99De4ds1Eee9e6xduATmQg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm16Code? DigestAlgorithm { get; init; }
}
