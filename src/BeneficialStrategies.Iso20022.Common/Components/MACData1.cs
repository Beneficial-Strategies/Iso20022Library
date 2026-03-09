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
/// ISO 8583:87 bit 53 or 110
/// ISO 8583:93 bit 53 or 111
/// ISO 8583:2003 bit 53 or 50
/// </summary>
[IsoId("_pFv0qvGOEeiGNursv3uE_g")]
[DisplayName("MAC Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MACData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MACData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MACData1( System.String reqControl,System.String reqKeySetIdentifier,System.String reqAlgorithm )
    {
        Control = reqControl;
        KeySetIdentifier = reqKeySetIdentifier;
        Algorithm = reqAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated structure of the remainder of the data element.
    /// ISO 13492
    /// Binary, length of 1
    /// </summary>
    [IsoId("_pFv0q_GOEeiGNursv3uE_g")]
    [DisplayName("Control")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrl")]
    #endif
    [IsoXmlTag("Ctrl")]
    [IsoSimpleType(IsoSimpleType.Exact1HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact1HexBinaryText Control { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Control { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Control { get; init; } 
    #else
    public System.String Control { get; set; } 
    #endif
    
    /// <summary>
    /// key-set identifier is a number that uniquely identifies a group of related keys that are all different but have certain characteristics in common.
    /// ISO 13492
    /// lengths of 6 or 8
    /// </summary>
    [IsoId("_pFv0r_GOEeiGNursv3uE_g")]
    [DisplayName("Key Set Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeySetIdr")]
    #endif
    [IsoXmlTag("KeySetIdr")]
    [IsoSimpleType(IsoSimpleType.Max8NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax8NumericText KeySetIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String KeySetIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String KeySetIdentifier { get; init; } 
    #else
    public System.String KeySetIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Random number or counter in order to have a unique key per transaction. for example, UKPT PIN encryption or the transaction counter.
    /// ISO 13492
    /// Binary, lengths of 5, 8, 16 or 32 
    /// </summary>
    [IsoId("_pFv0sPGOEeiGNursv3uE_g")]
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
    [IsoId("_pFv0rfGOEeiGNursv3uE_g")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2NumericText Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Algorithm { get; init; } 
    #else
    public System.String Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the length of the keys being transported, not the encrypting key.
    /// ISO 13492
    /// </summary>
    [IsoId("_pFv0rvGOEeiGNursv3uE_g")]
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
    [IsoId("_pFv0rPGOEeiGNursv3uE_g")]
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
    [IsoId("_pFv0s_GOEeiGNursv3uE_g")]
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
    /// Identifies the padding method used for MAC.
    /// ISO 13492
    /// </summary>
    [IsoId("_pFv0svGOEeiGNursv3uE_g")]
    [DisplayName("Padding Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PddgMtd")]
    #endif
    [IsoXmlTag("PddgMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? PaddingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaddingMethod { get; init; } 
    #else
    public System.String? PaddingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Initialisation vector for CBC.
    /// ISO 13492
    /// Binary, lengths of  8, 16 or 32 
    /// </summary>
    [IsoId("_pFv0sfGOEeiGNursv3uE_g")]
    [DisplayName("Initialisation Vector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnVctr")]
    #endif
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max32HexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax32HexBinaryText? InitialisationVector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InitialisationVector { get; init; } 
    #else
    public System.String? InitialisationVector { get; set; } 
    #endif
    
    
    #nullable disable
    
}
