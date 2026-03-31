// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for the protection of the transported key.
/// </summary>
[IsoId("_l0wNQS9bEeOlZIh7PImd0A")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification9
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_mFQucS9bEeOlZIh7PImd0A")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm9Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    [IsoId("_mFQucy9bEeOlZIh7PImd0A")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter1? Parameter { get; init; }
}
