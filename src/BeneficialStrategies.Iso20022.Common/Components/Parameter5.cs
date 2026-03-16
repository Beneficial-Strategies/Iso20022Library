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
[IsoId("_fKsxMWi5EeS87LmvcA55sg")]
[DisplayName("Parameter")]
public record Parameter5
{
    /// <summary>
    /// Digest algorithm used in the mask generator function.
    /// </summary>
    [IsoId("_fX1OQWi5EeS87LmvcA55sg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm11Code? DigestAlgorithm { get; init; }
}
