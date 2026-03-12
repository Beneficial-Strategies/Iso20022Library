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
[IsoId("_34gZcQipEeKn9O5oyej_zw")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_4Ej4cQipEeKn9O5oyej_zw")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm3Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    [IsoId("_4Ej4dQipEeKn9O5oyej_zw")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter1? Parameter { get; init; } 
    
    
    #nullable disable
    
}
