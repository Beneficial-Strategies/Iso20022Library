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
[IsoId("_ckn7wTF2EeO118ZQJgaQSQ")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification10
{
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_c1bX4TF2EeO118ZQJgaQSQ")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm10Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    [IsoId("_c1bX4zF2EeO118ZQJgaQSQ")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter1? Parameter { get; init; } 
    
    
    #nullable disable
    
}
