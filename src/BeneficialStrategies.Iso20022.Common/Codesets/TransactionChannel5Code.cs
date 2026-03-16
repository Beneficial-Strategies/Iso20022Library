// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of the communication channels used by the cardholder to the acceptor system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IYpIsbDHEeaW-9Sj0pzN5A")]
[Description(
    @"Identifies the type of the communication channels used by the cardholder to the acceptor system."
)]
[DerivedFrom(typeof(TransactionChannelCode))]
public enum TransactionChannel5Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_ImxrUbDHEeaW-9Sj0pzN5A")]
    [Description(@"Mail order.")]
    MailOrder = TransactionChannelCode.MailOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone order.
    /// Encoded/decoded by serializers as &quot;TLPH&quot;.
    /// </summary>
    [EnumMember(Value = "TLPH")]
    [IsoId("_ImxrU7DHEeaW-9Sj0pzN5A")]
    [Description(@"Telephone order.")]
    TelephoneOrder = TransactionChannelCode.TelephoneOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce.
    /// Encoded/decoded by serializers as &quot;ECOM&quot;.
    /// </summary>
    [EnumMember(Value = "ECOM")]
    [IsoId("_ImxrVbDHEeaW-9Sj0pzN5A")]
    [Description(@"Electronic commerce.")]
    ElectronicCommerce = TransactionChannelCode.ElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment on television.
    /// Encoded/decoded by serializers as &quot;TVPY&quot;.
    /// </summary>
    [EnumMember(Value = "TVPY")]
    [IsoId("_ImxrV7DHEeaW-9Sj0pzN5A")]
    [Description(@"Payment on television.")]
    TelevisionPayment = TransactionChannelCode.TelevisionPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce with cardholder authentication.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_ImxrWbDHEeaW-9Sj0pzN5A")]
    [Description(@"Electronic commerce with cardholder authentication.")]
    SecuredElectronicCommerce = TransactionChannelCode.SecuredElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment performed through a cardholder mobile device.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_ImxrW7DHEeaW-9Sj0pzN5A")]
    [Description(@"Payment performed through a cardholder mobile device.")]
    MobilePayment = TransactionChannelCode.MobilePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment performed through a merchant mobile device.
    /// Encoded/decoded by serializers as &quot;MPOS&quot;.
    /// </summary>
    [EnumMember(Value = "MPOS")]
    [IsoId("_KbWnUbDHEeaW-9Sj0pzN5A")]
    [Description(@"Payment performed through a merchant mobile device.")]
    MobilePOS = TransactionChannelCode.MobilePOS, // same ordinal as derivation source for type conversions
}
