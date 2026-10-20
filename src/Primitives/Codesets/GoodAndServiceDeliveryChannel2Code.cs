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
[IsoId("_8iHPcSd-EfCJ9IDAfAjwLA")]
[Description(@"Code that specifies the good or service delivery channel.")]
[DerivedFrom(typeof(GoodAndServiceDeliveryChannelCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<GoodAndServiceDeliveryChannel2Code>))]
public enum GoodAndServiceDeliveryChannel2Code
{
    /// <summary>
    /// Electronic delivery.
    /// Encoded/decoded by serializers as &quot;EDEL&quot;.
    /// </summary>
    [EnumMember(Value = "EDEL")]
    [IsoId("_8kWEESd-EfCJ9IDAfAjwLA")]
    [Description(@"Electronic delivery.")]
    ElectronicDelivery = GoodAndServiceDeliveryChannelCode.ElectronicDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No delivery.
    /// Encoded/decoded by serializers as &quot;NDEL&quot;.
    /// </summary>
    [EnumMember(Value = "NDEL")]
    [IsoId("_8kWEFSd-EfCJ9IDAfAjwLA")]
    [Description(@"No delivery.")]
    NoDelivery = GoodAndServiceDeliveryChannelCode.NoDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pick up locally.
    /// Encoded/decoded by serializers as &quot;PULC&quot;.
    /// </summary>
    [EnumMember(Value = "PULC")]
    [IsoId("_8kWEEyd-EfCJ9IDAfAjwLA")]
    [Description(@"Pick up locally.")]
    LocalPickUp = GoodAndServiceDeliveryChannelCode.LocalPickUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shipping to cardholder billing address.
    /// Encoded/decoded by serializers as &quot;SCBA&quot;.
    /// </summary>
    [EnumMember(Value = "SCBA")]
    [IsoId("_8kWEGyd-EfCJ9IDAfAjwLA")]
    [Description(@"Shipping to cardholder billing address.")]
    ShippingToCardholderBillingAddress = GoodAndServiceDeliveryChannelCode.ShippingToCardholderBillingAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shipping to consumer specified shipping address.
    /// Encoded/decoded by serializers as &quot;SCSA&quot;.
    /// </summary>
    [EnumMember(Value = "SCSA")]
    [IsoId("_8kWEHSd-EfCJ9IDAfAjwLA")]
    [Description(@"Shipping to consumer specified shipping address.")]
    ShippingToConsumerSpecifiedShippingAddress = GoodAndServiceDeliveryChannelCode.ShippingToConsumerSpecifiedShippingAddress, // same ordinal as derivation source for type conversions
}
