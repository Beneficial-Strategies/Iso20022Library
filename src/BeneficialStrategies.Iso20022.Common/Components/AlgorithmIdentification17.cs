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
[IsoId("_-kaEUWmQEeS7iYydEtv3Ug")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification17
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_-xbzsWmQEeS7iYydEtv3Ug")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm14Code Algorithm { get; init; }

    /// <summary>
    /// Parameters of the RSASSA-PSS digital signature algorithm (RSA signature algorithm with appendix: Probabilistic Signature Scheme).
    /// </summary>
    [IsoId("_XMPVsGmREeS7iYydEtv3Ug")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter8? Parameter { get; init; }
}
