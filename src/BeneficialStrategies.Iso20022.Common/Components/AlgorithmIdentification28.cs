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
[IsoId("_SLZSkdZ3EeeA4_YxLuyJaA")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification28
{
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_SX5dgdZ3EeeA4_YxLuyJaA")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm13Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the encryption algorithm.
    /// </summary>
    [IsoId("_SX5dg9Z3EeeA4_YxLuyJaA")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter14? Parameter { get; init; } 
    
    
    #nullable disable
    
}
