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
[IsoId("_Ol9RQItPEeSxlKlAGYErFg")]
[DisplayName("Public RSA Key")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PublicRSAKey1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PublicRSAKey1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PublicRSAKey1( System.Byte[] reqModulus,System.Byte[] reqExponent )
    {
        Modulus = reqModulus;
        Exponent = reqExponent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Modulus of the RSA key.
    /// </summary>
    [IsoId("_eGY5QItPEeSxlKlAGYErFg")]
    [DisplayName("Modulus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mdlus")]
    #endif
    [IsoXmlTag("Mdlus")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax5000Binary Modulus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Modulus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Modulus { get; init; } 
    #else
    public System.Byte[] Modulus { get; set; } 
    #endif
    
    /// <summary>
    /// Public exponent of the RSA key.
    /// </summary>
    [IsoId("_ifpYgItPEeSxlKlAGYErFg")]
    [DisplayName("Exponent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Expnt")]
    #endif
    [IsoXmlTag("Expnt")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax5000Binary Exponent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Exponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Exponent { get; init; } 
    #else
    public System.Byte[] Exponent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
