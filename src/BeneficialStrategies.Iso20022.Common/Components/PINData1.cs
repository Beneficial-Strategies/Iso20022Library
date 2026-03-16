// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a cardholder PIN.
/// </summary>
[IsoId("_oIKMwEbYEeeIjf8aP9KbJA")]
[DisplayName("PIN Data")]
public record PINData1
{
    /// <summary>
    /// Identifies the key management scheme and associated control field format.
    /// ISO 13492
    /// Binary, length of 1
    /// </summary>
    [IsoId("_1o494InMEeiHerJAHfwamw")]
    [DisplayName("Control")]
    [IsoXmlTag("Ctrl")]
    [IsoSimpleType(IsoSimpleType.Exact1HexBinaryText)]
    public IsoExact1HexBinaryText? Control { get; init; }

    /// <summary>
    /// key-set identifier is a number that uniquely identifies a group of related keys that are all different but have certain characteristics in common.
    /// ISO 13492
    /// lengths of 6 or 8
    /// </summary>
    [IsoId("_d0W1wotNEei2ytxdCDTOFQ")]
    [DisplayName("Key Set Identifier")]
    [IsoXmlTag("KeySetIdr")]
    [IsoSimpleType(IsoSimpleType.Max8NumericText)]
    public IsoMax8NumericText? KeySetIdentifier { get; init; }

    /// <summary>
    /// Contains Derived Info or Device ID and Transaction Counter.
    /// ISO 13492
    /// Binary, lengths of 5, 8, 16 or 32
    /// </summary>
    [IsoId("_03k44InQEeiHerJAHfwamw")]
    [DisplayName("Derived Information")]
    [IsoXmlTag("DrvdInf")]
    [IsoSimpleType(IsoSimpleType.Max32HexBinaryText)]
    public IsoMax32HexBinaryText? DerivedInformation { get; init; }

    /// <summary>
    /// Used to select the encryption algorithm to encipher the keys contained in the associated key management data element.
    /// ISO 13492
    /// </summary>
    [IsoId("_XqXiYInREeiHerJAHfwamw")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Algorithm { get; init; }

    /// <summary>
    /// Specifies the length of the keys being transported, not the encrypting key.
    /// ISO 13492
    /// </summary>
    [IsoId("_u95wootNEei2ytxdCDTOFQ")]
    [DisplayName("Key Length")]
    [IsoXmlTag("KeyLngth")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? KeyLength { get; init; }

    /// <summary>
    /// Mechanism used to provide key confidentiality and integrity.
    /// ISO 13492
    /// </summary>
    [IsoId("_W9lC8YnTEeiHerJAHfwamw")]
    [DisplayName("Key Protection")]
    [IsoXmlTag("KeyPrtcn")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? KeyProtection { get; init; }

    /// <summary>
    /// Identifies a unique key set when multiple keys with the same key set identifier are used (for example, key rotation).
    /// ISO 13492
    /// Length of 2 or 5
    /// </summary>
    [IsoId("_85vZYotNEei2ytxdCDTOFQ")]
    [DisplayName("Key Index")]
    [IsoXmlTag("KeyIndx")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? KeyIndex { get; init; }

    /// <summary>
    /// As defined in ISO 9564-1.
    /// </summary>
    [IsoId("_DiyMQYnVEeiHerJAHfwamw")]
    [DisplayName("PIN Block Format")]
    [IsoXmlTag("PINBlckFrmt")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public required IsoMax2NumericText PINBlockFormat { get; init; }

    /// <summary>
    /// As defined in ISO 9564-1.
    /// Binary, length of 8 or 16
    /// </summary>
    [IsoId("_BbKmMInaEei2ytxdCDTOFQ")]
    [DisplayName("Encrypted PIN Block")]
    [IsoXmlTag("NcrptdPINBlck")]
    [IsoSimpleType(IsoSimpleType.Max16HexBinaryText)]
    public required IsoMax16HexBinaryText EncryptedPINBlock { get; init; }
}
