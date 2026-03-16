// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Main service provided during the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2MgP0dnZEeeN3v2fup_Shw")]
[Description(@"Main service provided during the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType12Code
{
    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_2V7RkdnZEeeN3v2fup_Shw")]
    [Description(@"Balance enquiry.")]
    Balance = CardPaymentServiceTypeCode.Balance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_2V7Rk9nZEeeN3v2fup_Shw")]
    [Description(@"Card activation.")]
    CardActivation = CardPaymentServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as &quot;CRDP&quot;.
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_2V7RldnZEeeN3v2fup_Shw")]
    [Description(@"Card payment.")]
    CardPayment = CardPaymentServiceTypeCode.CardPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds to a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFH&quot;.
    /// </summary>
    [EnumMember(Value = "CAFH")]
    [IsoId("_2V7Rl9nZEeeN3v2fup_Shw")]
    [Description(@"Transfer of funds to a card or an account.")]
    CardsFundTransferPush = CardPaymentServiceTypeCode.CardsFundTransferPush, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as &quot;CAVR&quot;.
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_2V7RmdnZEeeN3v2fup_Shw")]
    [Description(@"Card verification.")]
    CardVerification = CardPaymentServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_2V7Rm9nZEeeN3v2fup_Shw")]
    [Description(
        @"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter."
    )]
    CashAdvance = CardPaymentServiceTypeCode.CashAdvance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_2V7RndnZEeeN3v2fup_Shw")]
    [Description(@"Cash deposit.")]
    CashDeposit = CardPaymentServiceTypeCode.CashDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_2V7Rn9nZEeeN3v2fup_Shw")]
    [Description(@"Deferred payment.")]
    DeferredPayment = CardPaymentServiceTypeCode.DeferredPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_2V7RodnZEeeN3v2fup_Shw")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading = CardPaymentServiceTypeCode.Loading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as &quot;ORCR&quot;.
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_2V7Ro9nZEeeN3v2fup_Shw")]
    [Description(@"Original credit.")]
    OriginalCredit = CardPaymentServiceTypeCode.OriginalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_2V7RpdnZEeeN3v2fup_Shw")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange = CardPaymentServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as &quot;QUCH&quot;.
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_2V7Rp9nZEeeN3v2fup_Shw")]
    [Description(@"Quasi-cash.")]
    QuasiCash = CardPaymentServiceTypeCode.QuasiCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as &quot;RFND&quot;.
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_2V7RqdnZEeeN3v2fup_Shw")]
    [Description(@"Refund transaction.")]
    Refund = CardPaymentServiceTypeCode.Refund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_2V7Rq9nZEeeN3v2fup_Shw")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation = CardPaymentServiceTypeCode.Reservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as &quot;VALC&quot;.
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_2V7RrdnZEeeN3v2fup_Shw")]
    [Description(@"Card validity check.")]
    ValidityCheck = CardPaymentServiceTypeCode.ValidityCheck, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unloading non-financial account.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_2V7Rr9nZEeeN3v2fup_Shw")]
    [Description(@"Unloading non-financial account.")]
    Unloading = CardPaymentServiceTypeCode.Unloading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as &quot;CAFT&quot;.
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_2V7RsdnZEeeN3v2fup_Shw")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer = CardPaymentServiceTypeCode.CardsFundTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds from a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFL&quot;.
    /// </summary>
    [EnumMember(Value = "CAFL")]
    [IsoId("_2V7Rs9nZEeeN3v2fup_Shw")]
    [Description(@"Transfer of funds from a card or an account.")]
    CardsFundTransferPull = CardPaymentServiceTypeCode.CardsFundTransferPull, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct Debit initiated by Card.
    /// Encoded/decoded by serializers as &quot;CIDD&quot;.
    /// </summary>
    [EnumMember(Value = "CIDD")]
    [IsoId("_4jCpYdnZEeeN3v2fup_Shw")]
    [Description(@"Direct Debit initiated by Card.")]
    CardInitiatingDirectDebit = CardPaymentServiceTypeCode.CardInitiatingDirectDebit, // same ordinal as derivation source for type conversions
}
