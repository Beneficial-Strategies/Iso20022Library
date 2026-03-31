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
[IsoId("_G4BX4S_JEeugIJ3Gvoevmg")]
[DisplayName("Parameter")]
public record Parameter15
{
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_HC81gS_JEeugIJ3Gvoevmg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm16Code? DigestAlgorithm { get; init; }

    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_HC81gy_JEeugIJ3Gvoevmg")]
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public AlgorithmIdentification12? MaskGeneratorAlgorithm { get; init; }

    /// <summary>
    /// Length of the salt to include in the signature.
    /// </summary>
    [IsoId("_HC81hS_JEeugIJ3Gvoevmg")]
    [DisplayName("Salt Length")]
    [IsoXmlTag("SaltLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SaltLength { get; init; }

    /// <summary>
    /// Trailer field number.
    /// </summary>
    [IsoId("_HC81hy_JEeugIJ3Gvoevmg")]
    [DisplayName("Trailer Field")]
    [IsoXmlTag("TrlrFld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TrailerField { get; init; }

    /// <summary>
    /// Name of the Elliptic Curve according to the OID notation.
    /// </summary>
    [IsoId("_WPWHMC_JEeugIJ3Gvoevmg")]
    [DisplayName("OID Curve Name")]
    [IsoXmlTag("OIDCrvNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? OIDCurveName { get; init; }
}
