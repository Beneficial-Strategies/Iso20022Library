// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for the protection of the transported key.
/// </summary>
[IsoId("_ocQmsWi6EeS87LmvcA55sg")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification13
{
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_opqJgWi6EeS87LmvcA55sg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm13Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the encryption algorithm.
    /// </summary>
    [IsoId("_opqwkGi6EeS87LmvcA55sg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter6? Parameter { get; init; } 
    
    
    #nullable disable
    
}
