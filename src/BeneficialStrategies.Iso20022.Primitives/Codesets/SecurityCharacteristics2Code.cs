// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Security characteristics of the communication link.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BEJFoSd-EfCJ9IDAfAjwLA")]
[Description(@"Security characteristics of the communication link.")]
[DerivedFrom(typeof(SecurityCharacteristicsCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SecurityCharacteristics2Code>))]
public enum SecurityCharacteristics2Code
{
    /// <summary>
    /// Encryption initiated by the acquirer to secure end-to-end communication channel.
    /// Encoded/decoded by serializers as &quot;AETE&quot;.
    /// </summary>
    [EnumMember(Value = "AETE")]
    [IsoId("_BGgdPyd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption initiated by the acquirer to secure end-to-end communication channel.")]
    AcquirerEndToEndEncryption = SecurityCharacteristicsCode.AcquirerEndToEndEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption initiated by the acquirer to secure point-to-point communication channel.
    /// Encoded/decoded by serializers as &quot;APTE&quot;.
    /// </summary>
    [EnumMember(Value = "APTE")]
    [IsoId("_BGgdPSd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption initiated by the acquirer to secure point-to-point communication channel.")]
    AcquirerPointToPointEncryption = SecurityCharacteristicsCode.AcquirerPointToPointEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption used to secure the communication channel.
    /// Encoded/decoded by serializers as &quot;CENC&quot;.
    /// </summary>
    [EnumMember(Value = "CENC")]
    [IsoId("_BGgdJSd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption used to secure the communication channel.")]
    ChannelEncryption = SecurityCharacteristicsCode.ChannelEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption initiated by the cardholder to secure end-to-end communication channel.
    /// Encoded/decoded by serializers as &quot;CETE&quot;.
    /// </summary>
    [EnumMember(Value = "CETE")]
    [IsoId("_BGgdISd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption initiated by the cardholder to secure end-to-end communication channel.")]
    CardholderEndToEndEncryption = SecurityCharacteristicsCode.CardholderEndToEndEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Usage of MAC to secure a communication channel
    /// Encoded/decoded by serializers as &quot;CMAC&quot;.
    /// </summary>
    [EnumMember(Value = "CMAC")]
    [IsoId("_BGgdJyd-EfCJ9IDAfAjwLA")]
    [Description(@"Usage of MAC to secure a communication channel")]
    ChannelMAC = SecurityCharacteristicsCode.ChannelMAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption initiated by the cardholder to secure point-to-point communication channel.
    /// Encoded/decoded by serializers as &quot;CPTE&quot;.
    /// </summary>
    [EnumMember(Value = "CPTE")]
    [IsoId("_BGgdIyd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption initiated by the cardholder to secure point-to-point communication channel.")]
    CardholderPointToPointEncryption = SecurityCharacteristicsCode.CardholderPointToPointEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption used from one end to the other end of the communication channel.
    /// Encoded/decoded by serializers as &quot;ETEE&quot;.
    /// </summary>
    [EnumMember(Value = "ETEE")]
    [IsoId("_BGgdKSd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption used from one end to the other end of the communication channel.")]
    EndToEndEncryption = SecurityCharacteristicsCode.EndToEndEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption initiated by the merchant to secure end-to-end communication channel.
    /// Encoded/decoded by serializers as &quot;METE&quot;.
    /// </summary>
    [EnumMember(Value = "METE")]
    [IsoId("_BGgdKyd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption initiated by the merchant to secure end-to-end communication channel.")]
    MerchantEndToEndEncryption = SecurityCharacteristicsCode.MerchantEndToEndEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption initiated by the merchant to secure point-to-point communication channel.
    /// Encoded/decoded by serializers as &quot;MPTE&quot;.
    /// </summary>
    [EnumMember(Value = "MPTE")]
    [IsoId("_BGgdLSd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption initiated by the merchant to secure point-to-point communication channel.")]
    MerchantPointToPointEncryption = SecurityCharacteristicsCode.MerchantPointToPointEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Open network
    /// Encoded/decoded by serializers as &quot;OPNN&quot;.
    /// </summary>
    [EnumMember(Value = "OPNN")]
    [IsoId("_BGgdLyd-EfCJ9IDAfAjwLA")]
    [Description(@"Open network")]
    OpenNetwork = SecurityCharacteristicsCode.OpenNetwork, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption using PKI to secure the communication channel.
    /// Encoded/decoded by serializers as &quot;PKIE&quot;.
    /// </summary>
    [EnumMember(Value = "PKIE")]
    [IsoId("_BGgdMyd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption using PKI to secure the communication channel.")]
    PKIEncryption = SecurityCharacteristicsCode.PKIEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MAC used in a pass-through communication mode
    /// Encoded/decoded by serializers as &quot;PMAC&quot;.
    /// </summary>
    [EnumMember(Value = "PMAC")]
    [IsoId("_BGgdMSd-EfCJ9IDAfAjwLA")]
    [Description(@"MAC used in a pass-through communication mode")]
    PassthroughMAC = SecurityCharacteristicsCode.PassthroughMAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encryption using a private algorithm to secure a communication channel.
    /// Encoded/decoded by serializers as &quot;PRAE&quot;.
    /// </summary>
    [EnumMember(Value = "PRAE")]
    [IsoId("_BGgdNSd-EfCJ9IDAfAjwLA")]
    [Description(@"Encryption using a private algorithm to secure a communication channel.")]
    PrivateAlgorithmEncryption = SecurityCharacteristicsCode.PrivateAlgorithmEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Private algorithm used for MAC.
    /// Encoded/decoded by serializers as &quot;PRAM&quot;.
    /// </summary>
    [EnumMember(Value = "PRAM")]
    [IsoId("_BGgdNyd-EfCJ9IDAfAjwLA")]
    [Description(@"Private algorithm used for MAC.")]
    PrivateAlgorithmMAC = SecurityCharacteristicsCode.PrivateAlgorithmMAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Private network.
    /// Encoded/decoded by serializers as &quot;PRVN&quot;.
    /// </summary>
    [EnumMember(Value = "PRVN")]
    [IsoId("_BGgdOSd-EfCJ9IDAfAjwLA")]
    [Description(@"Private network.")]
    PrivateNetwork = SecurityCharacteristicsCode.PrivateNetwork, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard algorithm used for MAC
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_BGgdOyd-EfCJ9IDAfAjwLA")]
    [Description(@"Standard algorithm used for MAC")]
    StandardAlgorithmMAC = SecurityCharacteristicsCode.StandardAlgorithmMAC, // same ordinal as derivation source for type conversions
}
