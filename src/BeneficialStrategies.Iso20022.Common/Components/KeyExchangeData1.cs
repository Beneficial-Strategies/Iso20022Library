// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains data related to key exchange activity.
/// </summary>
[IsoId("_ciSS0f5tEeiLerArw36g0w")]
[DisplayName("Key Exchange Data")]
public partial record KeyExchangeData1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated structure of the remainder of the data element
    /// ISO 13492
    /// Binary, length of 1
    /// </summary>
    [IsoId("_cshM4f5tEeiLerArw36g0w")]
    [DisplayName("Control")]
    [IsoXmlTag("Ctrl")]
    [IsoSimpleType(IsoSimpleType.Exact1HexBinaryText)]
    public IsoExact1HexBinaryText? Control { get; init; } 
    
    /// <summary>
    /// key-set identifier is a number that uniquely identifies a group of related keys that are all different but have certain characteristics in common.
    /// ISO 13492
    /// lengths of 6 or 8
    /// </summary>
    [IsoId("_cshM4_5tEeiLerArw36g0w")]
    [DisplayName("Key Set Identifier")]
    [IsoXmlTag("KeySetIdr")]
    [IsoSimpleType(IsoSimpleType.Max8NumericText)]
    public IsoMax8NumericText? KeySetIdentifier { get; init; } 
    
    /// <summary>
    /// Random number or counter in order to have a unique key per transaction. for example, UKPT PIN encryption or contains the transaction counter.
    /// ISO 13492
    /// Binary, lengths of 5, 8, 16 or 32 
    /// </summary>
    [IsoId("_cshM7f5tEeiLerArw36g0w")]
    [DisplayName("Derived Information")]
    [IsoXmlTag("DrvdInf")]
    [IsoSimpleType(IsoSimpleType.Max32HexBinaryText)]
    public IsoMax32HexBinaryText? DerivedInformation { get; init; } 
    
    /// <summary>
    /// Selects the encryption algorithm used to encipher the keys contained in the associated key management data element.
    /// ISO 13492
    /// </summary>
    [IsoId("_cshM6_5tEeiLerArw36g0w")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Algorithm { get; init; } 
    
    /// <summary>
    /// Specifies the length of the keys being transported, not the encrypting key.
    /// ISO 13492
    /// </summary>
    [IsoId("_cshM5_5tEeiLerArw36g0w")]
    [DisplayName("Key Length")]
    [IsoXmlTag("KeyLngth")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? KeyLength { get; init; } 
    
    /// <summary>
    /// Mechanism used to provide key confidentiality and integrity. 
    /// ISO 13492
    /// </summary>
    [IsoId("_cshM6f5tEeiLerArw36g0w")]
    [DisplayName("Key Protection")]
    [IsoXmlTag("KeyPrtcn")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? KeyProtection { get; init; } 
    
    /// <summary>
    /// Identifies a unique key set when multiple keys with the same key set identifier are used. for example, key rotation.
    /// ISO 13492
    /// Length of 2 or 5
    /// </summary>
    [IsoId("_cshM5f5tEeiLerArw36g0w")]
    [DisplayName("Key Index")]
    [IsoXmlTag("KeyIndx")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? KeyIndex { get; init; } 
    
    /// <summary>
    /// Uses a structure within it prior to encryption to identify the data.
    /// Binary, length of 8 up to 9999 
    /// </summary>
    [IsoId("_fPXHoP5uEeiLerArw36g0w")]
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max9999HexBinaryText)]
    public IsoMax9999HexBinaryText? EncryptedData { get; init; } 
    
    /// <summary>
    /// Contains a value used to verify a conveyed key. Length depends on the algorithm used. 
    /// Binary, length of 8 up to 9999 
    /// </summary>
    [IsoId("_jF57YP5uEeiLerArw36g0w")]
    [DisplayName("Key Checksum Value")]
    [IsoXmlTag("KeyChcksmVal")]
    [IsoSimpleType(IsoSimpleType.Max9999HexBinaryText)]
    public IsoMax9999HexBinaryText? KeyChecksumValue { get; init; } 
    
    
    #nullable disable
    
}
