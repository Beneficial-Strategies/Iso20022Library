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
/// Contains encrypted data and the attributes used to encrypt the data using the ISO 13492 methods for data encryption.  The encryption key is not included in the message with this method.
/// </summary>
[IsoId("_JP9iYD6UEeq_lLaSkIVjTQ")]
[DisplayName("Encrypted Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EncryptedData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated control field format.
    /// See ISO 13492 Control field for values.
    /// </summary>
    [IsoId("_V_GHcD6UEeq_lLaSkIVjTQ")]
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
    /// Number that uniquely identifies a key or a group of related keys that are all different but have certain characteristics in common.
    /// See ISO 13492 Key-set identifier for usage.
    /// </summary>
    [IsoId("_lDTGcD6UEeq_lLaSkIVjTQ")]
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
    /// See ISO 13492 Derived information or Device ID and Transaction Counter for more information.
    /// </summary>
    [IsoId("_urqu4D6UEeq_lLaSkIVjTQ")]
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
    /// Defines the algorithm used for encryption.
    /// See ISO 13492 Algorithm field for values.
    /// </summary>
    [IsoId("_0fAmgD6UEeq_lLaSkIVjTQ")]
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
    /// Specifies the length of the encryption key.
    /// See ISO 13492 Key length field for value to use.
    /// </summary>
    [IsoId("_-EU68D6UEeq_lLaSkIVjTQ")]
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
    /// Mechanism used to provide key confidentiality and integrity. Identifies encryption attribute used for the data encryption operation.
    /// See ISO 13492 Key protection field for values.
    /// </summary>
    [IsoId("_JzhF8D6VEeq_lLaSkIVjTQ")]
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
    /// Identifies a unique key within a key set when multiple keys exist with the same key set identifier.
    /// See ISO 13492 Key index for more information.
    /// </summary>
    [IsoId("_PGI2ID6VEeq_lLaSkIVjTQ")]
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
    /// Identifies the padding method used prior to encipherment of the data.
    /// See ISO 13492 Padding method field for values.
    /// </summary>
    [IsoId("_XLGyID6VEeq_lLaSkIVjTQ")]
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
    /// Identifies the format of the structured data when the encrypted data block contains more than one data element.
    /// See ISO 13492 Encrypted data format field for values.
    /// </summary>
    [IsoId("_gh_pAD6VEeq_lLaSkIVjTQ")]
    [DisplayName("Encrypted Data Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdDataFrmt")]
    #endif
    [IsoXmlTag("NcrptdDataFrmt")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? EncryptedDataFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EncryptedDataFormat { get; init; } 
    #else
    public System.String? EncryptedDataFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted data element information.
    /// </summary>
    [IsoId("_r673MD6VEeq_lLaSkIVjTQ")]
    [DisplayName("Encrypted Data Element")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdDataElmt")]
    #endif
    [IsoXmlTag("NcrptdDataElmt")]
    public ValueList<EncryptedDataElement1> EncryptedDataElement { get; init; } = new ValueList<EncryptedDataElement1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _r673MD6VEeq_lLaSkIVjTQ
    
    
    #nullable disable
    
}
