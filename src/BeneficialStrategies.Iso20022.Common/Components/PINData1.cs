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
/// Attributes of a cardholder PIN.
/// </summary>
[IsoId("_oIKMwEbYEeeIjf8aP9KbJA")]
[DisplayName("PIN Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PINData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PINData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PINData1( System.String reqPINBlockFormat,System.String reqEncryptedPINBlock )
    {
        PINBlockFormat = reqPINBlockFormat;
        EncryptedPINBlock = reqEncryptedPINBlock;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated control field format.
    /// ISO 13492
    /// Binary, length of 1
    /// </summary>
    [IsoId("_1o494InMEeiHerJAHfwamw")]
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
    [IsoId("_d0W1wotNEei2ytxdCDTOFQ")]
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
    /// Contains Derived Info or Device ID and Transaction Counter.
    /// ISO 13492
    /// Binary, lengths of 5, 8, 16 or 32 
    /// </summary>
    [IsoId("_03k44InQEeiHerJAHfwamw")]
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
    /// Used to select the encryption algorithm to encipher the keys contained in the associated key management data element. 
    /// ISO 13492
    /// </summary>
    [IsoId("_XqXiYInREeiHerJAHfwamw")]
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
    [IsoId("_u95wootNEei2ytxdCDTOFQ")]
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
    [IsoId("_W9lC8YnTEeiHerJAHfwamw")]
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
    /// Identifies a unique key set when multiple keys with the same key set identifier are used (for example, key rotation).
    /// ISO 13492
    /// Length of 2 or 5
    /// </summary>
    [IsoId("_85vZYotNEei2ytxdCDTOFQ")]
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
    /// As defined in ISO 9564-1. 
    /// </summary>
    [IsoId("_DiyMQYnVEeiHerJAHfwamw")]
    [DisplayName("PIN Block Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINBlckFrmt")]
    #endif
    [IsoXmlTag("PINBlckFrmt")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2NumericText PINBlockFormat { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PINBlockFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PINBlockFormat { get; init; } 
    #else
    public System.String PINBlockFormat { get; set; } 
    #endif
    
    /// <summary>
    /// As defined in ISO 9564-1. 
    /// Binary, length of 8 or 16
    /// </summary>
    [IsoId("_BbKmMInaEei2ytxdCDTOFQ")]
    [DisplayName("Encrypted PIN Block")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdPINBlck")]
    #endif
    [IsoXmlTag("NcrptdPINBlck")]
    [IsoSimpleType(IsoSimpleType.Max16HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16HexBinaryText EncryptedPINBlock { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EncryptedPINBlock { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EncryptedPINBlock { get; init; } 
    #else
    public System.String EncryptedPINBlock { get; set; } 
    #endif
    
    
    #nullable disable
    
}
