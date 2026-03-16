// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to indicate a certain level of risk for the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5YSw4HsMEeSR68OJvMfxJQ")]
[Description(@"Reason to indicate a certain level of risk for the transaction.")]
[DerivedFrom(typeof(CardTransactionRiskReasonCode))]
public enum CardTransactionRiskReason1Code
{
    /// <summary>
    /// Suspicious approve or decline pattern.
    /// Encoded/decoded by serializers as &quot;APDP&quot;.
    /// </summary>
    [EnumMember(Value = "APDP")]
    [IsoId("_CN5foXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious approve or decline pattern.")]
    ApproveDeclinePattern = CardTransactionRiskReasonCode.ApproveDeclinePattern, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious sequence of approve and decline messages.
    /// Encoded/decoded by serializers as &quot;APDL&quot;.
    /// </summary>
    [EnumMember(Value = "APDL")]
    [IsoId("_CTaRwXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious sequence of approve and decline messages.")]
    ApproveDeclineSequence = CardTransactionRiskReasonCode.ApproveDeclineSequence, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious authorization activity.
    /// Encoded/decoded by serializers as &quot;ATHA&quot;.
    /// </summary>
    [EnumMember(Value = "ATHA")]
    [IsoId("_CYxS4XsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious authorization activity.")]
    AuthorizationActivity = CardTransactionRiskReasonCode.AuthorizationActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Compromised card.
    /// Encoded/decoded by serializers as &quot;CRDC&quot;.
    /// </summary>
    [EnumMember(Value = "CRDC")]
    [IsoId("_CfEvMXsNEeSR68OJvMfxJQ")]
    [Description(@"Compromised card.")]
    CompromisedCard = CardTransactionRiskReasonCode.CompromisedCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious electronic commerce activity.
    /// Encoded/decoded by serializers as &quot;ECMA&quot;.
    /// </summary>
    [EnumMember(Value = "ECMA")]
    [IsoId("_CkcXYXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious electronic commerce activity.")]
    EcommerceActivity = CardTransactionRiskReasonCode.EcommerceActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Expiry date mismatch.
    /// Encoded/decoded by serializers as &quot;EXCD&quot;.
    /// </summary>
    [EnumMember(Value = "EXCD")]
    [IsoId("_CsC0MXsNEeSR68OJvMfxJQ")]
    [Description(@"Expiry date mismatch.")]
    ExpiryDateMismatch = CardTransactionRiskReasonCode.ExpiryDateMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious foreign activity.
    /// Encoded/decoded by serializers as &quot;FGNA&quot;.
    /// </summary>
    [EnumMember(Value = "FGNA")]
    [IsoId("_CxZ1UXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious foreign activity.")]
    ForeignActivity = CardTransactionRiskReasonCode.ForeignActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious geographic activity.
    /// Encoded/decoded by serializers as &quot;GEOA&quot;.
    /// </summary>
    [EnumMember(Value = "GEOA")]
    [IsoId("_C2xdgXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious geographic activity.")]
    GeographicActivity = CardTransactionRiskReasonCode.GeographicActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// High Risk MCC (Merchant Category Code).
    /// Encoded/decoded by serializers as &quot;MCCH&quot;.
    /// </summary>
    [EnumMember(Value = "MCCH")]
    [IsoId("_C84FgXsNEeSR68OJvMfxJQ")]
    [Description(@"High Risk MCC (Merchant Category Code).")]
    HighRiskMCC = CardTransactionRiskReasonCode.HighRiskMCC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious manual card data entry mode.
    /// Encoded/decoded by serializers as &quot;KEYA&quot;.
    /// </summary>
    [EnumMember(Value = "KEYA")]
    [IsoId("_DFhEIXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious manual card data entry mode.")]
    ManualEntryActivity = CardTransactionRiskReasonCode.ManualEntryActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious MCC (Merchant Category Code) activity.
    /// Encoded/decoded by serializers as &quot;MCCA&quot;.
    /// </summary>
    [EnumMember(Value = "MCCA")]
    [IsoId("_DK4sUXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious MCC (Merchant Category Code) activity.")]
    MerchantCategoryActivity = CardTransactionRiskReasonCode.MerchantCategoryActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious amount.
    /// Encoded/decoded by serializers as &quot;AMNT&quot;.
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_DQchwXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious amount.")]
    SuspiciousAmount = CardTransactionRiskReasonCode.SuspiciousAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious fraudulent cardholder.
    /// Encoded/decoded by serializers as &quot;CRDF&quot;.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_DYylcXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious fraudulent cardholder.")]
    SuspiciousFraudulentCardholder = CardTransactionRiskReasonCode.SuspiciousFraudulentCardholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious fraudulent merchant.
    /// Encoded/decoded by serializers as &quot;MRCF&quot;.
    /// </summary>
    [EnumMember(Value = "MRCF")]
    [IsoId("_DeoHsXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious fraudulent merchant.")]
    SuspiciousFraudulentMerchant = CardTransactionRiskReasonCode.SuspiciousFraudulentMerchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious transaction cumulated amount at merchant.
    /// Encoded/decoded by serializers as &quot;TXCA&quot;.
    /// </summary>
    [EnumMember(Value = "TXCA")]
    [IsoId("_DkI50XsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction cumulated amount at merchant.")]
    TransactionCumulativeAmount = CardTransactionRiskReasonCode.TransactionCumulativeAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious transaction number at merchant.
    /// Encoded/decoded by serializers as &quot;TXNB&quot;.
    /// </summary>
    [EnumMember(Value = "TXNB")]
    [IsoId("_DpgiAXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction number at merchant.")]
    TransactionNumber = CardTransactionRiskReasonCode.TransactionNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious transaction time.
    /// Encoded/decoded by serializers as &quot;TXTM&quot;.
    /// </summary>
    [EnumMember(Value = "TXTM")]
    [IsoId("_Du3jIXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction time.")]
    TransactionTime = CardTransactionRiskReasonCode.TransactionTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious transaction time interval.
    /// Encoded/decoded by serializers as &quot;TMIN&quot;.
    /// </summary>
    [EnumMember(Value = "TMIN")]
    [IsoId("_D01BMXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction time interval.")]
    TransactionTimeIinterval = CardTransactionRiskReasonCode.TransactionTimeIinterval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious transaction type.
    /// Encoded/decoded by serializers as &quot;TXTP&quot;.
    /// </summary>
    [EnumMember(Value = "TXTP")]
    [IsoId("_D9E-QXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction type.")]
    TransactionType = CardTransactionRiskReasonCode.TransactionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspicious unattended terminal activity.
    /// Encoded/decoded by serializers as &quot;UATA&quot;.
    /// </summary>
    [EnumMember(Value = "UATA")]
    [IsoId("_ECb_YXsNEeSR68OJvMfxJQ")]
    [Description(@"Suspicious unattended terminal activity.")]
    UnattendedActivity = CardTransactionRiskReasonCode.UnattendedActivity, // same ordinal as derivation source for type conversions
}
