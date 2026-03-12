// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of the RSAES-OAEP encryption algorithm (RSA Encryption Scheme: Optimal Asymmetric Encryption Padding).
/// </summary>
[IsoId("_MLB1AQurEeK6BpGAixa3eA")]
[DisplayName("Parameter")]
public partial record Parameter2
{
    #nullable enable
    
    /// <summary>
    /// Digest algorithm used in the RSAES-OAEP encryption algorithm (RSA Encryption Scheme: Optimal Asymmetric Encryption Padding).
    /// </summary>
    [IsoId("_KX3wIAu9EeK6BpGAixa3eA")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm5Code? DigestAlgorithm { get; init; } 
    
    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_Vz1dIAu9EeK6BpGAixa3eA")]
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public AlgorithmIdentification8? MaskGeneratorAlgorithm { get; init; } 
    
    
    #nullable disable
    
}
