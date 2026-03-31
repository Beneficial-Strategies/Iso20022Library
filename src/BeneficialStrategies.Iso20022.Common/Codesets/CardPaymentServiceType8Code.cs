// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Main card service transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CPqhwHsvEeSTS7uHCe8FPQ")]
[Description(@"Main card service transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardPaymentServiceType8Code>))]
#endif
public enum CardPaymentServiceType8Code
{
    /// <summary>
    /// Aggregation of low payments.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_LBMBwXsvEeSTS7uHCe8FPQ")]
    [Description(@"Aggregation of low payments.")]
    Aggregation = CardPaymentServiceTypeCode.Aggregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_LlfosXsvEeSTS7uHCe8FPQ")]
    [Description(@"Card payment with cash-back.")]
    CashBack = CardPaymentServiceTypeCode.CashBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CSWD&quot;.
    /// </summary>
    [EnumMember(Value = "CSWD")]
    [IsoId("_L0wMsXsvEeSTS7uHCe8FPQ")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal = CardPaymentServiceTypeCode.ChosenWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic currency conversion (DCC).
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_NKkJEXsvEeSTS7uHCe8FPQ")]
    [Description(@"Dynamic currency conversion (DCC).")]
    DCC = CardPaymentServiceTypeCode.DCC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment with gratuity.
    /// Encoded/decoded by serializers as &quot;GRTT&quot;.
    /// </summary>
    [EnumMember(Value = "GRTT")]
    [IsoId("_NYAvMXsvEeSTS7uHCe8FPQ")]
    [Description(@"Card payment with gratuity.")]
    Gratuity = CardPaymentServiceTypeCode.Gratuity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment payment transaction performed by the acceptor or the acquirer.
    /// Encoded/decoded by serializers as &quot;INSA&quot;.
    /// </summary>
    [EnumMember(Value = "INSA")]
    [IsoId("_NtmksXsvEeSTS7uHCe8FPQ")]
    [Description(@"Instalment payment transaction performed by the acceptor or the acquirer.")]
    AcceptorInstalment = CardPaymentServiceTypeCode.AcceptorInstalment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment payment transaction performed by the card issuer.
    /// Encoded/decoded by serializers as &quot;INSI&quot;.
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_ROSdMXsvEeSTS7uHCe8FPQ")]
    [Description(@"Instalment payment transaction performed by the card issuer.")]
    IssuerInstalment = CardPaymentServiceTypeCode.IssuerInstalment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loyalty services.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_SVeHsXsvEeSTS7uHCe8FPQ")]
    [Description(@"Loyalty services.")]
    Loyalty = CardPaymentServiceTypeCode.Loyalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No show after reservation.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_S7FWMXsvEeSTS7uHCe8FPQ")]
    [Description(@"No show after reservation.")]
    NoShow = CardPaymentServiceTypeCode.NoShow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel (amount could be absent).
    /// Encoded/decoded by serializers as &quot;AUWS&quot;.
    /// </summary>
    [EnumMember(Value = "AUWS")]
    [IsoId("_Te2xoXsvEeSTS7uHCe8FPQ")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel (amount could be absent)."
    )]
    PreAuthorisedWithdrawal = CardPaymentServiceTypeCode.PreAuthorisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and Notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PFWD&quot;.
    /// </summary>
    [EnumMember(Value = "PFWD")]
    [IsoId("_UwHlMXsvEeSTS7uHCe8FPQ")]
    [Description(@"Amount and Notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal = CardPaymentServiceTypeCode.ProfileWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase and corporate data.
    /// Encoded/decoded by serializers as &quot;PUCO&quot;.
    /// </summary>
    [EnumMember(Value = "PUCO")]
    [IsoId("_U4bzsXsvEeSTS7uHCe8FPQ")]
    [Description(@"Purchase and corporate data.")]
    PurchaseCorporate = CardPaymentServiceTypeCode.PurchaseCorporate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_VxRgMXsvEeSTS7uHCe8FPQ")]
    [Description(@"Recurring payment.")]
    RecurringPayment = CardPaymentServiceTypeCode.RecurringPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Solicited available funds.
    /// Encoded/decoded by serializers as &quot;SOAF&quot;.
    /// </summary>
    [EnumMember(Value = "SOAF")]
    [IsoId("_V9jBoXsvEeSTS7uHCe8FPQ")]
    [Description(@"Solicited available funds.")]
    SolicitedAvailableFunds = CardPaymentServiceTypeCode.SolicitedAvailableFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer pressed a button associated with a withdrawal of unique amount and notes mix.
    /// Encoded/decoded by serializers as &quot;SDWD&quot;.
    /// </summary>
    [EnumMember(Value = "SDWD")]
    [IsoId("_W3BAQXsvEeSTS7uHCe8FPQ")]
    [Description(
        @"Customer pressed a button associated with a withdrawal of unique amount and notes mix."
    )]
    StandardWithdrawal = CardPaymentServiceTypeCode.StandardWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voice authorisation.
    /// Encoded/decoded by serializers as &quot;VCAU&quot;.
    /// </summary>
    [EnumMember(Value = "VCAU")]
    [IsoId("_XGMEsXsvEeSTS7uHCe8FPQ")]
    [Description(@"Voice authorisation.")]
    VoiceAuthorisation = CardPaymentServiceTypeCode.VoiceAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment of goods or services which are not refundable, for instance low cost airline tickets.
    /// Encoded/decoded by serializers as &quot;NRFD&quot;.
    /// </summary>
    [EnumMember(Value = "NRFD")]
    [IsoId("_PZpogYIOEeSvPp7yXrNQIw")]
    [Description(
        @"Payment of goods or services which are not refundable, for instance low cost airline tickets."
    )]
    NonRefundable = CardPaymentServiceTypeCode.NonRefundable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instant transaction.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_qWNyQS-JEeWfYucYWs4iQg")]
    [Description(@"Instant transaction.")]
    Instant = CardPaymentServiceTypeCode.Instant, // same ordinal as derivation source for type conversions
}
