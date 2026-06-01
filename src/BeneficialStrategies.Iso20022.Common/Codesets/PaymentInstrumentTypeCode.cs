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
[IsoId("_MoMKoNxgEeioifFt1dhnJA")]
[Description(@"Type of payment instrument.")]
[Derivations(
    typeof(PaymentInstrumentType1Code),
    typeof(PaymentInstrumentType2Code)
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PaymentInstrumentTypeCode>))]
public enum PaymentInstrumentTypeCode
{
    /// <summary>
    /// Payment card (credit or debit).
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_SadrQNxgEeioifFt1dhnJA")]
    [Description(@"Payment card (credit or debit).")]
    Card,

    /// <summary>
    /// Paper check.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_UlszwNxgEeioifFt1dhnJA")]
    [Description(@"Paper check.")]
    Check,

    /// <summary>
    /// Account accessed by a stored value instrument such as a card or a certificate.
    /// Encoded/decoded by serializers as &quot;SVAC&quot;.
    /// </summary>
    [EnumMember(Value = "SVAC")]
    [IsoId("_Wh6BwNxgEeioifFt1dhnJA")]
    [Description(@"Account accessed by a stored value instrument such as a card or a certificate.")]
    StoredValueAccount,

    /// <summary>
    /// Cash managed by a cash handling system.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aoljQNxgEeioifFt1dhnJA")]
    [Description(@"Cash managed by a cash handling system.")]
    Cash,

    /// <summary>
    /// Account using loyalty processing.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_ci9lQNxgEeioifFt1dhnJA")]
    [Description(@"Account using loyalty processing.")]
    LoyaltyAccount,

    /// <summary>
    /// Payment made by transferring an amount of money from a debtor to a creditor.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_Yi8f8Jw1Ee--557UVrMuSQ")]
    [Description(
        @"Payment made by transferring an amount of money from a debtor to a creditor. The payment flows through one or more financial institutions or systems."
    )]
    CreditTransfer,

    /// <summary>
    /// Payment, initiated by the creditor, to debit a debtor's account in favour of the creditor.
    /// Encoded/decoded by serializers as &quot;DRDT&quot;.
    /// </summary>
    [EnumMember(Value = "DRDT")]
    [IsoId("_UUjM4Jw1Ee--557UVrMuSQ")]
    [Description(
        @"Payment, initiated by the creditor, to debit a debtor's account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor."
    )]
    DirectDebit,

    /// <summary>
    /// Bond of the redeemable transaction type which is worth a certain monetary value and which may be spent only for specific reasons or on specific goods.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_cxargJw1Ee--557UVrMuSQ")]
    [Description(
        @"Bond of the redeemable transaction type which is worth a certain monetary value and which may be spent only for specific reasons or on specific goods."
    )]
    PaymentVoucher,
}
