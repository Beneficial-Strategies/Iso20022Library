// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Destination of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ei0dMZ_7EfC4Q_xhaK1hdQ")]
[Description(@"Destination of the message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<UserInterface9Code>))]
public enum UserInterface9Code
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as &quot;CDSP&quot;.
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_ekIEwZ_7EfC4Q_xhaK1hdQ")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay = UserInterfaceCode.CardholderDisplay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as &quot;CRCP&quot;.
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_ekIEw5_7EfC4Q_xhaK1hdQ")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt = UserInterfaceCode.CardholderReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other interface of the cardholder, for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as &quot;CRDO&quot;.
    /// </summary>
    [EnumMember(Value = "CRDO")]
    [IsoId("_ekIEyZ_7EfC4Q_xhaK1hdQ")]
    [Description(@"Other interface of the cardholder, for instance e-mail or smartphone message.")]
    OtherCardholderInterface = UserInterfaceCode.OtherCardholderInterface, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder bank statement.
    /// Encoded/decoded by serializers as &quot;CSTM&quot;.
    /// </summary>
    [EnumMember(Value = "CSTM")]
    [IsoId("_PKRJYZ_8EfC4Q_xhaK1hdQ")]
    [Description(@"Cardholder bank statement.")]
    CustomerStatement = UserInterfaceCode.CustomerStatement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant display or interface.
    /// Encoded/decoded by serializers as &quot;MDSP&quot;.
    /// </summary>
    [EnumMember(Value = "MDSP")]
    [IsoId("_ekIExZ_7EfC4Q_xhaK1hdQ")]
    [Description(@"Merchant display or interface.")]
    MerchantDisplay = UserInterfaceCode.MerchantDisplay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant receipt.
    /// Encoded/decoded by serializers as &quot;MRCP&quot;.
    /// </summary>
    [EnumMember(Value = "MRCP")]
    [IsoId("_ekIEx5_7EfC4Q_xhaK1hdQ")]
    [Description(@"Merchant receipt.")]
    MerchantReceipt = UserInterfaceCode.MerchantReceipt, // same ordinal as derivation source for type conversions
}
