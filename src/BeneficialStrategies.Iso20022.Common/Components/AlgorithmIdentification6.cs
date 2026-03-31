// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for encryptions with a symmetric cryptographic key.
/// </summary>
[IsoId("_6M32gQiuEeKn9O5oyej_zw")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification6
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_6YxkhQiuEeKn9O5oyej_zw")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm6Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated with the algorithm.
    /// </summary>
    [IsoId("_6YxkjAiuEeKn9O5oyej_zw")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter1? Parameter { get; init; }
}
