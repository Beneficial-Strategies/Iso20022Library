// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for digests.
/// </summary>
[IsoId("_CejOQQiuEeKn9O5oyej_zw")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification5
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_Cqv3NQiuEeKn9O5oyej_zw")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm5Code Algorithm { get; init; }
}
