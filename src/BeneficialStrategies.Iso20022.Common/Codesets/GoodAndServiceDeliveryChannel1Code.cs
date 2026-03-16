// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies the good or service delivery channel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rfj7kD5KEeyHI64WSlzTlg")]
[Description(@"Code that specifies the good or service delivery channel.")]
[DerivedFrom(typeof(GoodAndServiceDeliveryChannelCode))]
public enum GoodAndServiceDeliveryChannel1Code
{
    /// <summary>
    /// Electronic delivery.
    /// Encoded/decoded by serializers as &quot;EDEL&quot;.
    /// </summary>
    [EnumMember(Value = "EDEL")]
    [IsoId("_UWH5AT5KEeyHI64WSlzTlg")]
    [Description(@"Electronic delivery.")]
    ElectronicDelivery = GoodAndServiceDeliveryChannelCode.ElectronicDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pick up locally
    /// Encoded/decoded by serializers as &quot;PULC&quot;.
    /// </summary>
    [EnumMember(Value = "PULC")]
    [IsoId("_UbhWYT5KEeyHI64WSlzTlg")]
    [Description(@"Pick up locally")]
    LocalPickUp = GoodAndServiceDeliveryChannelCode.LocalPickUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No delivery.
    /// Encoded/decoded by serializers as &quot;NDEL&quot;.
    /// </summary>
    [EnumMember(Value = "NDEL")]
    [IsoId("_Uf_msT5KEeyHI64WSlzTlg")]
    [Description(@"No delivery.|")]
    NoDelivery = GoodAndServiceDeliveryChannelCode.NoDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other delivery channel defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_UlHXQT5KEeyHI64WSlzTlg")]
    [Description(@"Other delivery channel defined at national level.|")]
    OtherNational = GoodAndServiceDeliveryChannelCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other delivery channel defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_UqV1gT5KEeyHI64WSlzTlg")]
    [Description(@"Other delivery channel defined at private level.")]
    OtherPrivate = GoodAndServiceDeliveryChannelCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shipping to cardholder billing address
    /// Encoded/decoded by serializers as &quot;SCBA&quot;.
    /// </summary>
    [EnumMember(Value = "SCBA")]
    [IsoId("_UvaiwT5KEeyHI64WSlzTlg")]
    [Description(@"Shipping to cardholder billing address")]
    ShippingToCardholderBillingAddress =
        GoodAndServiceDeliveryChannelCode.ShippingToCardholderBillingAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shipping to consumer specified shipping address
    /// Encoded/decoded by serializers as &quot;SCSA&quot;.
    /// </summary>
    [EnumMember(Value = "SCSA")]
    [IsoId("_Uz-5sT5KEeyHI64WSlzTlg")]
    [Description(@"Shipping to consumer specified shipping address")]
    ShippingToConsumerSpecifiedShippingAddress =
        GoodAndServiceDeliveryChannelCode.ShippingToConsumerSpecifiedShippingAddress, // same ordinal as derivation source for type conversions
}
