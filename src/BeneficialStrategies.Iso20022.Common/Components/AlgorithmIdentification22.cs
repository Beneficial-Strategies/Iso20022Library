// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cryptographic algorithm and parameters for the MAC computation.
/// </summary>
[IsoId("_KTW-UdtkEee9e6xduATmQg")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification22
{
    #nullable enable
    
    /// <summary>
    /// Identification of the MAC algorithm.
    /// </summary>
    [IsoId("_Kcco4dtkEee9e6xduATmQg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm17Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the MAC algorithm.
    /// </summary>
    [IsoId("_Kcco49tkEee9e6xduATmQg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter7? Parameter { get; init; } 
    
    
    #nullable disable
    
}
