// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of transaction being undertaken for the main service.
/// It correspond partially to the ISO 8583, field number 3.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PJRG4HsuEeSTS7uHCe8FPQ")]
[Description(
    @"Type of transaction being undertaken for the main service. |It correspond partially to the ISO 8583, field number 3."
)]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardPaymentServiceType7Code>))]
#endif
public enum CardPaymentServiceType7Code
{
    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_Yik_oHsuEeSTS7uHCe8FPQ")]
    [Description(@"Balance enquiry.")]
    Balance = CardPaymentServiceTypeCode.Balance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_ZWehwXsuEeSTS7uHCe8FPQ")]
    [Description(@"Card activation.")]
    CardActivation = CardPaymentServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as &quot;CRDP&quot;.
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_ZeBUMXsuEeSTS7uHCe8FPQ")]
    [Description(@"Card payment.")]
    CardPayment = CardPaymentServiceTypeCode.CardPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as &quot;CAFT&quot;.
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_abvgsXsuEeSTS7uHCe8FPQ")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer = CardPaymentServiceTypeCode.CardsFundTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds from a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFL&quot;.
    /// </summary>
    [EnumMember(Value = "CAFL")]
    [IsoId("_aim9sXsuEeSTS7uHCe8FPQ")]
    [Description(@"Transfer of funds from a card or an account.")]
    CardsFundTransferPull = CardPaymentServiceTypeCode.CardsFundTransferPull, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds to a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFH&quot;.
    /// </summary>
    [EnumMember(Value = "CAFH")]
    [IsoId("_aoQSsXsuEeSTS7uHCe8FPQ")]
    [Description(@"Transfer of funds to a card or an account.")]
    CardsFundTransferPush = CardPaymentServiceTypeCode.CardsFundTransferPush, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as &quot;CAVR&quot;.
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_biFdsHsuEeSTS7uHCe8FPQ")]
    [Description(@"Card verification.")]
    CardVerification = CardPaymentServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_byGPoXsuEeSTS7uHCe8FPQ")]
    [Description(
        @"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter."
    )]
    CashAdvance = CardPaymentServiceTypeCode.CashAdvance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_b7eOEXsuEeSTS7uHCe8FPQ")]
    [Description(@"Cash deposit.")]
    CashDeposit = CardPaymentServiceTypeCode.CashDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal of cash on an ATM.
    /// Encoded/decoded by serializers as &quot;CHWD&quot;.
    /// </summary>
    [EnumMember(Value = "CHWD")]
    [IsoId("_dMvosXsuEeSTS7uHCe8FPQ")]
    [Description(@"Withdrawal of cash on an ATM.")]
    CashWithdrawal = CardPaymentServiceTypeCode.CashWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_dZaLsXsuEeSTS7uHCe8FPQ")]
    [Description(@"Deferred payment.")]
    DeferredPayment = CardPaymentServiceTypeCode.DeferredPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_eW02MXsuEeSTS7uHCe8FPQ")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading = CardPaymentServiceTypeCode.Loading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as &quot;ORCR&quot;.
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_eo1MMXsuEeSTS7uHCe8FPQ")]
    [Description(@"Original credit.")]
    OriginalCredit = CardPaymentServiceTypeCode.OriginalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_e2B6sXsuEeSTS7uHCe8FPQ")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange = CardPaymentServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unblock the cardholder PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_f5KysXsuEeSTS7uHCe8FPQ")]
    [Description(@"Unblock the cardholder PIN.")]
    PINUnblock = CardPaymentServiceTypeCode.PINUnblock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as &quot;QUCH&quot;.
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_gF6OMXsuEeSTS7uHCe8FPQ")]
    [Description(@"Quasi-cash.")]
    QuasiCash = CardPaymentServiceTypeCode.QuasiCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as &quot;RFND&quot;.
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_gq6YsXsuEeSTS7uHCe8FPQ")]
    [Description(@"Refund transaction.")]
    Refund = CardPaymentServiceTypeCode.Refund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_gyTaIXsuEeSTS7uHCe8FPQ")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation = CardPaymentServiceTypeCode.Reservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unloading non-financial account.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_hlcHQXsuEeSTS7uHCe8FPQ")]
    [Description(@"Unloading non-financial account.")]
    Unloading = CardPaymentServiceTypeCode.Unloading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as &quot;VALC&quot;.
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_hwUhkXsuEeSTS7uHCe8FPQ")]
    [Description(@"Card validity check.")]
    ValidityCheck = CardPaymentServiceTypeCode.ValidityCheck, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit adjustment to a previous transaction.
    /// Encoded/decoded by serializers as &quot;DADJ&quot;.
    /// </summary>
    [EnumMember(Value = "DADJ")]
    [IsoId("_p9pr0S-KEeWfYucYWs4iQg")]
    [Description(@"Debit adjustment to a previous transaction.")]
    DebitAdjustement = CardPaymentServiceTypeCode.DebitAdjustement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit adjustment to a previous transaction.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_qG5HYS-KEeWfYucYWs4iQg")]
    [Description(@"Credit adjustment to a previous transaction.")]
    CreditAdjustement = CardPaymentServiceTypeCode.CreditAdjustement, // same ordinal as derivation source for type conversions
}
