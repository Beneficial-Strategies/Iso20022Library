// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of the RSASSA-PSS digital signature algorithm (RSA signature algorithm with appendix: Probabilistic Signature Scheme).
/// </summary>
[IsoId("_AU-_wdtbEee9e6xduATmQg")]
[DisplayName("Parameter")]
public record Parameter11
{
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_AeEDQdtbEee9e6xduATmQg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required Algorithm16Code DigestAlgorithm { get; init; }

    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_AeEDQ9tbEee9e6xduATmQg")]
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public required AlgorithmIdentification12 MaskGeneratorAlgorithm { get; init; }

    /// <summary>
    /// Length of the salt to include in the signature.
    /// </summary>
    [IsoId("_AeEDRdtbEee9e6xduATmQg")]
    [DisplayName("Salt Length")]
    [IsoXmlTag("SaltLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber SaltLength { get; init; }

    /// <summary>
    /// Trailer field number.
    /// </summary>
    [IsoId("_AeEDR9tbEee9e6xduATmQg")]
    [DisplayName("Trailer Field")]
    [IsoXmlTag("TrlrFld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TrailerField { get; init; }
}
