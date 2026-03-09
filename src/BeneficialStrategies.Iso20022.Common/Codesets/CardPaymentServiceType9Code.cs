// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Service provided by the card payment transaction, in addition to the main service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5P18EY0XEeWRYffwL7E13A")]
[Description(@"Service provided by the card payment transaction, in addition to the main service.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType9Code
{
    /// <summary>
    /// Aggregation of low payments.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_5aRDYY0XEeWRYffwL7E13A")]
    [Description(@"Aggregation of low payments.")]
    Aggregation = CardPaymentServiceTypeCode.Aggregation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dynamic currency conversion (DCC).
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_5aRDY40XEeWRYffwL7E13A")]
    [Description(@"Dynamic currency conversion (DCC).")]
    DCC = CardPaymentServiceTypeCode.DCC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment with gratuity.
    /// Encoded/decoded by serializers as &quot;GRTT&quot;.
    /// </summary>
    [EnumMember(Value = "GRTT")]
    [IsoId("_5aa0YY0XEeWRYffwL7E13A")]
    [Description(@"Card payment with gratuity.")]
    Gratuity = CardPaymentServiceTypeCode.Gratuity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loyalty services.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_5aa0Y40XEeWRYffwL7E13A")]
    [Description(@"Loyalty services.")]
    Loyalty = CardPaymentServiceTypeCode.Loyalty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No show after reservation.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_5aa0ZY0XEeWRYffwL7E13A")]
    [Description(@"No show after reservation.")]
    NoShow = CardPaymentServiceTypeCode.NoShow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchase and corporate data.
    /// Encoded/decoded by serializers as &quot;PUCO&quot;.
    /// </summary>
    [EnumMember(Value = "PUCO")]
    [IsoId("_5aa0Z40XEeWRYffwL7E13A")]
    [Description(@"Purchase and corporate data.")]
    PurchaseCorporate = CardPaymentServiceTypeCode.PurchaseCorporate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_5aa0aY0XEeWRYffwL7E13A")]
    [Description(@"Recurring payment.")]
    RecurringPayment = CardPaymentServiceTypeCode.RecurringPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Solicited available funds.
    /// Encoded/decoded by serializers as &quot;SOAF&quot;.
    /// </summary>
    [EnumMember(Value = "SOAF")]
    [IsoId("_5aa0a40XEeWRYffwL7E13A")]
    [Description(@"Solicited available funds.")]
    SolicitedAvailableFunds = CardPaymentServiceTypeCode.SolicitedAvailableFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Voice authorisation.
    /// Encoded/decoded by serializers as &quot;VCAU&quot;.
    /// </summary>
    [EnumMember(Value = "VCAU")]
    [IsoId("_5aa0bY0XEeWRYffwL7E13A")]
    [Description(@"Voice authorisation.")]
    VoiceAuthorisation = CardPaymentServiceTypeCode.VoiceAuthorisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instalment payment transaction performed by the card issuer.
    /// Encoded/decoded by serializers as &quot;INSI&quot;.
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_5aa0b40XEeWRYffwL7E13A")]
    [Description(@"Instalment payment transaction performed by the card issuer.")]
    IssuerInstalment = CardPaymentServiceTypeCode.IssuerInstalment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instalment payment transaction performed by the acceptor or the acquirer.
    /// Encoded/decoded by serializers as &quot;INSA&quot;.
    /// </summary>
    [EnumMember(Value = "INSA")]
    [IsoId("_5aa0cY0XEeWRYffwL7E13A")]
    [Description(@"Instalment payment transaction performed by the acceptor or the acquirer.")]
    AcceptorInstalment = CardPaymentServiceTypeCode.AcceptorInstalment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_5aa0c40XEeWRYffwL7E13A")]
    [Description(@"Card payment with cash-back.")]
    CashBack = CardPaymentServiceTypeCode.CashBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instant transaction.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_-c520Y0XEeWRYffwL7E13A")]
    [Description(@"Instant transaction.")]
    Instant = CardPaymentServiceTypeCode.Instant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment of goods or services which are not refundable, for instance low cost airline tickets.
    /// Encoded/decoded by serializers as &quot;NRFD&quot;.
    /// </summary>
    [EnumMember(Value = "NRFD")]
    [IsoId("_-rXJk40XEeWRYffwL7E13A")]
    [Description(@"Payment of goods or services which are not refundable, for instance low cost airline tickets.")]
    NonRefundable = CardPaymentServiceTypeCode.NonRefundable, // same ordinal as derivation source for type conversions
    
}
