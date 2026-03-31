// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of the asymmetric encryption algorithm.
/// </summary>
[IsoId("_Uj1egds2Eee9e6xduATmQg")]
[DisplayName("Parameter")]
public record Parameter10
{
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    [IsoId("_UtuaUds2Eee9e6xduATmQg")]
    [DisplayName("Encryption Format")]
    [IsoXmlTag("NcrptnFrmt")]
    public EncryptionFormat2Code? EncryptionFormat { get; init; }

    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_UtuaU9s2Eee9e6xduATmQg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm16Code? DigestAlgorithm { get; init; }

    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_UtuaVds2Eee9e6xduATmQg")]
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public AlgorithmIdentification18? MaskGeneratorAlgorithm { get; init; }
}
