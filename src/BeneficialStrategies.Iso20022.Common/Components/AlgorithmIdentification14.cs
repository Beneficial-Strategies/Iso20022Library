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
[IsoId("_IHpysWjBEeSP8Z8nx8HTuQ")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification14
{
    /// <summary>
    /// Identification of the encryption algorithm.
    /// </summary>
    [IsoId("_IUswMWjBEeSP8Z8nx8HTuQ")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm15Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated with the CBC (Chain Block Chaining) encryption algorithm.
    /// </summary>
    [IsoId("_IUswM2jBEeSP8Z8nx8HTuQ")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter6? Parameter { get; init; }
}
