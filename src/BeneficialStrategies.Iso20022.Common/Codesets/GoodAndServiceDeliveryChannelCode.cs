// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the good or service delivery channel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A9WDQD5GEeyHI64WSlzTlg")]
[Description(@"Code that specifies the good or service delivery channel.")]
[Derivations(typeof(GoodAndServiceDeliveryChannel1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GoodAndServiceDeliveryChannelCode>))]
#endif
public enum GoodAndServiceDeliveryChannelCode
{
    /// <summary>
    /// Pick up locally
    /// Encoded/decoded by serializers as &quot;PULC&quot;.
    /// </summary>
    [EnumMember(Value = "PULC")]
    [IsoId("_Kg6EMD5GEeyHI64WSlzTlg")]
    [Description(@"Pick up locally")]
    LocalPickUp,

    /// <summary>
    /// Shipping to cardholder billing address
    /// Encoded/decoded by serializers as &quot;SCBA&quot;.
    /// </summary>
    [EnumMember(Value = "SCBA")]
    [IsoId("_C-OgcD5HEeyHI64WSlzTlg")]
    [Description(@"Shipping to cardholder billing address")]
    ShippingToCardholderBillingAddress,

    /// <summary>
    /// Shipping to consumer specified shipping address
    /// Encoded/decoded by serializers as &quot;SCSA&quot;.
    /// </summary>
    [EnumMember(Value = "SCSA")]
    [IsoId("_vkZ6ID5IEeyHI64WSlzTlg")]
    [Description(@"Shipping to consumer specified shipping address")]
    ShippingToConsumerSpecifiedShippingAddress,

    /// <summary>
    /// Other delivery channel defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_AlgDoD5JEeyHI64WSlzTlg")]
    [Description(@"Other delivery channel defined at national level.|")]
    OtherNational,

    /// <summary>
    /// Other delivery channel defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_AtNOID5JEeyHI64WSlzTlg")]
    [Description(@"Other delivery channel defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// No delivery.
    /// Encoded/decoded by serializers as &quot;NDEL&quot;.
    /// </summary>
    [EnumMember(Value = "NDEL")]
    [IsoId("_A6LTID5JEeyHI64WSlzTlg")]
    [Description(@"No delivery.|")]
    NoDelivery,

    /// <summary>
    /// Electronic delivery.
    /// Encoded/decoded by serializers as &quot;EDEL&quot;.
    /// </summary>
    [EnumMember(Value = "EDEL")]
    [IsoId("_BnV7ID5JEeyHI64WSlzTlg")]
    [Description(@"Electronic delivery.")]
    ElectronicDelivery,
}
