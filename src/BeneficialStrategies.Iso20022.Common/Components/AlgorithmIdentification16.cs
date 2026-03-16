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
[IsoId("_BHYz4WmQEeS7iYydEtv3Ug")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification16
{
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_BUusUWmQEeS7iYydEtv3Ug")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm11Code Algorithm { get; init; }
}
