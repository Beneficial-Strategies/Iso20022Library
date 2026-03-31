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
[IsoId("_CZaA8QxlEeqEbo60f0v6aw")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification29
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_CkGOAQxlEeqEbo60f0v6aw")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm24Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated to the encryption algorithm.
    /// </summary>
    [IsoId("_CkGOAwxlEeqEbo60f0v6aw")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter12? Parameter { get; init; }
}
