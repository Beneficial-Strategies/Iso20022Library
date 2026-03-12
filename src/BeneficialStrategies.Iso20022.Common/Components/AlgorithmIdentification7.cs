// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithms and parameters for the protection of transported keys by an asymmetric key.
/// </summary>
[IsoId("_I_Ox8QusEeK6BpGAixa3eA")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification7
{
    #nullable enable
    
    /// <summary>
    /// Asymmetric encryption algorithm of a transport key.
    /// </summary>
    [IsoId("_JMejwQusEeK6BpGAixa3eA")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm7Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters of the RSAES-OAEP encryption algorithm (RSA Encryption Scheme: Optimal Asymmetric Encryption Padding).
    /// </summary>
    [IsoId("_JMejxQusEeK6BpGAixa3eA")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter2? Parameter { get; init; } 
    
    
    #nullable disable
    
}
