// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Additional attribute of the service type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__bL2gNueEeiB5uLfkg9ZJA")]
[Description(@"Additional attribute of the service type.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType13Code
{
    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as &quot;CRDP&quot;.
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_CzZIcdufEeiB5uLfkg9ZJA")]
    [Description(@"Card payment.")]
    CardPayment = CardPaymentServiceTypeCode.CardPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_Dda84dufEeiB5uLfkg9ZJA")]
    [Description(@"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.")]
    CashAdvance = CardPaymentServiceTypeCode.CashAdvance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_ELN3AdufEeiB5uLfkg9ZJA")]
    [Description(@"Cash deposit.")]
    CashDeposit = CardPaymentServiceTypeCode.CashDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initial reservation.
    /// Encoded/decoded by serializers as &quot;IRES&quot;.
    /// </summary>
    [EnumMember(Value = "IRES")]
    [IsoId("_FayBcdufEeiB5uLfkg9ZJA")]
    [Description(@"Initial reservation.")]
    InitialReservation = CardPaymentServiceTypeCode.InitialReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_GD6eAdufEeiB5uLfkg9ZJA")]
    [Description(@"Deferred payment.")]
    DeferredPayment = CardPaymentServiceTypeCode.DeferredPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update reservation.
    /// Encoded/decoded by serializers as &quot;URES&quot;.
    /// </summary>
    [EnumMember(Value = "URES")]
    [IsoId("_HMJ4cdufEeiB5uLfkg9ZJA")]
    [Description(@"Update reservation.")]
    UpdateReservation = CardPaymentServiceTypeCode.UpdateReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment after reservation.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_J2hM8dufEeiB5uLfkg9ZJA")]
    [Description(@"Payment after reservation.")]
    PaymentReservation = CardPaymentServiceTypeCode.PaymentReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_Khy-kdufEeiB5uLfkg9ZJA")]
    [Description(@"Recurring payment.")]
    RecurringPayment = CardPaymentServiceTypeCode.RecurringPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instalment payment.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_MAr-cdufEeiB5uLfkg9ZJA")]
    [Description(@"Instalment payment.")]
    Instalment = CardPaymentServiceTypeCode.Instalment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instalment payment transaction performed by the card issuer.
    /// Encoded/decoded by serializers as &quot;INSI&quot;.
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_MZUg4dufEeiB5uLfkg9ZJA")]
    [Description(@"Instalment payment transaction performed by the card issuer.")]
    IssuerInstalment = CardPaymentServiceTypeCode.IssuerInstalment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as &quot;RFND&quot;.
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_NeARAdufEeiB5uLfkg9ZJA")]
    [Description(@"Refund transaction.")]
    Refund = CardPaymentServiceTypeCode.Refund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Voice authorisation.
    /// Encoded/decoded by serializers as &quot;VCAU&quot;.
    /// </summary>
    [EnumMember(Value = "VCAU")]
    [IsoId("_OpXQ4dufEeiB5uLfkg9ZJA")]
    [Description(@"Voice authorisation.")]
    VoiceAuthorisation = CardPaymentServiceTypeCode.VoiceAuthorisation, // same ordinal as derivation source for type conversions
    
}
