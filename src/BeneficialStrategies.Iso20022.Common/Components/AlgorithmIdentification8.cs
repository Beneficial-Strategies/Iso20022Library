// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mask generator function cryptographic algorithm and parameters.
/// </summary>
[IsoId("_KpAzMQusEeK6BpGAixa3eA")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification8
{
    #nullable enable
    
    /// <summary>
    /// Mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_K1NcIQusEeK6BpGAixa3eA")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm8Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_K1NcJQusEeK6BpGAixa3eA")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter3? Parameter { get; init; } 
    
    
    #nullable disable
    
}
