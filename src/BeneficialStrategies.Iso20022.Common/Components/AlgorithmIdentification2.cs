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
[IsoId("_5JEMwQiFEeKN_O2h8Y6VcA")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_5WyfsQiFEeKN_O2h8Y6VcA")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm2Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    [IsoId("_5WyftQiFEeKN_O2h8Y6VcA")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter1? Parameter { get; init; } 
    
    
    #nullable disable
    
}
