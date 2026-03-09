// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value of the public component of a RSA key.
/// </summary>
[IsoId("_uH2O4Y4SEeW6h7rGyYlyTg")]
[DisplayName("Public RSA Key")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PublicRSAKey2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PublicRSAKey2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PublicRSAKey2( PublicRSAKey1 reqPublicKeyValue )
    {
        PublicKeyValue = reqPublicKeyValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Asymmetric cryptographic algorithm.
    /// </summary>
    [IsoId("_8M_koI4SEeW6h7rGyYlyTg")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm7Code? Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm7Code? Algorithm { get; init; } 
    #else
    public Algorithm7Code? Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Public key value.
    /// </summary>
    [IsoId("_Bo07MI4TEeW6h7rGyYlyTg")]
    [DisplayName("Public Key Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PblcKeyVal")]
    #endif
    [IsoXmlTag("PblcKeyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PublicRSAKey1 PublicKeyValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PublicRSAKey1 PublicKeyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PublicRSAKey1 PublicKeyValue { get; init; } 
    #else
    public PublicRSAKey1 PublicKeyValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
