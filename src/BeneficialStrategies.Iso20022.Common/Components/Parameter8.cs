// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of the RSASSA-PSS digital signature algorithm (RSA signature algorithm with appendix: Probabilistic Signature Scheme).
/// </summary>
[IsoId("_fYx5UWmREeS7iYydEtv3Ug")]
[DisplayName("Parameter")]
public partial record Parameter8
{
    #nullable enable
    
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_fmEuc2mREeS7iYydEtv3Ug")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required Algorithm11Code DigestAlgorithm { get; init; } 
    
    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_fmEudWmREeS7iYydEtv3Ug")]
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public required AlgorithmIdentification12 MaskGeneratorAlgorithm { get; init; } 
    
    /// <summary>
    /// Length of the salt to include in the signature.
    /// </summary>
    [IsoId("_3JFFwGmREeS7iYydEtv3Ug")]
    [DisplayName("Salt Length")]
    [IsoXmlTag("SaltLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber SaltLength { get; init; } 
    
    /// <summary>
    /// Trailer field number.
    /// </summary>
    [IsoId("_9NBlMGmREeS7iYydEtv3Ug")]
    [DisplayName("Trailer Field")]
    [IsoXmlTag("TrlrFld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TrailerField { get; init; } 
    
    
    #nullable disable
    
}
