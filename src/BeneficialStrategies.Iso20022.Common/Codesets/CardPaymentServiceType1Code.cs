// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service provided by the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSg-gQEcEeCQm6a_G2yO_w_1098554220")]
[Description(@"Type of service provided by the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardPaymentServiceType1Code>))]
#endif
public enum CardPaymentServiceType1Code
{
    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as &quot;CAFT&quot;.
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_TSg-ggEcEeCQm6a_G2yO_w_-897565888")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer = CardPaymentServiceTypeCode.CardsFundTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as &quot;ORCR&quot;.
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_TSqIYAEcEeCQm6a_G2yO_w_565206622")]
    [Description(@"Original credit.")]
    OriginalCredit = CardPaymentServiceTypeCode.OriginalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as &quot;CRDP&quot;.
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_TSqIYQEcEeCQm6a_G2yO_w_-717150152")]
    [Description(@"Card payment.")]
    CardPayment = CardPaymentServiceTypeCode.CardPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_TSqIYgEcEeCQm6a_G2yO_w_1357942539")]
    [Description(@"Card payment with cash-back.")]
    CashBack = CardPaymentServiceTypeCode.CashBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_TSqIYwEcEeCQm6a_G2yO_w_-1031105037")]
    [Description(
        @"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter."
    )]
    CashAdvance = CardPaymentServiceTypeCode.CashAdvance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_TSqIZAEcEeCQm6a_G2yO_w_906120136")]
    [Description(@"Cash deposit.")]
    CashDeposit = CardPaymentServiceTypeCode.CashDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_TSqIZQEcEeCQm6a_G2yO_w_2032417257")]
    [Description(@"Deferred payment.")]
    DeferredPayment = CardPaymentServiceTypeCode.DeferredPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_TSqIZgEcEeCQm6a_G2yO_w_-1249057676")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation = CardPaymentServiceTypeCode.Reservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_TSqIZwEcEeCQm6a_G2yO_w_807680454")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading = CardPaymentServiceTypeCode.Loading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as &quot;RFND&quot;.
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_TSqIaAEcEeCQm6a_G2yO_w_1446470231")]
    [Description(@"Refund transaction.")]
    Refund = CardPaymentServiceTypeCode.Refund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as &quot;QUCH&quot;.
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_TSqIaQEcEeCQm6a_G2yO_w_46915301")]
    [Description(@"Quasi-cash.")]
    QuasiCash = CardPaymentServiceTypeCode.QuasiCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_TSqIagEcEeCQm6a_G2yO_w_14944537")]
    [Description(@"Balance enquiry.")]
    Balance = CardPaymentServiceTypeCode.Balance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_TSqIawEcEeCQm6a_G2yO_w_-1270792527")]
    [Description(@"Card activation.")]
    CardActivation = CardPaymentServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as &quot;CAVR&quot;.
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_TSqIbAEcEeCQm6a_G2yO_w_1319956496")]
    [Description(@"Card verification.")]
    CardVerification = CardPaymentServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_TSqIbQEcEeCQm6a_G2yO_w_554107845")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange = CardPaymentServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as &quot;VALC&quot;.
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_TSqIbgEcEeCQm6a_G2yO_w_1086949596")]
    [Description(@"Card validity check.")]
    ValidityCheck = CardPaymentServiceTypeCode.ValidityCheck, // same ordinal as derivation source for type conversions
}
