// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of payment instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qu5i8ZxJEe-Jl6tBAvMHqA")]
[Description(@"Type of payment instrument.")]
[DerivedFrom(typeof(PaymentInstrumentTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PaymentInstrumentType2Code>))]
public enum PaymentInstrumentType2Code
{
    /// <summary>
    /// Payment card (credit or debit).
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_qwEnoZxJEe-Jl6tBAvMHqA")]
    [Description(@"Payment card (credit or debit).")]
    Card = PaymentInstrumentTypeCode.Card, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash managed by a cash handling system.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_qwEno5xJEe-Jl6tBAvMHqA")]
    [Description(@"Cash managed by a cash handling system.")]
    Cash = PaymentInstrumentTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Paper check.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_qwEnpZxJEe-Jl6tBAvMHqA")]
    [Description(@"Paper check.")]
    Check = PaymentInstrumentTypeCode.Check, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment made by transferring an amount of money from a debtor to a creditor.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_nME8EaDhEe-MRKYsaX6JDg")]
    [Description(
        @"Payment made by transferring an amount of money from a debtor to a creditor. The payment flows through one or more financial institutions or systems."
    )]
    CreditTransfer = PaymentInstrumentTypeCode.CreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment, initiated by the creditor, to debit a debtor's account in favour of the creditor.
    /// Encoded/decoded by serializers as &quot;DRDT&quot;.
    /// </summary>
    [EnumMember(Value = "DRDT")]
    [IsoId("_mqXWIaDhEe-MRKYsaX6JDg")]
    [Description(
        @"Payment, initiated by the creditor, to debit a debtor's account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor."
    )]
    DirectDebit = PaymentInstrumentTypeCode.DirectDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account using loyalty processing.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_qwEnp5xJEe-Jl6tBAvMHqA")]
    [Description(@"Account using loyalty processing.")]
    LoyaltyAccount = PaymentInstrumentTypeCode.LoyaltyAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account accessed by a stored value instrument such as a card or a certificate.
    /// Encoded/decoded by serializers as &quot;SVAC&quot;.
    /// </summary>
    [EnumMember(Value = "SVAC")]
    [IsoId("_qwEnqZxJEe-Jl6tBAvMHqA")]
    [Description(@"Account accessed by a stored value instrument such as a card or a certificate.")]
    StoredValueAccount = PaymentInstrumentTypeCode.StoredValueAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bond of the redeemable transaction type which is worth a certain monetary value and which may be spent only for specific reasons or on specific goods.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_nWs3saDhEe-MRKYsaX6JDg")]
    [Description(
        @"Bond of the redeemable transaction type which is worth a certain monetary value and which may be spent only for specific reasons or on specific goods."
    )]
    PaymentVoucher = PaymentInstrumentTypeCode.PaymentVoucher, // same ordinal as derivation source for type conversions
}
