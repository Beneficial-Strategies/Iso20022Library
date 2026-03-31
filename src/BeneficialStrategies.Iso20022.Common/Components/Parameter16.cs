// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameter16.
/// </summary>
[IsoId("_5lgsUY-DEe6oobnCtR50kw")]
[DisplayName("Parameter16")]
public record Parameter16
{
    /// <summary>
    /// Digest Algorithm.
    /// </summary>
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm26Code? DigestAlgorithm { get; init; }

    /// <summary>
    /// Mask Generator Algorithm.
    /// </summary>
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public AlgorithmIdentification34? MaskGeneratorAlgorithm { get; init; }

    /// <summary>
    /// OID Curve Name.
    /// </summary>
    [DisplayName("OID Curve Name")]
    [IsoXmlTag("OIDCrvNm")]
    public IsoMax140Text? OIDCurveName { get; init; }

    /// <summary>
    /// Salt Length.
    /// </summary>
    [DisplayName("Salt Length")]
    [IsoXmlTag("SaltLngth")]
    public IsoNumber? SaltLength { get; init; }

    /// <summary>
    /// Trailer Field.
    /// </summary>
    [DisplayName("Trailer Field")]
    [IsoXmlTag("TrlrFld")]
    public IsoNumber? TrailerField { get; init; }
}
