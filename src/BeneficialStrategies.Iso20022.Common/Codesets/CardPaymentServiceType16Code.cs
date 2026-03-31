// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Main service provided during the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sXyTsZxGEe-Jl6tBAvMHqA")]
[Description(@"Main service provided during the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType16Code
{
    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("")]
    [Description(@"Balance enquiry.")]
    Balance = CardPaymentServiceTypeCode.Balance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("")]
    [Description(@"Card activation.")]
    CardActivation = CardPaymentServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds to a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFH&quot;.
    /// </summary>
    [EnumMember(Value = "CAFH")]
    [IsoId("")]
    [Description(@"Transfer of funds to a card or an account.")]
    CardsFundTransferPush = CardPaymentServiceTypeCode.CardsFundTransferPush, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds from a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFL&quot;.
    /// </summary>
    [EnumMember(Value = "CAFL")]
    [IsoId("")]
    [Description(@"Transfer of funds from a card or an account.")]
    CardsFundTransferPull = CardPaymentServiceTypeCode.CardsFundTransferPull, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as &quot;CAFT&quot;.
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer = CardPaymentServiceTypeCode.CardsFundTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as &quot;CAVR&quot;.
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("")]
    [Description(@"Card verification.")]
    CardVerification = CardPaymentServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as &quot;CRDP&quot;.
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("")]
    [Description(@"Card payment.")]
    CardPayment = CardPaymentServiceTypeCode.CardPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("")]
    [Description(@"Cash deposit.")]
    CashDeposit = CardPaymentServiceTypeCode.CashDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("")]
    [Description(
        @"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter."
    )]
    CashAdvance = CardPaymentServiceTypeCode.CashAdvance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("")]
    [Description(@"Deferred payment.")]
    DeferredPayment = CardPaymentServiceTypeCode.DeferredPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading = CardPaymentServiceTypeCode.Loading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as &quot;ORCR&quot;.
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("")]
    [Description(@"Original credit.")]
    OriginalCredit = CardPaymentServiceTypeCode.OriginalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange = CardPaymentServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used to inform the POI that it could select the payment instrument type to use.
    /// Encoded/decoded by serializers as &quot;PPMS&quot;.
    /// </summary>
    [EnumMember(Value = "PPMS")]
    [IsoId("")]
    [Description(
        @"Used to inform the POI that it could select the payment instrument type to use."
    )]
    POIPaymentMethodSelection = CardPaymentServiceTypeCode.POIPaymentMethodSelection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as &quot;QUCH&quot;.
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("")]
    [Description(@"Quasi-cash.")]
    QuasiCash = CardPaymentServiceTypeCode.QuasiCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation = CardPaymentServiceTypeCode.Reservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as &quot;RFND&quot;.
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("")]
    [Description(@"Refund transaction.")]
    Refund = CardPaymentServiceTypeCode.Refund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unloading non-financial account.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("")]
    [Description(@"Unloading non-financial account.")]
    Unloading = CardPaymentServiceTypeCode.Unloading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as &quot;VALC&quot;.
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("")]
    [Description(@"Card validity check.")]
    ValidityCheck = CardPaymentServiceTypeCode.ValidityCheck, // same ordinal as derivation source for type conversions
}
