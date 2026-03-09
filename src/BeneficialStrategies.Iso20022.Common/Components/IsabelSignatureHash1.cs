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
/// Specifies the hash data for the file signature.
/// </summary>
[IsoId("_c4XEYKA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel Signature Hash")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelSignatureHash1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelSignatureHash1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelSignatureHash1( System.Byte[] reqHash,System.String reqAlgorithm )
    {
        Hash = reqHash;
        Algorithm = reqAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, that allows the detection of an accidental or intentional change to the data.
    /// </summary>
    [IsoId("_t71FoKMaEeWZDvWHgGXs7Q")]
    [DisplayName("Hash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hash")]
    #endif
    [IsoXmlTag("Hash")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax50Binary Hash { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Hash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Hash { get; init; } 
    #else
    public System.Byte[] Hash { get; set; } 
    #endif
    
    /// <summary>
    /// Effective method for calculating the signature hash using a finite sequence of instructions.
    /// </summary>
    [IsoId("_QFeEcKMbEeWZDvWHgGXs7Q")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax105Text Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Algorithm { get; init; } 
    #else
    public System.String Algorithm { get; set; } 
    #endif
    
    
    #nullable disable
    
}
