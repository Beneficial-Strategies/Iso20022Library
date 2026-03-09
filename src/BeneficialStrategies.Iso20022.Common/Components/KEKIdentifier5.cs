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
/// Identification of a key encryption key (KEK), using previously distributed symmetric key.
/// </summary>
[IsoId("_gwCa4Y3_EeWRwov1g9WL_A")]
[DisplayName("KEK Identifier")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record KEKIdentifier5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a KEKIdentifier5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public KEKIdentifier5( System.String reqKeyIdentification,System.String reqKeyVersion )
    {
        KeyIdentification = reqKeyIdentification;
        KeyVersion = reqKeyVersion;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    [IsoId("_g7zmAY3_EeWRwov1g9WL_A")]
    [DisplayName("Key Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyId")]
    #endif
    [IsoXmlTag("KeyId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text KeyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String KeyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String KeyIdentification { get; init; } 
    #else
    public System.String KeyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_g7zmA43_EeWRwov1g9WL_A")]
    [DisplayName("Key Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyVrsn")]
    #endif
    [IsoXmlTag("KeyVrsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text KeyVersion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String KeyVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String KeyVersion { get; init; } 
    #else
    public System.String KeyVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Number of usages of the cryptographic key.
    /// </summary>
    [IsoId("_g7zmBY3_EeWRwov1g9WL_A")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SequenceNumber { get; init; } 
    #else
    public System.UInt64? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification used for derivation of a unique key from a master key provided for the data protection.
    /// </summary>
    [IsoId("_g7zmB43_EeWRwov1g9WL_A")]
    [DisplayName("Derivation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivtnId")]
    #endif
    [IsoXmlTag("DerivtnId")]
    [IsoSimpleType(IsoSimpleType.Min5Max16Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin5Max16Binary? DerivationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DerivationIdentification { get; init; } 
    #else
    public System.Byte[]? DerivationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_sNiY8I3_EeWRwov1g9WL_A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKeyType3Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKeyType3Code? Type { get; init; } 
    #else
    public CryptographicKeyType3Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_yrJ8oI3_EeWRwov1g9WL_A")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KeyUsage1Code? Function { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KeyUsage1Code? Function { get; init; } 
    #else
    public KeyUsage1Code? Function { get; set; } 
    #endif
    
    
    #nullable disable
    
}
