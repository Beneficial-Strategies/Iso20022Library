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
[IsoId("_T2MB8Wi3EeS87LmvcA55sg")]
[DisplayName("Parameter")]
public record Parameter4
{
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    [IsoId("_TVZzoGi4EeS87LmvcA55sg")]
    [DisplayName("Encryption Format")]
    [IsoXmlTag("NcrptnFrmt")]
    public EncryptionFormat1Code? EncryptionFormat { get; init; }

    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_UDGckWi3EeS87LmvcA55sg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm11Code? DigestAlgorithm { get; init; }

    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_UDGck2i3EeS87LmvcA55sg")]
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public AlgorithmIdentification12? MaskGeneratorAlgorithm { get; init; }
}
