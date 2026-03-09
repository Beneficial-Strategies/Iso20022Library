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
/// Contains data related to key exchange activity.
/// </summary>
[IsoId("_ciSS0f5tEeiLerArw36g0w")]
[DisplayName("Key Exchange Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record KeyExchangeData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated structure of the remainder of the data element
    /// ISO 13492
    /// Binary, length of 1
    /// </summary>
    [IsoId("_cshM4f5tEeiLerArw36g0w")]
    [DisplayName("Control")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrl")]
    #endif
    [IsoXmlTag("Ctrl")]
    [IsoSimpleType(IsoSimpleType.Exact1HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1HexBinaryText? Control { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Control { get; init; } 
    #else
    public System.String? Control { get; set; } 
    #endif
    
    /// <summary>
    /// key-set identifier is a number that uniquely identifies a group of related keys that are all different but have certain characteristics in common.
    /// ISO 13492
    /// lengths of 6 or 8
    /// </summary>
    [IsoId("_cshM4_5tEeiLerArw36g0w")]
    [DisplayName("Key Set Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeySetIdr")]
    #endif
    [IsoXmlTag("KeySetIdr")]
    [IsoSimpleType(IsoSimpleType.Max8NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8NumericText? KeySetIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeySetIdentifier { get; init; } 
    #else
    public System.String? KeySetIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Random number or counter in order to have a unique key per transaction. for example, UKPT PIN encryption or contains the transaction counter.
    /// ISO 13492
    /// Binary, lengths of 5, 8, 16 or 32 
    /// </summary>
    [IsoId("_cshM7f5tEeiLerArw36g0w")]
    [DisplayName("Derived Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvdInf")]
    #endif
    [IsoXmlTag("DrvdInf")]
    [IsoSimpleType(IsoSimpleType.Max32HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax32HexBinaryText? DerivedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DerivedInformation { get; init; } 
    #else
    public System.String? DerivedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Selects the encryption algorithm used to encipher the keys contained in the associated key management data element.
    /// ISO 13492
    /// </summary>
    [IsoId("_cshM6_5tEeiLerArw36g0w")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Algorithm { get; init; } 
    #else
    public System.String? Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the length of the keys being transported, not the encrypting key.
    /// ISO 13492
    /// </summary>
    [IsoId("_cshM5_5tEeiLerArw36g0w")]
    [DisplayName("Key Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyLngth")]
    #endif
    [IsoXmlTag("KeyLngth")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? KeyLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeyLength { get; init; } 
    #else
    public System.String? KeyLength { get; set; } 
    #endif
    
    /// <summary>
    /// Mechanism used to provide key confidentiality and integrity. 
    /// ISO 13492
    /// </summary>
    [IsoId("_cshM6f5tEeiLerArw36g0w")]
    [DisplayName("Key Protection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyPrtcn")]
    #endif
    [IsoXmlTag("KeyPrtcn")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? KeyProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeyProtection { get; init; } 
    #else
    public System.String? KeyProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a unique key set when multiple keys with the same key set identifier are used. for example, key rotation.
    /// ISO 13492
    /// Length of 2 or 5
    /// </summary>
    [IsoId("_cshM5f5tEeiLerArw36g0w")]
    [DisplayName("Key Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyIndx")]
    #endif
    [IsoXmlTag("KeyIndx")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? KeyIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeyIndex { get; init; } 
    #else
    public System.String? KeyIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Uses a structure within it prior to encryption to identify the data.
    /// Binary, length of 8 up to 9999 
    /// </summary>
    [IsoId("_fPXHoP5uEeiLerArw36g0w")]
    [DisplayName("Encrypted Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdData")]
    #endif
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max9999HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax9999HexBinaryText? EncryptedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EncryptedData { get; init; } 
    #else
    public System.String? EncryptedData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a value used to verify a conveyed key. Length depends on the algorithm used. 
    /// Binary, length of 8 up to 9999 
    /// </summary>
    [IsoId("_jF57YP5uEeiLerArw36g0w")]
    [DisplayName("Key Checksum Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyChcksmVal")]
    #endif
    [IsoXmlTag("KeyChcksmVal")]
    [IsoSimpleType(IsoSimpleType.Max9999HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax9999HexBinaryText? KeyChecksumValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeyChecksumValue { get; init; } 
    #else
    public System.String? KeyChecksumValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
