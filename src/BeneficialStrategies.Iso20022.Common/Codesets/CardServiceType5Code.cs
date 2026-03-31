// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of key exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5BKA0VWXEeeiG_nL4vgKnQ")]
[Description(@"Type of key exchange.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardServiceType5Code>))]
#endif
public enum CardServiceType5Code
{
    /// <summary>
    /// Convey the key to the receiver.
    /// Encoded/decoded by serializers as &quot;KYDL&quot;.
    /// </summary>
    [EnumMember(Value = "KYDL")]
    [IsoId("_8u0YcX0kEemfrNOe0zHQyg")]
    [Description(@"Convey the key to the receiver.")]
    DeliverKey = CardServiceTypeCode.DeliverKey, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National defined code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_8u0Yd30kEemfrNOe0zHQyg")]
    [Description(@"National defined code.")]
    OtherNational = CardServiceTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Private defined code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_8u0YeX0kEemfrNOe0zHQyg")]
    [Description(@"Private defined code.")]
    OtherPrivate = CardServiceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deactivate the specified key.
    /// Encoded/decoded by serializers as &quot;DEKY&quot;.
    /// </summary>
    [EnumMember(Value = "DEKY")]
    [IsoId("_XFuv8ZJcEemtzI0l4QED6w")]
    [Description(@"Deactivate the specified key.")]
    DeactivateKey = CardServiceTypeCode.DeactivateKey, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request new key to be generated and conveyed.
    /// Encoded/decoded by serializers as &quot;RQKY&quot;.
    /// </summary>
    [EnumMember(Value = "RQKY")]
    [IsoId("_FFXUMa4bEemYtqDpusmLsQ")]
    [Description(@"Request new key to be generated and conveyed.")]
    RequestKey = CardServiceTypeCode.RequestKey, // same ordinal as derivation source for type conversions
}
