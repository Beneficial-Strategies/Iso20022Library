// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for encryptions with a symmetric cryptographic key.
/// </summary>
[IsoId("_YSxbcaQtEeeWXKXf3KjtmQ")]
[DisplayName("Algorithm Identification")]
public partial record AlgorithmIdentification25
{
    #nullable enable
    
    /// <summary>
    /// Identification of the encryption algorithm.
    /// </summary>
    [IsoId("_YeYOgaQtEeeWXKXf3KjtmQ")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm23Code Algorithm { get; init; } 
    
    /// <summary>
    /// Parameters associated with the CBC (Chain Block Chaining) encryption algorithm.
    /// </summary>
    [IsoId("_YeYOg6QtEeeWXKXf3KjtmQ")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter7? Parameter { get; init; } 
    
    
    #nullable disable
    
}
