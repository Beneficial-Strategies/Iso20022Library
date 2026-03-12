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
[IsoId("_KFkI0ds2Eee9e6xduATmQg")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification18
{
    #nullable enable
    
    /// <summary>
    /// Mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_KQJoMds2Eee9e6xduATmQg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm8Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_KQJoM9s2Eee9e6xduATmQg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter9? Parameter { get; init; } 
    
    
    #nullable disable
    
}
