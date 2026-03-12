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
[IsoId("_m4fhods2Eee9e6xduATmQg")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification19
{
    #nullable enable
    
    /// <summary>
    /// Asymmetric encryption algorithm of a transport key.
    /// </summary>
    [IsoId("_nCNeUds2Eee9e6xduATmQg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm7Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters of the encryption algorithm.
    /// </summary>
    [IsoId("_nCNeU9s2Eee9e6xduATmQg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter10? Parameter { get; init; } 
    
    
    #nullable disable
    
}
