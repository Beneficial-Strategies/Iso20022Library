// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cryptographic algorithm and parameters for digital signatures.
/// </summary>
[IsoId("_NDLK8QirEeKn9O5oyej_zw")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification4
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_NO7vBQirEeKn9O5oyej_zw")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm4Code Algorithm { get; init; }
}
