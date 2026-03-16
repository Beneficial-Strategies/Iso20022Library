// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithms and parameters for the protection of transported keys by an asymmetric key.
/// </summary>
[IsoId("_edXRcWi2EeS87LmvcA55sg")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification11
{
    /// <summary>
    /// Asymmetric encryption algorithm of a transport key.
    /// </summary>
    [IsoId("_esAKYWi2EeS87LmvcA55sg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm7Code Algorithm { get; init; }

    /// <summary>
    /// Parameters of the encryption algorithm.
    /// </summary>
    [IsoId("_esAKY2i2EeS87LmvcA55sg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter4? Parameter { get; init; }
}
