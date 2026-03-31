// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mask generator function cryptographic algorithm and parameters.
/// </summary>
[IsoId("_t4S58aRPEeeWXKXf3KjtmQ")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification26
{
    /// <summary>
    /// Mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_uD5tAaRPEeeWXKXf3KjtmQ")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm8Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated to the mask generator function cryptographic algorithm
    /// </summary>
    [IsoId("_uD5tA6RPEeeWXKXf3KjtmQ")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Algorithm5Code? Parameter { get; init; }
}
