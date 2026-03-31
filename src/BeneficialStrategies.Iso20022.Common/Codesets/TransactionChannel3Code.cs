// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of the communication channels used by the cardholder to the acceptor system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sSD7UWkBEeS7zPBpvm732w")]
[Description(
    @"Identifies the type of the communication channels used by the cardholder to the acceptor system."
)]
[DerivedFrom(typeof(TransactionChannelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionChannel3Code>))]
#endif
public enum TransactionChannel3Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_sfvK8WkBEeS7zPBpvm732w")]
    [Description(@"Mail order.")]
    MailOrder = TransactionChannelCode.MailOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone order.
    /// Encoded/decoded by serializers as &quot;TLPH&quot;.
    /// </summary>
    [EnumMember(Value = "TLPH")]
    [IsoId("_sfvK82kBEeS7zPBpvm732w")]
    [Description(@"Telephone order.")]
    TelephoneOrder = TransactionChannelCode.TelephoneOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce.
    /// Encoded/decoded by serializers as &quot;ECOM&quot;.
    /// </summary>
    [EnumMember(Value = "ECOM")]
    [IsoId("_sfvK9WkBEeS7zPBpvm732w")]
    [Description(@"Electronic commerce.")]
    ElectronicCommerce = TransactionChannelCode.ElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment on television.
    /// Encoded/decoded by serializers as &quot;TVPY&quot;.
    /// </summary>
    [EnumMember(Value = "TVPY")]
    [IsoId("_sfvK92kBEeS7zPBpvm732w")]
    [Description(@"Payment on television.")]
    TelevisionPayment = TransactionChannelCode.TelevisionPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce with cardholder authentication.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_9IwLoWkBEeS7zPBpvm732w")]
    [Description(@"Electronic commerce with cardholder authentication.")]
    SecuredElectronicCommerce = TransactionChannelCode.SecuredElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment performed through a cardholder mobile device.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_9T2oYWkBEeS7zPBpvm732w")]
    [Description(@"Payment performed through a cardholder mobile device.")]
    MobilePayment = TransactionChannelCode.MobilePayment, // same ordinal as derivation source for type conversions
}
