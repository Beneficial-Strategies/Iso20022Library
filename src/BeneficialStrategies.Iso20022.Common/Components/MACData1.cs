// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a cardholder PIN.
/// ISO 8583:87 bit 53 or 110
/// ISO 8583:93 bit 53 or 111
/// ISO 8583:2003 bit 53 or 50
/// </summary>
[IsoId("_pFv0qvGOEeiGNursv3uE_g")]
[DisplayName("MAC Data")]
public partial record MACData1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the key management scheme and associated structure of the remainder of the data element.
    /// ISO 13492
    /// Binary, length of 1
    /// </summary>
    [IsoId("_pFv0q_GOEeiGNursv3uE_g")]
    [DisplayName("Control")]
    [IsoXmlTag("Ctrl")]
    [IsoSimpleType(IsoSimpleType.Exact1HexBinaryText)]
    public required IsoExact1HexBinaryText Control { get; init; } 
    
    /// <summary>
    /// key-set identifier is a number that uniquely identifies a group of related keys that are all different but have certain characteristics in common.
    /// ISO 13492
    /// lengths of 6 or 8
    /// </summary>
    [IsoId("_pFv0r_GOEeiGNursv3uE_g")]
    [DisplayName("Key Set Identifier")]
    [IsoXmlTag("KeySetIdr")]
    [IsoSimpleType(IsoSimpleType.Max8NumericText)]
    public required IsoMax8NumericText KeySetIdentifier { get; init; } 
    
    /// <summary>
    /// Random number or counter in order to have a unique key per transaction. for example, UKPT PIN encryption or the transaction counter.
    /// ISO 13492
    /// Binary, lengths of 5, 8, 16 or 32 
    /// </summary>
    [IsoId("_pFv0sPGOEeiGNursv3uE_g")]
    [DisplayName("Derived Information")]
    [IsoXmlTag("DrvdInf")]
    [IsoSimpleType(IsoSimpleType.Max32HexBinaryText)]
    public IsoMax32HexBinaryText? DerivedInformation { get; init; } 
    
    /// <summary>
    /// Selects the encryption algorithm used to encipher the keys contained in the associated key management data element.
    /// ISO 13492
    /// </summary>
    [IsoId("_pFv0rfGOEeiGNursv3uE_g")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public required IsoMax2NumericText Algorithm { get; init; } 
    
    /// <summary>
    /// Specifies the length of the keys being transported, not the encrypting key.
    /// ISO 13492
    /// </summary>
    [IsoId("_pFv0rvGOEeiGNursv3uE_g")]
    [DisplayName("Key Length")]
    [IsoXmlTag("KeyLngth")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? KeyLength { get; init; } 
    
    /// <summary>
    /// Mechanism used to provide key confidentiality and integrity. 
    /// ISO 13492
    /// </summary>
    [IsoId("_pFv0rPGOEeiGNursv3uE_g")]
    [DisplayName("Key Protection")]
    [IsoXmlTag("KeyPrtcn")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? KeyProtection { get; init; } 
    
    /// <summary>
    /// Identifies a unique key set when multiple keys with the same key set identifier are used. for example, key rotation.
    /// ISO 13492
    /// Length of 2 or 5
    /// </summary>
    [IsoId("_pFv0s_GOEeiGNursv3uE_g")]
    [DisplayName("Key Index")]
    [IsoXmlTag("KeyIndx")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? KeyIndex { get; init; } 
    
    /// <summary>
    /// Identifies the padding method used for MAC.
    /// ISO 13492
    /// </summary>
    [IsoId("_pFv0svGOEeiGNursv3uE_g")]
    [DisplayName("Padding Method")]
    [IsoXmlTag("PddgMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? PaddingMethod { get; init; } 
    
    /// <summary>
    /// Initialisation vector for CBC.
    /// ISO 13492
    /// Binary, lengths of  8, 16 or 32 
    /// </summary>
    [IsoId("_pFv0sfGOEeiGNursv3uE_g")]
    [DisplayName("Initialisation Vector")]
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max32HexBinaryText)]
    public IsoMax32HexBinaryText? InitialisationVector { get; init; } 
    
    
    #nullable disable
    
}
