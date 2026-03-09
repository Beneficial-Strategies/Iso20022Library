// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Additional attributes of the service provided by the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dMN6wU7DEeyGi9JAv6wq7Q")]
[Description(@"Additional attributes of the service provided by the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType14Code
{
    /// <summary>
    /// Initial reservation.
    /// Encoded/decoded by serializers as &quot;IRES&quot;.
    /// </summary>
    [EnumMember(Value = "IRES")]
    [IsoId("_dSuycU7DEeyGi9JAv6wq7Q")]
    [Description(@"Initial reservation.")]
    InitialReservation = CardPaymentServiceTypeCode.InitialReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update reservation.
    /// Encoded/decoded by serializers as &quot;URES&quot;.
    /// </summary>
    [EnumMember(Value = "URES")]
    [IsoId("_dSuyc07DEeyGi9JAv6wq7Q")]
    [Description(@"Update reservation.")]
    UpdateReservation = CardPaymentServiceTypeCode.UpdateReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment after reservation.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_dSuydU7DEeyGi9JAv6wq7Q")]
    [Description(@"Payment after reservation.")]
    PaymentReservation = CardPaymentServiceTypeCode.PaymentReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional payment after reservation.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_dSuyd07DEeyGi9JAv6wq7Q")]
    [Description(@"Additional payment after reservation.")]
    AdditionalPayment = CardPaymentServiceTypeCode.AdditionalPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initial recurring payment.
    /// Encoded/decoded by serializers as &quot;FREC&quot;.
    /// </summary>
    [EnumMember(Value = "FREC")]
    [IsoId("_dSuyeU7DEeyGi9JAv6wq7Q")]
    [Description(@"Initial recurring payment.")]
    FirstRecurring = CardPaymentServiceTypeCode.FirstRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repeat recurring payment.
    /// Encoded/decoded by serializers as &quot;RREC&quot;.
    /// </summary>
    [EnumMember(Value = "RREC")]
    [IsoId("_dSuye07DEeyGi9JAv6wq7Q")]
    [Description(@"Repeat recurring payment.")]
    FollowingRecurring = CardPaymentServiceTypeCode.FollowingRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acceptor claims for guarantee of payment.
    /// Encoded/decoded by serializers as &quot;GOPT&quot;.
    /// </summary>
    [EnumMember(Value = "GOPT")]
    [IsoId("_r4DdEU7DEeyGi9JAv6wq7Q")]
    [Description(@"Acceptor claims for guarantee of payment.")]
    GuaranteeOfPayment = CardPaymentServiceTypeCode.GuaranteeOfPayment, // same ordinal as derivation source for type conversions
    
}
