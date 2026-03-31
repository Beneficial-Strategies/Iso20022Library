// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Additional attributes of the service provided by the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSz5ZgEcEeCQm6a_G2yO_w_-878282467")]
[Description(@"Additional attributes of the service provided by the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardPaymentServiceType3Code>))]
#endif
public enum CardPaymentServiceType3Code
{
    /// <summary>
    /// Initial reservation.
    /// Encoded/decoded by serializers as &quot;IRES&quot;.
    /// </summary>
    [EnumMember(Value = "IRES")]
    [IsoId("_TSz5ZwEcEeCQm6a_G2yO_w_766984968")]
    [Description(@"Initial reservation.")]
    InitialReservation = CardPaymentServiceTypeCode.InitialReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update reservation.
    /// Encoded/decoded by serializers as &quot;URES&quot;.
    /// </summary>
    [EnumMember(Value = "URES")]
    [IsoId("_TSz5aAEcEeCQm6a_G2yO_w_-1875354820")]
    [Description(@"Update reservation.")]
    UpdateReservation = CardPaymentServiceTypeCode.UpdateReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment after reservation.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_TSz5aQEcEeCQm6a_G2yO_w_-1697236148")]
    [Description(@"Payment after reservation.")]
    PaymentReservation = CardPaymentServiceTypeCode.PaymentReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional payment after reservation.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_TSz5agEcEeCQm6a_G2yO_w_-1989193886")]
    [Description(@"Additional payment after reservation.")]
    AdditionalPayment = CardPaymentServiceTypeCode.AdditionalPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initial recurring payment.
    /// Encoded/decoded by serializers as &quot;FREC&quot;.
    /// </summary>
    [EnumMember(Value = "FREC")]
    [IsoId("_TSz5awEcEeCQm6a_G2yO_w_-230087385")]
    [Description(@"Initial recurring payment.")]
    FirstRecurring = CardPaymentServiceTypeCode.FirstRecurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repeat recurring payment.
    /// Encoded/decoded by serializers as &quot;RREC&quot;.
    /// </summary>
    [EnumMember(Value = "RREC")]
    [IsoId("_TSz5bAEcEeCQm6a_G2yO_w_1422540123")]
    [Description(@"Repeat recurring payment.")]
    FollowingRecurring = CardPaymentServiceTypeCode.FollowingRecurring, // same ordinal as derivation source for type conversions
}
