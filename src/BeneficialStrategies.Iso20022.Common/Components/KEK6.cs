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
/// Key encryption key (KEK), using previously distributed symmetric key.
/// </summary>
[IsoId("_tm7aodZ3EeeA4_YxLuyJaA")]
[DisplayName("KEK")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record KEK6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a KEK6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public KEK6( KEKIdentifier6 reqKEKIdentification,AlgorithmIdentification28 reqKeyEncryptionAlgorithm )
    {
        KEKIdentification = reqKEKIdentification;
        KeyEncryptionAlgorithm = reqKeyEncryptionAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_tyiNsdZ3EeeA4_YxLuyJaA")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Version { get; init; } 
    #else
    public System.UInt64? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the key encryption key (KEK).
    /// </summary>
    [IsoId("_tyiNs9Z3EeeA4_YxLuyJaA")]
    [DisplayName("KEK Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KEKId")]
    #endif
    [IsoXmlTag("KEKId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required KEKIdentifier6 KEKIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required KEKIdentifier6 KEKIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KEKIdentifier6 KEKIdentification { get; init; } 
    #else
    public KEKIdentifier6 KEKIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [IsoId("_tyiNtdZ3EeeA4_YxLuyJaA")]
    [DisplayName("Key Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyNcrptnAlgo")]
    #endif
    [IsoXmlTag("KeyNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification28 KeyEncryptionAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification28 KeyEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification28 KeyEncryptionAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification28 KeyEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [IsoId("_tyiNt9Z3EeeA4_YxLuyJaA")]
    [DisplayName("Encrypted Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdKey")]
    #endif
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Binary? EncryptedKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? EncryptedKey { get; init; } 
    #else
    public System.Byte[]? EncryptedKey { get; set; } 
    #endif
    
    
    #nullable disable
    
}
