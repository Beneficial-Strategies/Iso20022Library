// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value of the public component of a RSA key.
/// </summary>
[IsoId("_uH2O4Y4SEeW6h7rGyYlyTg")]
[DisplayName("Public RSA Key")]
public partial record PublicRSAKey2
{
    #nullable enable
    
    /// <summary>
    /// Asymmetric cryptographic algorithm.
    /// </summary>
    [IsoId("_8M_koI4SEeW6h7rGyYlyTg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public Algorithm7Code? Algorithm { get; init; } 
    
    /// <summary>
    /// Public key value.
    /// </summary>
    [IsoId("_Bo07MI4TEeW6h7rGyYlyTg")]
    [DisplayName("Public Key Value")]
    [IsoXmlTag("PblcKeyVal")]
    public required PublicRSAKey1 PublicKeyValue { get; init; } 
    
    
    #nullable disable
    
}
