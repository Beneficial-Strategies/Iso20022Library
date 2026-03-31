// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters of digests.
/// </summary>
[IsoId("_Rng3gdtbEee9e6xduATmQg")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification21
{
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_RxYlMdtbEee9e6xduATmQg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm16Code Algorithm { get; init; }
}
