// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to indicate a certain level of risk for the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1GyxYHsKEeSR68OJvMfxJQ")]
[Description(@"Reason to indicate a certain level of risk for the transaction.")]
[Derivations(typeof(CardTransactionRiskReason1Code))]
public enum CardTransactionRiskReasonCode
{
    /// <summary>
    /// Suspicious sequence of approve and decline messages.
    /// Encoded/decoded by serializers as &quot;APDL&quot;.
    /// </summary>
    [EnumMember(Value = "APDL")]
    [IsoId("_5Op-oHsKEeSR68OJvMfxJQ")]
    [Description(@"Suspicious sequence of approve and decline messages.")]
    ApproveDeclineSequence,

    /// <summary>
    /// Suspicious authorization activity.
    /// Encoded/decoded by serializers as &quot;ATHA&quot;.
    /// </summary>
    [EnumMember(Value = "ATHA")]
    [IsoId("_8lU_gHsKEeSR68OJvMfxJQ")]
    [Description(@"Suspicious authorization activity.")]
    AuthorizationActivity,

    /// <summary>
    /// Suspicious approve or decline pattern.
    /// Encoded/decoded by serializers as &quot;APDP&quot;.
    /// </summary>
    [EnumMember(Value = "APDP")]
    [IsoId("_TbeQ0HsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious approve or decline pattern.")]
    ApproveDeclinePattern,

    /// <summary>
    /// Compromised card.
    /// Encoded/decoded by serializers as &quot;CRDC&quot;.
    /// </summary>
    [EnumMember(Value = "CRDC")]
    [IsoId("_W4E6kHsLEeSR68OJvMfxJQ")]
    [Description(@"Compromised card.")]
    CompromisedCard,

    /// <summary>
    /// Suspicious electronic commerce activity.
    /// Encoded/decoded by serializers as &quot;ECMA&quot;.
    /// </summary>
    [EnumMember(Value = "ECMA")]
    [IsoId("_ZuvlsHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious electronic commerce activity.")]
    EcommerceActivity,

    /// <summary>
    /// Expiry date mismatch.
    /// Encoded/decoded by serializers as &quot;EXCD&quot;.
    /// </summary>
    [EnumMember(Value = "EXCD")]
    [IsoId("_dsnwgHsLEeSR68OJvMfxJQ")]
    [Description(@"Expiry date mismatch.")]
    ExpiryDateMismatch,

    /// <summary>
    /// Suspicious foreign activity.
    /// Encoded/decoded by serializers as &quot;FGNA&quot;.
    /// </summary>
    [EnumMember(Value = "FGNA")]
    [IsoId("_hl-nsHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious foreign activity.")]
    ForeignActivity,

    /// <summary>
    /// Suspicious geographic activity.
    /// Encoded/decoded by serializers as &quot;GEOA&quot;.
    /// </summary>
    [EnumMember(Value = "GEOA")]
    [IsoId("_mKulQHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious geographic activity.")]
    GeographicActivity,

    /// <summary>
    /// High Risk MCC (Merchant Category Code).
    /// Encoded/decoded by serializers as &quot;MCCH&quot;.
    /// </summary>
    [EnumMember(Value = "MCCH")]
    [IsoId("_pzFzEHsLEeSR68OJvMfxJQ")]
    [Description(@"High Risk MCC (Merchant Category Code).")]
    HighRiskMCC,

    /// <summary>
    /// Suspicious manual card data entry mode.
    /// Encoded/decoded by serializers as &quot;KEYA&quot;.
    /// </summary>
    [EnumMember(Value = "KEYA")]
    [IsoId("_vtO2QHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious manual card data entry mode.")]
    ManualEntryActivity,

    /// <summary>
    /// Suspicious MCC (Merchant Category Code) activity.
    /// Encoded/decoded by serializers as &quot;MCCA&quot;.
    /// </summary>
    [EnumMember(Value = "MCCA")]
    [IsoId("_yk4_4HsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious MCC (Merchant Category Code) activity.")]
    MerchantCategoryActivity,

    /// <summary>
    /// Suspicious amount.
    /// Encoded/decoded by serializers as &quot;AMNT&quot;.
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_5X3IgHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious amount.")]
    SuspiciousAmount,

    /// <summary>
    /// Suspicious fraudulent cardholder.
    /// Encoded/decoded by serializers as &quot;CRDF&quot;.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_78LfYHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious fraudulent cardholder.")]
    SuspiciousFraudulentCardholder,

    /// <summary>
    /// Suspicious fraudulent merchant.
    /// Encoded/decoded by serializers as &quot;MRCF&quot;.
    /// </summary>
    [EnumMember(Value = "MRCF")]
    [IsoId("_O0vg0HsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious fraudulent merchant.")]
    SuspiciousFraudulentMerchant,

    /// <summary>
    /// Suspicious transaction cumulated amount at merchant.
    /// Encoded/decoded by serializers as &quot;TXCA&quot;.
    /// </summary>
    [EnumMember(Value = "TXCA")]
    [IsoId("_Xjk5MHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction cumulated amount at merchant.")]
    TransactionCumulativeAmount,

    /// <summary>
    /// Suspicious transaction number at merchant.
    /// Encoded/decoded by serializers as &quot;TXNB&quot;.
    /// </summary>
    [EnumMember(Value = "TXNB")]
    [IsoId("_bh-ocHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction number at merchant.")]
    TransactionNumber,

    /// <summary>
    /// Suspicious transaction time interval.
    /// Encoded/decoded by serializers as &quot;TMIN&quot;.
    /// </summary>
    [EnumMember(Value = "TMIN")]
    [IsoId("_eN8fcHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction time interval.")]
    TransactionTimeIinterval,

    /// <summary>
    /// Suspicious transaction time.
    /// Encoded/decoded by serializers as &quot;TXTM&quot;.
    /// </summary>
    [EnumMember(Value = "TXTM")]
    [IsoId("_hZ4P8HsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction time.")]
    TransactionTime,

    /// <summary>
    /// Suspicious transaction type.
    /// Encoded/decoded by serializers as &quot;TXTP&quot;.
    /// </summary>
    [EnumMember(Value = "TXTP")]
    [IsoId("_koHGgHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction type.")]
    TransactionType,

    /// <summary>
    /// Suspicious unattended terminal activity.
    /// Encoded/decoded by serializers as &quot;UATA&quot;.
    /// </summary>
    [EnumMember(Value = "UATA")]
    [IsoId("_tQX80HsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious unattended terminal activity.")]
    UnattendedActivity,
}
