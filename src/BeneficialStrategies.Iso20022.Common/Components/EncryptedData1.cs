// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains encrypted data and the attributes used to encrypt the data using the ISO 13492 methods for data encryption.  The encryption key is not included in the message with this method.
/// </summary>
[IsoId("_JP9iYD6UEeq_lLaSkIVjTQ")]
[DisplayName("Encrypted Data")]
public partial record EncryptedData1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated control field format.
    /// See ISO 13492 Control field for values.
    /// </summary>
    [IsoId("_V_GHcD6UEeq_lLaSkIVjTQ")]
    [DisplayName("Control")]
    [IsoXmlTag("Ctrl")]
    [IsoSimpleType(IsoSimpleType.Exact1HexBinaryText)]
    public IsoExact1HexBinaryText? Control { get; init; } 
    
    /// <summary>
    /// Number that uniquely identifies a key or a group of related keys that are all different but have certain characteristics in common.
    /// See ISO 13492 Key-set identifier for usage.
    /// </summary>
    [IsoId("_lDTGcD6UEeq_lLaSkIVjTQ")]
    [DisplayName("Key Set Identifier")]
    [IsoXmlTag("KeySetIdr")]
    [IsoSimpleType(IsoSimpleType.Max8NumericText)]
    public IsoMax8NumericText? KeySetIdentifier { get; init; } 
    
    /// <summary>
    /// Contains Derived Info or Device ID and Transaction Counter.
    /// See ISO 13492 Derived information or Device ID and Transaction Counter for more information.
    /// </summary>
    [IsoId("_urqu4D6UEeq_lLaSkIVjTQ")]
    [DisplayName("Derived Information")]
    [IsoXmlTag("DrvdInf")]
    [IsoSimpleType(IsoSimpleType.Max32HexBinaryText)]
    public IsoMax32HexBinaryText? DerivedInformation { get; init; } 
    
    /// <summary>
    /// Defines the algorithm used for encryption.
    /// See ISO 13492 Algorithm field for values.
    /// </summary>
    [IsoId("_0fAmgD6UEeq_lLaSkIVjTQ")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Algorithm { get; init; } 
    
    /// <summary>
    /// Specifies the length of the encryption key.
    /// See ISO 13492 Key length field for value to use.
    /// </summary>
    [IsoId("_-EU68D6UEeq_lLaSkIVjTQ")]
    [DisplayName("Key Length")]
    [IsoXmlTag("KeyLngth")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? KeyLength { get; init; } 
    
    /// <summary>
    /// Mechanism used to provide key confidentiality and integrity. Identifies encryption attribute used for the data encryption operation.
    /// See ISO 13492 Key protection field for values.
    /// </summary>
    [IsoId("_JzhF8D6VEeq_lLaSkIVjTQ")]
    [DisplayName("Key Protection")]
    [IsoXmlTag("KeyPrtcn")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? KeyProtection { get; init; } 
    
    /// <summary>
    /// Identifies a unique key within a key set when multiple keys exist with the same key set identifier.
    /// See ISO 13492 Key index for more information.
    /// </summary>
    [IsoId("_PGI2ID6VEeq_lLaSkIVjTQ")]
    [DisplayName("Key Index")]
    [IsoXmlTag("KeyIndx")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? KeyIndex { get; init; } 
    
    /// <summary>
    /// Identifies the padding method used prior to encipherment of the data.
    /// See ISO 13492 Padding method field for values.
    /// </summary>
    [IsoId("_XLGyID6VEeq_lLaSkIVjTQ")]
    [DisplayName("Padding Method")]
    [IsoXmlTag("PddgMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? PaddingMethod { get; init; } 
    
    /// <summary>
    /// Identifies the format of the structured data when the encrypted data block contains more than one data element.
    /// See ISO 13492 Encrypted data format field for values.
    /// </summary>
    [IsoId("_gh_pAD6VEeq_lLaSkIVjTQ")]
    [DisplayName("Encrypted Data Format")]
    [IsoXmlTag("NcrptdDataFrmt")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? EncryptedDataFormat { get; init; } 
    
    /// <summary>
    /// Encrypted data element information.
    /// </summary>
    [IsoId("_r673MD6VEeq_lLaSkIVjTQ")]
    [DisplayName("Encrypted Data Element")]
    [IsoXmlTag("NcrptdDataElmt")]
    public ValueList<EncryptedDataElement1> EncryptedDataElement { get; init; } = [];
    // ID for the above is _r673MD6VEeq_lLaSkIVjTQ
    
    
    #nullable disable
    
}
